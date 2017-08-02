using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TreeLoader
{
    public class XmlTreeBuilder
    {
        private readonly string _xmlFileName;

        #region Constructors

        public XmlTreeBuilder(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException(nameof(filename));

            if (!File.Exists(_xmlFileName)
                || !Path.GetFileName(_xmlFileName)
                        .EndsWith(".xml", StringComparison.CurrentCultureIgnoreCase))
                throw new ArgumentException("Provided filename are not exists or not valid xml filename.");

            _xmlFileName = filename;
        }

        #endregion Constructors

        public Node BuildTree()
        {
            var root = new Node();

            using (var streamReader = new StreamReader(_xmlFileName))
            {
                using (var xmlReader = XmlReader.Create(streamReader))
                {
                    while (xmlReader.Read())
                    {
                        switch (xmlReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                break;

                            case XmlNodeType.Attribute:
                                break;

                            case XmlNodeType.Text:
                                break;

                            case XmlNodeType.CDATA:
                                break;

                            case XmlNodeType.EndElement:
                                break;

                            case XmlNodeType.XmlDeclaration:
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            return null;
        }
    }
}