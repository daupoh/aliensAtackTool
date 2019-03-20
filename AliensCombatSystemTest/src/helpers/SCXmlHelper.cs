using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gravityPrototype.models
{
    public static class SCXmlHelper
    {
        static string 
            m_strXmlError = "Не найден узел",
            m_strServerErrorsParent = "serverErrors",

            m_strServerConstantParent= "serverConstant",


            m_strFilePathModelError = "C:\\Users\\user\\source\\repos\\gravityPrototype\\gravityPrototype\\models\\ModelErrors.xml",
            m_strFilePathStringConstant = "C:\\Users\\user\\source\\repos\\gravityPrototype\\gravityPrototype\\models\\StringConstants.xml";

        static XmlDocument m_xmlModelErrors,
            m_xmlStringContsants;

        public static string getServerError(string nodeName)
        {
            string serverError = "";
            serverError = getTextByNode(m_xmlModelErrors, m_strServerErrorsParent, nodeName, m_strFilePathModelError);
            return serverError;
        }
        public static string getServerConstant(string nodeName)
        {
            string serverConst = "";
            serverConst = getTextByNode(m_xmlStringContsants, m_strServerConstantParent, nodeName, m_strFilePathStringConstant);
            return serverConst;
        }
        private static string getTextByNode(XmlDocument xmlDoc, string parentNode, string nodeName, string filePath)
        {
            if (xmlDoc == null)
            {
                initializeXmlDoc(xmlDoc,filePath);
            }
            string textNode = "";
            XmlElement xRoot = xmlDoc.DocumentElement;
            bool nodeHasFinded = false;
            foreach (XmlElement xpnode in xRoot)
            {
                if (xpnode.LocalName == parentNode)
                {
                    foreach (XmlElement xnode in xpnode)
                    {
                        if (xnode.LocalName == nodeName)
                        {
                            textNode = xnode.InnerText;
                            nodeHasFinded = true;
                            break;
                        }
                    }
                    break;
                }
            }             
            if (!nodeHasFinded)
            {
                throw new FormatException(m_strXmlError);
            }
            return textNode;
        }

        private static void initializeXmlDoc(XmlDocument xmlDoc, string filePath)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
        }
    }
}

