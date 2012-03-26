using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Settings
{
    /// <summary>
    /// Handles XML Functionality
    /// </summary>
    public class XmlSettings : Settings
    {
        private XmlDocument xmlConfig = new XmlDocument();
        private string xmlConfigFile;
        public const int MENU_TEXT_LENGTH = 30;

        public const string UNIX_NL = "\n";
        public const string WINDOWS_NL = "\r\n";

        public XmlSettings()
        {
            xmlConfigFile = appDataDirectory + "/config.xml";
        }

        /// <summary>
        /// handling of the autostart-shortcut when no TextEimer shortcut is found
        /// in autostart directory
        /// </summary>
        private void createAutoStartShortcut()
        {
            if (!File.Exists(autostartFilePath))
            {
                DialogResult message = MessageBox.Show(
                    "Es wird eine Verknüpfung im Autostart-Verzeichnis " +
                    "angelegt, ob du willst oder nicht.",
                    "Autostart",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (message == DialogResult.Yes)
                {
                    addShortcutToAutostart();
                }
                else
                {
                    MessageBox.Show("Dann eben nicht.",
                        "Du Eimer!!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// creates new Config XML File with standard settings
        /// </summary>
        private void newXmlConfig()
        {
            XmlDeclaration xmlDeclaration = xmlConfig.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlConfig.InsertBefore(xmlDeclaration, xmlConfig.DocumentElement);
            
            XmlElement rootNode = xmlConfig.CreateElement("clipboard");
            xmlConfig.AppendChild(rootNode);

            foreach (KeyValuePair<string, string> setting in settings)
            {
                addXmlSetting(setting.Key, setting.Value);
            }

            xmlConfig.Save(xmlConfigFile);
        }

        /// <summary>
        /// loads the xml option values into the settings
        /// </summary>
        private void loadXmlConfig()
        {
            if (!File.Exists(xmlConfigFile))
            {
                newXmlConfig();
            }
            
            xmlConfig.Load(xmlConfigFile);
            XmlNode rootNode = xmlConfig.FirstChild.NextSibling;
            XmlNodeList rootChildNodes = rootNode.ChildNodes;
            foreach (XmlNode childNode in rootChildNodes)
            {
                this.addOptionToDictionary(childNode.Name, childNode.InnerText);
            }
        }

        /// <summary>
        /// checks if the key in the settings exists and replaces or adds the setting value
        /// </summary>
        /// <param name="name">the name/key of the setting</param>
        /// <param name="value">the value of the setting</param>
        private void addOptionToDictionary(string name, string value)
        {
            if (!settings.ContainsKey(name))
            {
                settings.Add(name, value);
            }
            else
            {
                settings[name] = value;
            }
        }

        /// <summary>
        /// adds a new node to the xml
        /// </summary>
        /// <param name="name">name of the xml node</param>
        /// <param name="value">the value the xml node contains</param>
        private void addXmlSetting(string name, string value)
        {
            XmlNode rootNode = xmlConfig.FirstChild.NextSibling;
            bool nodeExists = bool.Parse(rootNode.SelectSingleNode(name).ToString());
            if (nodeExists)
            {
                MessageBox.Show("yay");
            }
            XmlElement newNode = xmlConfig.CreateElement(name);
            rootNode.AppendChild(newNode);
            XmlText newNodeText = xmlConfig.CreateTextNode(value);
            newNode.AppendChild(newNodeText);
        }

        public void writeXmlSettings()
        {
            addXmlSetting("itemCount", "11");
            xmlConfig.Save(this.xmlConfigFile);
        }

        /// <summary>
        /// Checks existence of Files and directories and creates them if they don't exists
        /// </summary>
        public void startUpFileChecks(Control progWindow)
        {
            try
            {
                this.createAppDataDirectory();
                this.loadXmlConfig();

                this.createAutoStartShortcut();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "TextEimer ist im Eimer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
