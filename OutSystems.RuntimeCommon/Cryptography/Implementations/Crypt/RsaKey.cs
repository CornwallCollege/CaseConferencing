/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Xml;

namespace OutSystems.RuntimeCommon.Cryptography.Implementations.Crypt
{
    /// <summary>
    /// NOTE: This algorithm is FIPS compliant...
    /// </summary>
    public class RsaKey {

        protected int RADIX = 10; // Defines the RADIX to be used when ToString'ing the BigInts

        private bool isPrivate;

        private BigInteger modulus;

        private BigInteger exponent;

        public RsaKey(string xmlRepresentation) {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlRepresentation);
            this.modulus = GetNodeValue(doc, "Modulus");
            this.exponent = GetNodeValue(doc, "Exponent");
        }

        public RsaKey(bool isPrivate, BigInteger modulus, BigInteger exponent) {
            this.isPrivate = isPrivate;
            this.modulus = modulus;
            this.exponent = exponent;
        }

        public BigInteger Modulus {
            get {
                return modulus;
            }
        }

        public BigInteger Exponent {
            get {
                return exponent;
            }
        }

        public Boolean IsPrivate {
            get {
                return isPrivate;
            }
        }

        protected BigInteger GetNodeValue(XmlDocument doc, string nodeName) {
            XmlNode node = doc.SelectSingleNode("//" + nodeName);
            if (node != null && node.InnerText != null && node.InnerText != "") {
                BigInteger bigInt = new BigInteger(node.InnerText);
                return bigInt;
            } else {
                return null;
            }
        }

        protected void AddXmlElement(XmlDocument doc, XmlNode parent, string name, string value) {
            XmlElement element = doc.CreateElement(name);
            element.InnerText = value;
            parent.AppendChild(element);
        }

        public XmlDocument ToXmlDocument() {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode root = xmldoc.CreateElement("RSAKey");
            xmldoc.AppendChild(root);
            AddXmlElement(xmldoc, root, "Exponent", this.Exponent.ToString(RADIX));
            AddXmlElement(xmldoc, root, "Modulus", this.Modulus.ToString(RADIX));
            return xmldoc;
        }

        public string ToXmlString() {
            XmlDocument xmldoc = ToXmlDocument();
            return xmldoc.OuterXml;
        }

        public override bool Equals(object obj) {
            RsaKey kp = obj as RsaKey;
            if (kp != null) {
                if (kp.IsPrivate == this.IsPrivate
                    && kp.Modulus.Equals(this.modulus)
                    && kp.Exponent.Equals(this.exponent)) {
                        return true;
                    }
            }
            return false;
        }

        public override int GetHashCode() {
            return this.Modulus.GetHashCode() ^ this.Exponent.GetHashCode() ^ (this.IsPrivate ? 1 : 0);
        }
    }
}