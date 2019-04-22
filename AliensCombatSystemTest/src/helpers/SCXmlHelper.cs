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
        public const string
            HIGH_ACCURACITY = "Очень Метко",
            NORMAL_ACCURACITY = "Достаточно Метко",
            LOW_ACCURACITY = "Недостаточно Метко",
            BAD_ACCURACITY = "Почти Мимо";
        const string
            m_strXmlError = "Не найден узел",
            m_strServerErrorsParent = "serverErrors",

            m_strParameters = "parameters",
            m_strParametersPools = "parametersPools",
            m_strAlienWorker = "alienWorker",
            m_strAlienSoldier = "alienSoldier",
            m_strAlienHunter = "alienHunter",
            m_strAlienPraetorian = "alienPraetorian",

            m_strHuman = "humanWith",
            m_strSynth = "sunthWith",

            m_strLightWeapon = "_LightWeapon_",
            m_strNormalWeapon = "_NormalWeapon_",
            m_strHeavyWeapon = "_HeavyWeapon_",

            m_strNoEffects = "UnderNothing",
            m_strAllEffects = "UnderAll",
            m_strHumanTrapEffect = "UnderTrap",
            m_strHumanBarricadeEffect = "UnderBarricade",
            m_strHumanZoneEffect = "UnderZone",

            m_strPrimeAtack ="_primeAtack",
            m_strHoldPrimeAtack = "_holdPrimeAtack",
            m_strTailAtack = "_tailAtack",
            m_strBiteAtack = "_biteAtack",
            m_strHoldBiteAtack = "_holdBiteAtack",
            m_strAltAtack = "_altAtack",

            m_strServerConstantParent = "serverConstant",
            m_strAliensWeaponParametersParent = "aliensWeaponParameters",


             m_strAliensResultParametersParent = "aliensResultParameters",
             m_strAliensTargetParametersParent = "aliensTargetParameters",

            m_strHumansWeaponParametersParent = "humansWeaponParameters",
            m_strHumansTargetParametersParent = "humansTargetParameters",
            m_strHumansResultParametersParent = "humansResultParameters",
        //      m_strPathHead = "C:\\Users\\user\\source\\repos\\AliensCombatSystemTest\\AliensCombatSystemTest\\src\\xmls\\",
        m_strPathHead = "C:\\Users\\daupoh\\Source\\Repos\\AlienCombatTool\\AliensCombatSystemTest\\src\\xmls\\",
            //"xmls\\",
            //"C:\\Users\\daupoh\\Source\\Repos\\AlienCombatTool\\AliensCombatSystemTest\\src\\xmls\\",

        m_strFilePathModelError = m_strPathHead + "ModelErrors.xml",
            m_strFilePathAliensWeaponParameter = m_strPathHead + "AliensWeaponParameters.xml",
            m_strFilePathAliensTargetParameter = m_strPathHead + "AliensTargetParameters.xml",
            m_strFilePathAliensResultParameter = m_strPathHead + "AliensResultParameters.xml",

            m_strFilePathHumansWeaponParameter = m_strPathHead + "HumansWeaponParameters.xml",
            m_strFilePathHumansTargetParameter = m_strPathHead + "HumansTargetParameters.xml",
            m_strFilePathHumansResultParameter = m_strPathHead + "HumansResultParameters.xml",


            m_strFilePathStringConstant = m_strPathHead + "StringConstants.xml";

        public static string RowFromXml(string nodeName, string fileCode, string typeCode)
        {
            string result = "", rootNode = "", parentNode = "", filePath = "";
            string[] codes = new string[2];
            codes[0] = fileCode; codes[1] = typeCode;
            SetUp(codes, out rootNode, out parentNode, out filePath);
            result = getRowViewInNode(rootNode, parentNode, nodeName, filePath);
            return result;
        }
        public static int CountRowsFromXml(string fileCode, string typeCode)
        {
            int result = 0;
            string rootNode = "", parentNode = "", filePath = "";
            string[] codes = new string[2];
            codes[0] = fileCode; codes[1] = typeCode;
            SetUp(codes, out rootNode, out parentNode, out filePath);
            result = getCoundOfRowsInNode(rootNode, parentNode,filePath);
            return result;
        }
        public static double DoubleFromXml(string nodeName, string fileCode, string typeCode)
        {
            double result = 0;
            result = Convert.ToDouble(RowFromXml(nodeName, fileCode, typeCode));
            return result;
        }
        public static string RowFromXml(int number, string fileCode, string typeCode)
        {
            string result = "", rootNode = "", parentNode = "", filePath = "";
            string[] codes = new string[2];
            codes[0] = fileCode; codes[1] = typeCode;
            SetUp(codes, out rootNode, out parentNode, out filePath);
            result = getRowsInNode(rootNode, parentNode, filePath, number);
            return result;
        }
        private static string getRowViewInNode(string rootNode, string parentNode, string nodeName, string filePath)
        {
            string result = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xRoot = xmlDoc.DocumentElement;
            if (xRoot.Name == rootNode)
            {
                foreach (XmlElement xpnode in xRoot)
                {
                    if (xpnode.Name == parentNode)
                    {
                        foreach (XmlElement node in xpnode)
                        {
                            if (node.Name == nodeName)
                            {
                                result = node.InnerText;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }
        private static int getCoundOfRowsInNode(string rootNode, string parentNode, string filePath)
        {
            int result = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xRoot = xmlDoc.DocumentElement;
            if (xRoot.Name == rootNode)
            {
                foreach (XmlElement xpnode in xRoot)
                {
                    if (xpnode.Name == parentNode)
                    {
                        foreach (XmlElement node in xpnode)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
        private static string getRowsInNode(string rootNode, string parentNode, string filePath, int index)
        {
            string result = "";
            int count = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement xRoot = xmlDoc.DocumentElement;
            if (xRoot.Name == rootNode)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    if (xnode.Name == parentNode)
                    {
                        foreach (XmlElement node in xnode)
                        {
                            if (count == index)
                            {
                                result = node.InnerText;
                                break;
                            }
                            count++;
                        }
                    }

                }
            }
            return result;
        }
        private static void SetUp(string[] codes, out string rootNode, out string parentNode, out string filePath)
        {
            string fileCode = codes[0],
                typeCode = codes[1];
            switch (fileCode)
            {
                case "ARP":
                    rootNode = m_strAliensResultParametersParent;
                    filePath = m_strFilePathAliensResultParameter;
                    break;
                case "ATP":
                    rootNode = m_strAliensTargetParametersParent;
                    filePath = m_strFilePathAliensTargetParameter;
                    break;
                case "AWP":
                    rootNode = m_strAliensWeaponParametersParent;
                    filePath = m_strFilePathAliensWeaponParameter;
                    break;
                case "HRP":
                    rootNode = m_strHumansResultParametersParent;
                    filePath = m_strFilePathHumansResultParameter;
                    break;
                case "HTP":
                    rootNode = m_strHumansTargetParametersParent;
                    filePath = m_strFilePathHumansTargetParameter;
                    break;
                case "HWP":
                    rootNode = m_strHumansWeaponParametersParent;
                    filePath = m_strFilePathHumansWeaponParameter;
                    break;
                default: throw new FormatException();
            }
            switch (typeCode)
            {
                case "P":
                    parentNode = m_strParameters;
                    break;
                case "PP":
                    parentNode = m_strParametersPools;
                    break;
                case "WP_PA":
                    parentNode = m_strAlienWorker + m_strPrimeAtack;
                    break;
                case "WP_HPA":
                    parentNode = m_strAlienWorker + m_strHoldPrimeAtack;
                    break;
                case "WP_TA":
                    parentNode = m_strAlienWorker + m_strTailAtack;
                    break;
                case "WP_BA":
                    parentNode = m_strAlienWorker + m_strBiteAtack;
                    break;
                case "WP_HBA":
                    parentNode = m_strAlienWorker + m_strHoldBiteAtack;
                    break;
                case "WP_AA":
                    parentNode = m_strAlienWorker + m_strAltAtack;
                    break;
                case "SP_PA":
                    parentNode = m_strAlienSoldier + m_strPrimeAtack;
                    break;
                case "SP_HPA":
                    parentNode = m_strAlienSoldier + m_strHoldPrimeAtack;
                    break;
                case "SP_TA":
                    parentNode = m_strAlienSoldier + m_strTailAtack;
                    break;
                case "SP_BA":
                    parentNode = m_strAlienSoldier + m_strBiteAtack;
                    break;
                case "SP_HBA":
                    parentNode = m_strAlienSoldier + m_strHoldBiteAtack;
                    break;
                case "SP_AA":
                    parentNode = m_strAlienSoldier + m_strAltAtack;
                    break;

                case "HL_NE":
                    parentNode = m_strHuman + m_strLightWeapon + m_strNoEffects;
                    break;
                case "HL_TE":
                    parentNode = m_strHuman + m_strLightWeapon + m_strHumanTrapEffect;
                    break;
                case "HL_BE":
                    parentNode = m_strHuman + m_strLightWeapon + m_strHumanBarricadeEffect; break;
                case "HL_ZE":
                    parentNode = m_strHuman + m_strLightWeapon + m_strHumanZoneEffect; break;
                case "HL_AE":
                    parentNode = m_strHuman + m_strLightWeapon + m_strAllEffects; break;
                default: throw new FormatException();
            }

        }
    }
}

