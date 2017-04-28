/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;

namespace OutSystems.RuntimeCommon {

    [Serializable]
    public class MessageDefinition {

        public readonly string Id;
        public readonly string Message;
        public readonly string Detail;
        public readonly string Description;
        public readonly string Footer;
        public string ExtraInfo { get; set; }
        public readonly int HelpRef;
        public readonly MessageType Type = MessageType.Error;
        public readonly bool Submitable;
        public readonly Button[] Buttons;
        public readonly ButtonType DefaultButton;
        public readonly ButtonType CancelButton;

        public enum ButtonType {
            None,
            Yes,
            No,
            Ok,
            Cancel,
            Close,
            Retry,
            SubmitFeedback,
            Help,
            Custom1,
            Custom2,
            Custom3,
        }

        [Serializable]
        public struct Button {

            private readonly ButtonType type;
            public ButtonType Type {
                get { return type; }
            }

            private readonly string caption;
            public string Caption {
                get {
                    if (string.IsNullOrEmpty(caption)) {
                        return GetDefaultCaption(Type);
                    } else {
                        return caption;
                    }
                }
            }

            private readonly string details;
            public string Details {
                get { return details; }
            }

            public readonly bool isStandard;
            public bool IsStandard {
                get { return isStandard; }
            }

            public Button(ButtonType type, string caption, string details, bool isStandard) {
                this.type = type;
                this.caption = caption;
                this.details = details;
                this.isStandard = isStandard;
            }

            private string GetDefaultCaption(ButtonType buttonType) {
                switch (buttonType) {
                    case ButtonType.Yes:
                        return "_Yes";
                    case ButtonType.No:
                        return "_No";
                    case ButtonType.Ok:
                        return "_Ok";
                    case ButtonType.Cancel:
                        return "_Cancel";
                    case ButtonType.Close:
                        return "Cl_ose";
                    case ButtonType.Help:
                        return "_Help";
                    case ButtonType.Retry:
                        return "_Retry";
                    default:
                        throw new InvalidOperationException();
                }
            }

            public override string ToString() {
                return Caption;
            }
        }

        public static string UnescapeString(string s) {
            return (s ?? string.Empty).Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\t", "\t");
        }

        public MessageDefinition(string id, MessageType type, string message, string detail, string description, string footer, string extraInfo, int helpRef, bool submitable, Button[] buttons, ButtonType defaultButton, ButtonType cancelButton) {
            Id = id;
            Type = type;
            Message = UnescapeString(message);
            Detail = UnescapeString(detail);
            Description = UnescapeString(description);
            Footer = UnescapeString(footer);
            ExtraInfo = UnescapeString(extraInfo);
            HelpRef = helpRef;
            Submitable = submitable;
            Buttons = buttons ?? EmptyArray<Button>.Instance;
            DefaultButton = defaultButton;
            CancelButton = cancelButton;
        }

        private static List<string> SplitButtonsString(string buttons) {
            List<string> results = new List<string>();
            bool insideLabel = false;
            StringBuilder currentButton = new StringBuilder();

            for (int i = 0; i < buttons.Length; i++) {
                switch (buttons[i]) {
                    case ',':
                        if (!insideLabel) {
                            results.Add(currentButton.ToString());
                            currentButton.Length = 0;
                        } else {
                            currentButton.Append(buttons[i]);
                        }
                        break;
                    case '[':
                        insideLabel = true;
                        currentButton.Append(buttons[i]);
                        break;
                    case ']':
                        insideLabel = false;
                        currentButton.Append(buttons[i]);
                        break;
                    default:
                        currentButton.Append(buttons[i]);
                        break;
                }
            }

            if (currentButton.Length > 0) {
                results.Add(currentButton.ToString());
            }

            return results;
        } 

        public static Button[] ParseButtons(string str) {
            var buttons = new List<Button>();
            foreach (var buttonDefinition in SplitButtonsString(str)) {
                    int pos = buttonDefinition.IndexOf("[");
                    ButtonType buttonType;
                    string buttonCaption;
                    string buttonDetails;
                    bool isStandardButton;
                    if (pos == -1) {
                        buttonType = (ButtonType)Enum.Parse(typeof(ButtonType), buttonDefinition);
                        buttonCaption = string.Empty;
                    } else {
                        buttonType = (ButtonType)Enum.Parse(typeof(ButtonType), buttonDefinition.Substring(0, pos));
                        str = buttonDefinition.Substring(pos + 1);
                        buttonCaption = str.TrimEnd(']');
                    }
                    buttonDetails = string.Empty;
                    isStandardButton = true;
                    buttons.Add(new Button(buttonType, buttonCaption, buttonDetails, isStandardButton));
                };
            return buttons.ToArray();
        }

        public string ButtonsString {
            get {
                var sb = new StringBuilder();
                bool first = true;
                foreach (var button in Buttons) {
                    if (first) {
                        first = false;
                    } else {
                        sb.Append(",");
                    }
                    sb.Append(button.Type +
                        (string.IsNullOrEmpty(button.Caption) ?
                                    string.Empty :
                                    "[" + button.Caption + (button.IsStandard ?
                                                                string.Empty :
                                                                button.Caption + "," + button.Details) + "]"));
                }
                return sb.ToString();
            }
        }

        public override string ToString() {
            string result = string.Empty;
            result += "Id: " + Id + Environment.NewLine;
            result += "Type: " + Type.ToString() + Environment.NewLine;
            if (!string.IsNullOrEmpty(Message)) {
                result += "Message: " + Message + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Detail)) {
                result += "Detail: " + Detail + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Description)) {
                result += "Description: " + Description + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Footer)) {
                result += "Footer: " + Footer + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(ExtraInfo)) {
                result += "ExtraInfo: " + ExtraInfo + Environment.NewLine;
            }
            if (HelpRef != 0) {
                result += "HelpRef: " + HelpRef + Environment.NewLine;
            }
            result += "Submitable : " + (Submitable ? "Yes" : "No") + Environment.NewLine;
            if (Buttons.Length != 0) {
                result += "Buttons: " + ButtonsString;
            }
            if (DefaultButton != ButtonType.None) {
                result += "DefaultButton: " + DefaultButton;
            }
            if (CancelButton != ButtonType.None) {
                result += "CancelButton: " + CancelButton;
            }
            return result;
        }

        private static Regex _rwParams;

        
        private static readonly Dictionary<Pair<string, Assembly>, ResourceManager> resourceManagers = new Dictionary<Pair<string, Assembly>, ResourceManager>();
        
        private static readonly Dictionary<Pair<ResourceManager, string>, string> resourceStrings = new Dictionary<Pair<ResourceManager, string>, string>();

        
        private MessageDefinition(MessageId messageId, params string[] args) {

            try {
                var resourceManagerKey = Pair.Create(messageId.ResourcesBaseName, messageId.GetType().Assembly);
                var resourceManager = resourceManagers.GetOrAdd(resourceManagerKey, () => 
                    new ResourceManager(messageId.ResourcesBaseName, messageId.GetType().Assembly)
                );

                var resourceStringKey = Pair.Create(resourceManager, messageId.IdInResourceBaseName);
                var text = resourceStrings.GetOrAdd(resourceStringKey,
                    () => UnescapeString(resourceManager.GetString(messageId.IdInResourceBaseName)));

                if (_rwParams == null) {
                    _rwParams = new Regex("\\{([0-9]+)\\}", RegexOptions.Compiled);
                }
                var matches = _rwParams.Matches(text);
                int max = -1;
                foreach (Match m in matches) {
                    int dummy = int.Parse(m.Groups[1].Value, Constants.IntegerFormatProvider);
                    if (max < dummy)
                        max = dummy;
                }
                max++;

                string extraInfo = null;

                if (args == null) {
                    args = new string[0];
                }
                if ((args.Length == 0 && max > 0) || (args.Length > 0 && args.Length < max)) {
                    extraInfo = Environment.NewLine + "This message references more parameters than it receives.";
                    // Remove extraneous references otherwise it will crash
                    // while formatting the string and the result will be even less useful
                    int slider = 0;
                    foreach (Match m in matches) {
                        int dummy = int.Parse(m.Groups[1].Value, Constants.IntegerFormatProvider);
                        if (dummy >= args.Length) {
                            text = text.Remove(m.Index - slider, m.Length);
                            slider += m.Length;
                        }
                    }
                } else if (args.Length > max) {
                    extraInfo = Environment.NewLine + "This message is receiving more parameters than it uses.";
                }

                if (string.IsNullOrEmpty(text)) {
                    Message = "Error loading resources";
                    Detail = "Unable to find string for message id '" + messageId + "'.";
                    return;
                }

                text = text.Replace(Environment.NewLine, Constants.NewLineCharacter).Replace(Constants.NewLineCharacter, Environment.NewLine);
                text = text.ReplaceBranding();
                string[] parts = string.Format(text.Replace('|', '\0'), args).Split('\0');
                if (parts.Length != 12) {
                    Message = "Error loading resources";
                    Detail = "Unable to parse string for message id '" + messageId + "'.";
                    return;
                }

                Id = parts[0];

                Type = (MessageType)Enum.Parse(typeof(MessageType), parts[1]);

                Message = parts[2];

                Detail = parts[3];

                Description = parts[4];

                Footer = parts[5];

                ExtraInfo = parts[6];

                if (!string.IsNullOrEmpty(extraInfo)) {
                    if (!string.IsNullOrEmpty(ExtraInfo)) {
                        ExtraInfo += extraInfo;
                    } else {
                        ExtraInfo = extraInfo;
                    }
                }

                int helpRef;
                if (int.TryParse(parts[7], NumberStyles.Integer, Constants.IntegerFormatProvider, out helpRef)) {
                    HelpRef = helpRef;
                }

                Submitable = true;
                bool.TryParse(parts[8], out Submitable);

                string buttonsStr = parts[9];
                if (string.IsNullOrEmpty(buttonsStr)) {
                    Buttons = EmptyArray<Button>.Instance;
                } else {
                    Buttons = ParseButtons(buttonsStr);
                }

                var defaultButtonStr = parts[10];
                if (string.IsNullOrEmpty(defaultButtonStr)) {
                    DefaultButton = ButtonType.None;
                } else {
                    DefaultButton = (ButtonType)Enum.Parse(typeof(ButtonType), defaultButtonStr);
                }

                var cancelButtonStr = parts[11];
                if (string.IsNullOrEmpty(cancelButtonStr)) {
                    CancelButton = ButtonType.None;
                } else {
                    CancelButton = (ButtonType)Enum.Parse(typeof(ButtonType), cancelButtonStr);
                }

            } catch (Exception e) {
                Message = "Error loading resources";
                Detail = "Unable to find string for message id '" + messageId + "'." + Environment.NewLine + e;
                Buttons = EmptyArray<Button>.Instance;
            }
        }

        
        public static MessageDefinition GetMessage(MessageId messageId, params string[] args) {
            return new MessageDefinition(messageId, args);
        }

        
        private static Dictionary<Pair<string, string>, MessageType> messageTypesCache = new Dictionary<Pair<string, string>, MessageType>();

        
        public static MessageType GetMessageType(MessageId messageId) {
            var key = Pair.Create(messageId.IdInResourceBaseName, messageId.ResourcesBaseName);
            return messageTypesCache.GetOrAdd(key, () => GetMessage(messageId).Type);
        }

        public override bool Equals(object obj) {
            var message = obj as MessageDefinition;

            if (message == null) {
                return false;
            }

            return Id == message.Id &&
                   Message == message.Message &&
                   Detail == message.Detail &&
                   Description == message.Description &&
                   Footer == message.Footer &&
                   ExtraInfo == message.ExtraInfo &&
                   HelpRef == message.HelpRef &&
                   Type == message.Type &&
                   Submitable == message.Submitable;
        }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }
    }
}