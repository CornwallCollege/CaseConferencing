/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.DirectoryServices;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform
{
    public class IISAdmin {

        private static int GetWebSiteId(string instanceName) {
            int id = 0;
            if (websiteIdGetterOverride != null) {
                id = websiteIdGetterOverride(instanceName);
                if (id > 0) {
                    return id;
                } else {
                    id = 0;
                }
            }
            using (DirectoryEntry root = OSDirectoryEntry.New(IISBasePath)) {

                string site = GetWebSiteName(root, instanceName);

                DirectoryEntries children = OSDirectoryEntry.GetChildren(root);

                foreach (DirectoryEntry entry in children) {
                    try {
                        if (entry.SchemaClassName == "IIsWebServer" && ((string)entry.InvokeGet("ServerComment")) == site) {
                            id = Convert.ToInt32(entry.Name);
                        }
                    } finally {
                        entry.Close();
                    }
                }

            }
            return id;
        }

        public delegate int websiteIdGetter(string instanceName);
        private static websiteIdGetter websiteIdGetterOverride = null;
        public static void RegisterWebsiteIdGetterOverride(websiteIdGetter getter) {
            websiteIdGetterOverride = getter;
        }

        public static string GetApplicationPoolName() {
            return GetApplicationPoolName(Settings.Get(Settings.Configs.InstanceName));
        }

        private static string GetApplicationPoolName(string instanceName) {
            if (instanceName == Settings.GetDefaultValue(Settings.Configs.InstanceName)) {
                return Settings.Get(Settings.Configs.IIS_DefaultApplicationPool);
            } else {
                return instanceName;
            }
        }

        public static string GetWebSiteName(DirectoryEntry root) {
            return GetWebSiteName(root, Settings.Get(Settings.Configs.InstanceName));
        }

	    private static string GetWebSiteName(DirectoryEntry root, string instanceName) {
            if (instanceName == Settings.GetDefaultValue(Settings.Configs.InstanceName)) {

                string defaultWebSiteName = Settings.Get(Settings.Configs.IIS_DefaultWebSiteName);
                if (defaultWebSiteName != Settings.GetDefaultValue(Settings.Configs.IIS_DefaultWebSiteName)) {
                    return defaultWebSiteName;
                }

                string firstchildname = "";

                DirectoryEntries children = OSDirectoryEntry.GetChildren(root);

                foreach (DirectoryEntry entry in children) {
                    try {
                        if (entry.SchemaClassName == "IIsWebServer") {
                            if (firstchildname == "") {
                                firstchildname = ((string)entry.InvokeGet("ServerComment"));
                            }

                            //not sure if I should look for ID=1... maybe sniffing the bindings would be better?
                            if (entry.Name == "1") {
                                return ((string)entry.InvokeGet("ServerComment"));
                            }
                        }
                    } finally {
                        entry.Close();
                    }
                }

                if (firstchildname != "") {
                    return firstchildname; //if no Id=1 found, fallback to firstchild
                } else {
                    return Settings.GetDefaultValue(Settings.Configs.IIS_DefaultWebSiteName); //This return is only used for creating a NEW web site
                }
            } else {
                return instanceName;
            }
        }

        
        public static string IISBasePath{
            get {
                return "IIS://localhost/W3SVC";
            }
        }
        public static string IISAppPoolsPath{
            get {
                return IISBasePath + "/AppPools";
            }
        }
        public static string IISFileSystemRootPath{
            get {
                return @"C:\Inetpub\wwwroot";
            }
        }

        private static string GetIISRoot(string instanceName) {
            return IISBasePath + "/" + GetWebSiteId(instanceName) + "/Root";
        }

        public static string GetIISRoot() {
            return GetIISRoot(Settings.Get(Settings.Configs.InstanceName));
        }

        public static string GetIISPath(string eSpaceName) {
            return GetIISRoot() + "/" + eSpaceName;
        }

        public static string GetIISPath( string eSpaceName, string tenantOrAreaName) {
            return GetIISRoot() + "/" + eSpaceName + "/" + tenantOrAreaName;
        }

		/* jec: getting the hostname to connect */
		public static string GetHostName() {
			string host = "localhost";
            try {
                string dir = IISBasePath + "/" + GetWebSiteId();

                using (DirectoryEntry root = OSDirectoryEntry.New(dir)) {

                    object[] bindings;

                    object value = root.Properties["ServerBindings"].Value;
                    if (value != null) {
                        if (value is string) {
                            bindings = new string[1] { (string)value };
                        } else {
                            bindings = (object[])value;
                        }
                    } else {
                        bindings = new object[0];
                    }

                    foreach (string binding in bindings) {
                        string[] tmp = binding.Split(':');
                        if (tmp.Length == 3) {
                            // string format is something like ":<port>:<host>"
                            // so there are 3 fields: 0 => "", 1 => "<port>", 2 => "host"
                            host = new string((tmp[2] != "" ? tmp[2] + (tmp[1] != "" ? ":" + tmp[1] : "") : host + ":" + tmp[1]).ToCharArray());
                            break;
                        }
                    }
                }
            } catch { 
            }
			return host;
		}

		public static int GetWebSiteId() {
			return GetWebSiteId(Settings.Get(Settings.Configs.InstanceName));
		}

		public static string DefaultParent {
			get { return GetIISRoot(); }
		}

		public static Hashtable GetVirtualDirs() {
			Hashtable currentVDirs = new Hashtable();
            using (DirectoryEntry root = OSDirectoryEntry.New(IISAdmin.IISBasePath)) {
                root.UsePropertyCache = true;
                DirectoryEntries children = OSDirectoryEntry.GetChildren(root);
                foreach (DirectoryEntry entry in children) {
                    try {
                        if (entry.SchemaClassName == "IIsWebServer") {
                            using (DirectoryEntry direntry = OSDirectoryEntry.New(IISAdmin.IISBasePath + "/" + entry.Name + "/Root")) {
                                foreach (DirectoryEntry vDir in OSDirectoryEntry.GetChildren(direntry)) {
                                    if (vDir.SchemaClassName == "IIsWebVirtualDir") {
                                        try {
                                            currentVDirs[vDir.Name] = PathRuleKind.PassThroughVDir;
                                        } finally {
                                            vDir.Close();
                                        }
                                    }
                                }
                            }
                        }
                    } finally {
                        entry.Close();
                    }
                }
            }

			return currentVDirs;
		}

        public delegate bool changeVdir(string espaceName, string path, string rootPath, out bool ok);
        private static changeVdir changeVdirOverride = null;
        public static void RegisterChangeVdirOverride(changeVdir changeVdir) {
            changeVdirOverride = changeVdir;
        }


        public static bool ChangeVdirPath(DirectoryEntry rootEntry, string espaceName, string path, string rootPath) {
            bool changed = false;
            if (changeVdirOverride != null) {
                bool ok;
                changed = changeVdirOverride(espaceName, path, rootPath, out ok);
                if (ok){
                    return changed;
                }
            }

            using (DirectoryEntry root = OSDirectoryEntry.New(IISBasePath)) {
                root.UsePropertyCache = true;
                DirectoryEntries children = OSDirectoryEntry.GetChildren(root);
                foreach (DirectoryEntry entry in children) {
                    try {
                        if (entry.SchemaClassName == "IIsWebServer") {
                            using (DirectoryEntry direntry = OSDirectoryEntry.New(IISBasePath + "/" + entry.Name + "/Root")) {
                                changed |= changeVdirPath(direntry, espaceName, path, rootPath);
                                foreach (DirectoryEntry espaceDir in OSDirectoryEntry.GetChildren(direntry)) {
                                    try {
                                        if (espaceDir.SchemaClassName == "IIsWebVirtualDir") {
                                            changed |= changeVdirPath(espaceDir, espaceName, path, rootPath);
                                        }
                                    } finally {
                                        espaceDir.Close();
                                    }
                                }
                            }
                        }
                    } finally {
                        entry.Close();
                    }
                }
            }

            //root dir entry is always written
            using (DirectoryEntry rootEntryEspaceDirEntry = OSDirectoryEntry.FindChildren(rootEntry, espaceName, "")) {
                if (rootEntryEspaceDirEntry.Properties["Path"][0].ToString() != path) {
                    rootEntryEspaceDirEntry.Properties["Path"][0] = path;
                    changed = true;
                    OSDirectoryEntry.CommitChanges(rootEntryEspaceDirEntry);
                }
            }

            return changed;
        }

        private static bool changeVdirPath(DirectoryEntry espaceDir, string espaceName, string path, string rootPath) {
            try {
                if (IsEspacePath(espaceName, espaceDir.Properties["Path"][0].ToString(), rootPath) && espaceDir.Properties["Path"][0].ToString() != path) {
                    espaceDir.Properties["Path"][0] = path;
                    OSDirectoryEntry.CommitChanges(espaceDir);
                    return true;
                }
            } catch (Exception e) {
                OSTrace.Exception(e);
            }
            return false;
        }

        //return true if path is like AppRoot/EspaceName.<whatever>
        public static bool IsEspacePath(string espaceName, string path, string rootPath) {
            string espacePathLikeType = (rootPath + FileSystemUtils.PathSeparator + espaceName);
            return path.Equals(espacePathLikeType, StringComparison.InvariantCultureIgnoreCase) || path.StartsWith(espacePathLikeType + ".", StringComparison.InvariantCultureIgnoreCase);
        }

		public static bool ExistsInMetabase(string path) {
            using (DirectoryEntry root = OSDirectoryEntry.New(IISBasePath)) {
                DirectoryEntries children = OSDirectoryEntry.GetChildren(root);
                foreach (DirectoryEntry entry in children) {
                    using (entry) {
                        if (entry.SchemaClassName == "IIsWebServer") {
                            using (DirectoryEntry direntry = OSDirectoryEntry.New(IISBasePath + "/" + entry.Name + "/Root")) {
                                if (direntry.Properties["Path"][0].ToString().Equals(path, StringComparison.InvariantCultureIgnoreCase)) {
                                    return true;
                                }
                                foreach (DirectoryEntry espaceDir in OSDirectoryEntry.GetChildren(direntry)) {
                                    using (espaceDir) {
                                        if (espaceDir.SchemaClassName == "IIsWebVirtualDir") {
                                            if (espaceDir.Properties["Path"][0].ToString().Equals(path, StringComparison.InvariantCultureIgnoreCase)) {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
	}

}