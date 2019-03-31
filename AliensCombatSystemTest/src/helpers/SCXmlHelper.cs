using AliensCombatSystemTest.src.Models;
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

            m_strServerConstantParent = "serverConstant",
            m_strAliensWeaponParametersParent = "aliensWeaponParameters",
             m_strAliensResultParametersParent = "aliensResultParameters",
             m_strAliensTargetParametersParent = "aliensTargetParameters",

            m_strHumansWeaponParametersParent = "humansWeaponParameters",
            m_strHumansTargetParametersParent = "humansTargetParameters",
            m_strHumansResultParametersParent = "humansResultParameters",
      //      m_strPathHead = "C:\\Users\\user\\source\\repos\\AliensCombatSystemTest\\AliensCombatSystemTest\\src\\xmls\\",
        m_strPathHead = "C:\\Users\\daupoh\\Source\\Repos\\AlienCombatTool\\AliensCombatSystemTest\\src\\xmls\\",

            m_strFilePathModelError = m_strPathHead+"ModelErrors.xml",
            m_strFilePathAliensWeaponParameter= m_strPathHead + "AliensWeaponParameters.xml",
            m_strFilePathAliensTargetParameter = m_strPathHead + "AliensTargetParameters.xml",
            m_strFilePathAliensResultParameter = m_strPathHead + "AliensResultParameters.xml",

            m_strFilePathHumansWeaponParameter = m_strPathHead + "HumansWeaponParameters.xml",
            m_strFilePathHumansTargetParameter = m_strPathHead + "HumansTargetParameters.xml",
            m_strFilePathHumansResultParameter = m_strPathHead + "HumansResultParameters.xml",


            m_strFilePathStringConstant = m_strPathHead + "StringConstants.xml";
        
        public static string RowFromAliensWeapon(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strAliensWeaponParametersParent
               , m_strFilePathAliensWeaponParameter, number);
            return result;
        }
        public static string RowFromAliensTarget(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strAliensTargetParametersParent
               , m_strFilePathAliensTargetParameter, number);
            return result;
        }
        public static string RowFromAliensResult(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strAliensResultParametersParent
                , m_strFilePathAliensResultParameter, number);
            return result;
        }
        public static string RowFromHymansWeapon(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strHumansWeaponParametersParent, m_strFilePathHumansWeaponParameter, number);
            return result;
        }
        public static string RowFromHumansTarget(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strHumansTargetParametersParent, m_strFilePathHumansTargetParameter, number);
            return result;
        }
        public static string RowFromHumansResult(int number)
        {
            string result = "";
            SCChecker.CheckNumberMoreOrEqualThenZero(number);
            result = getRowsInNode(m_strHumansResultParametersParent, m_strFilePathHumansResultParameter,number);
            return result;
        }
        public static int CountOfAlienWeaponRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strAliensWeaponParametersParent, m_strFilePathAliensWeaponParameter);
                return result;
            }
        }
        public static int CountOfAlienTargetRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strAliensTargetParametersParent, m_strFilePathAliensTargetParameter);
                return result;
            }
        }
        public static int CountOfAlienResultRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strAliensResultParametersParent, m_strFilePathAliensResultParameter);
                return result;
            }
        }
        public static int CountOfHumanWeaponRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strHumansWeaponParametersParent, m_strFilePathHumansWeaponParameter);
                return result;
            }
        }
        public static int CountOfHumanResultRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strHumansResultParametersParent, m_strFilePathHumansResultParameter);
                return result;
            }
        }
        public static int CountOfHumanTargetRows
        {
            get
            {
                int result = 0;
                result = getCoundOfRowsInNode(m_strHumansTargetParametersParent, m_strFilePathHumansTargetParameter);
                return result;
            }
        }

        public static string getServerError(string nodeName)
        {
            string serverError = "";
            serverError = getTextByNode(m_strServerErrorsParent, nodeName, m_strFilePathModelError);
            return serverError;
        }
        public static string getAliensWeaponParameter(string nodeName)
        {
            string alienWeaponParameter = "";
            alienWeaponParameter = getTextByNode(m_strAliensWeaponParametersParent,
                nodeName, m_strFilePathAliensWeaponParameter);
            return alienWeaponParameter;
        }
        public static string getServerConstant(string nodeName)
        {
            string serverConst = "";
            serverConst = getTextByNode(m_strServerConstantParent, nodeName, m_strFilePathStringConstant);
            return serverConst;
        }
        private static string getTextByNode(string parentNode, string nodeName, string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            string textNode = "";
            XmlElement xRoot = xmlDoc.DocumentElement;
            bool nodeHasFinded = false;
            if (xRoot.Name == parentNode)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    textNode = xnode.InnerText;
                    nodeHasFinded = true;
                    break;
                }
            }                         
            if (!nodeHasFinded)
            {
                throw new FormatException(m_strXmlError);
            }
            return textNode;
        }
        private static int getCoundOfRowsInNode(string parentNode, string filePath)
        {
            int result = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xRoot = xmlDoc.DocumentElement;
            if (xRoot.Name == parentNode)
            {
                foreach (XmlElement xpnode in xRoot)
                {
                    result++;
                   
                }

            }
          
            return result;
        }
        private static string getRowsInNode(string parentNode, string filePath,int index)
        {
            string result = "";
            int count = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xRoot = xmlDoc.DocumentElement;
            if (xRoot.Name == parentNode)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    if (count == index)
                    {
                        result = xnode.InnerText;
                    break;
                    }
                    count++;
                }
            }      
            return result;
        }
        
    }
}

