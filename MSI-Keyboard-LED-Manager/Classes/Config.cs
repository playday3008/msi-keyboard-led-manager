using System.IO;
using System.Xml;

namespace MSI_Keyboard_LED_Manager.Classes
{
    internal class Config
    {
        public static bool onScreenOff = false;
        public static bool enabled = true;
        public static int selectedProfile = -1;
        public static string fldr = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Config\\";

        public static void Load()
        {
            if (File.Exists(fldr + "Config.xml"))
            {
                XmlDocument settings = new XmlDocument();

                settings.Load(fldr + "Config.xml");

                XmlNode config_node = settings.SelectSingleNode("config");

                onScreenOff = !config_node.SelectSingleNode("on_screen_off").InnerText.Equals("false");
                enabled = !config_node.SelectSingleNode("enabled").InnerText.Equals("false");
                selectedProfile = int.Parse(config_node.SelectSingleNode("selected_profile").InnerText);
            }
        }

        public static void Save()
        {
            if (!Directory.Exists(fldr))
            {
                Directory.CreateDirectory(fldr);
            }
            else if (File.Exists(fldr + "Config.xml"))
            {
                File.Delete(fldr + "Config.xml");
            }

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            XmlWriter writer = XmlWriter.Create(fldr + "Config.xml", settings);

            writer.WriteStartDocument();

            writer.WriteStartElement("config");

            writer.WriteStartElement("on_screen_off");
            writer.WriteValue(onScreenOff);
            writer.WriteEndElement();

            writer.WriteStartElement("enabled");
            writer.WriteValue(enabled);
            writer.WriteEndElement();

            writer.WriteStartElement("selected_profile");
            writer.WriteValue(selectedProfile);
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();
        }
    }
}
