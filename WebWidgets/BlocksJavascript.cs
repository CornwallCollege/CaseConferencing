/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.WebWidgets {
    public class BlocksJavascript {   
        private class JavascriptNode {
            private JavascriptNodeCollection childJavascriptNodes = new JavascriptNodeCollection();
            
            public string JavaScriptFileName { get; set; }
            public IEnumerable<JavascriptNode> ChildJavascriptNodes { get { return childJavascriptNodes; } }
            public bool AlreadyIncluded { get; set; }

            public void AddChild(JavascriptNode node) {
                if (childJavascriptNodes.Add(node)) {
                    node.Parent = this;
                }
            }

            public JavascriptNode Parent { get; private set; }

            public JavascriptNode(string identifier) {
                Identifier = identifier;
            }

            public string Identifier { get; private set; }
        }

        private class JavascriptNodeCollection: IEnumerable<JavascriptNode> {
            private ICollection<JavascriptNode> collection = new List<JavascriptNode>();
            private HashSet<JavascriptNode> insertedJavascriptNode = new HashSet<JavascriptNode>();

            IEnumerator IEnumerable.GetEnumerator() {
                return collection.GetEnumerator();
            }
            
            public IEnumerator<JavascriptNode> GetEnumerator() {
                return collection.GetEnumerator();
            }
            
            public bool Add(JavascriptNode node) {
                if (insertedJavascriptNode.Add(node)) {
                    collection.Add(node);
                    return true;
                } else {
                    return false;
                }
            }

            public bool Contains(JavascriptNode node) {
                return insertedJavascriptNode.Contains(node);
            }         
        }

        private IDictionary<string, JavascriptNode> JavascriptNodes = new Dictionary<string, JavascriptNode>();
        private OSPage page;
        private JavascriptNodeCollection rootJavascriptNodes = new JavascriptNodeCollection();
        private ICollection<JavascriptNode> alreadyIncludedBlocksWithJavaScript = new List<JavascriptNode>();

        private JavascriptNode GetJavascriptNode(string identifier) {
            JavascriptNode javaScriptNode;            

            if (!JavascriptNodes.TryGetValue(identifier, out javaScriptNode)) {
                javaScriptNode = new JavascriptNode(identifier);
                JavascriptNodes.Add(identifier, javaScriptNode);
            }

            return javaScriptNode;
        }

        private JavascriptNode GetBlockJavascriptNodeAndFillItsParent(OSUserControl block) {
            JavascriptNode result = GetJavascriptNode(block.WebBlockIdentifier);

            if ((result.Parent == null) && !rootJavascriptNodes.Contains(result)) {
                // find the correspondent parent block

                
                var parentBlock = Utils.GetOwnerOfControl(block.Parent) as OSUserControl;
            
                if (parentBlock == null) {
                    rootJavascriptNodes.Add(result);
                } else {
                    GetBlockJavascriptNodeAndFillItsParent(parentBlock).AddChild(result);
                }
            }

            return result;
        }

        private JavascriptNode GetWidgetJavascriptNode(string identifier) {
            JavascriptNode result = GetJavascriptNode(identifier);

            if ((result.Parent == null) && !rootJavascriptNodes.Contains(result)) {
                rootJavascriptNodes.Add(result);
            }

            return result;
        }

        private IEnumerable<JavascriptNode> GetChildNodesAndSelf(JavascriptNode javascriptNode) {
            return javascriptNode.ChildJavascriptNodes.SelectMany(c => GetChildNodesAndSelf(c)).Concat(javascriptNode);
        }

        private IEnumerable<JavascriptNode> BlockNodesWithInnerFirst {
            get {
                return rootJavascriptNodes.SelectMany(n => GetChildNodesAndSelf(n));
            }
        }

        private IEnumerable<JavascriptNode> BlocksWithJavaScript {
            get {
                // add all the block javascripts for this page according to the block hierarchy
                IEnumerable<JavascriptNode> blocksWithJavaScriptNotIncluded = 
                    BlockNodesWithInnerFirst.Where(n => !n.AlreadyIncluded && !String.IsNullOrEmpty(n.JavaScriptFileName));

                foreach (JavascriptNode blockWithJavaScriptNotIncluded in blocksWithJavaScriptNotIncluded) {
                    blockWithJavaScriptNotIncluded.AlreadyIncluded = true;
                    alreadyIncludedBlocksWithJavaScript.Add(blockWithJavaScriptNotIncluded);
                }

                return alreadyIncludedBlocksWithJavaScript;
            }
        }

        public void RegisterBlock(OSUserControl block) {            
            GetBlockJavascriptNodeAndFillItsParent(block).JavaScriptFileName = block.JavaScriptFileName;
        }

        public void RegisterWidgetJavascript(string javaScriptFileName) {
            GetWidgetJavascriptNode(javaScriptFileName).JavaScriptFileName = javaScriptFileName;
        }

        public BlocksJavascript(OSPage page) {
            this.page = page;
        }

        public void WriteBlockJavaScriptIncludes(StringWriter writer) {
            foreach (string javascriptFileName in BlockJavaScriptIncludeFilenames) {
                writer.WriteLine("    " + JavaScriptManager.GetBlockJavaScriptInclude(javascriptFileName));
            }
        }

        public IEnumerable<string> BlockJavaScriptIncludeFilenames {
            get {
                return BlocksWithJavaScript.Select(n => page.ReplaceBasePath(n.JavaScriptFileName));
            }
        }

        public void LoadAlreadyIncludedBlocks(StateBag viewState) {
            if (OSPage.IsAjaxRequest) {
                
                ArrayList jsKeys = (ArrayList) viewState["JSKeys"];

                if (jsKeys != null) {
                    foreach (string key in jsKeys) {
                        GetJavascriptNode(key).AlreadyIncluded = true;
                    }
                }
            } else {
                
                viewState.Remove("JSKeys");
            }
        }

        public void SaveAlreadyIncludedBlocks(StateBag viewState) {
            // in Safari & Chrome browsers we must reload all dynamically loaded javascripts after the user returns to the page
            // via a back button, so for these browsers do not save the sent javascript files in the viewstate so that they are
            // sent again in ajax refresh nodes.
            
            
            bool isSafariBrowser = (page.Request.Browser.Browsers.IndexOf("safari") != -1);

            if (!isSafariBrowser) {
                ArrayList jsKeys = new ArrayList();
                BlockNodesWithInnerFirst.Where(n => n.AlreadyIncluded).Apply(n => jsKeys.Add(n.Identifier));

                
                viewState["JSKeys"] = jsKeys;
            }

            
            return;
        }

        // this must be called at the end of the AjaxRefresh so that a second
        // refresh on the same flow won't ask for the JavaScript files in duplicate
        public void CleanupAlreadyIncludedBlocksWithJavaScript() {
            alreadyIncludedBlocksWithJavaScript.Clear();
        }
    }
}
