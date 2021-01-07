using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;

namespace MSI_Keyboard_LED_Manager.Classes
{
    public class Profile
    {
        public string name;
        public Keyboard.Mode mode;
        public ColorLevel[] color1;
        public ColorLevel[] color2;
        public int delay;

        public Profile()
        {
            name = "";
            delay = 20;
            mode = Keyboard.Mode.NORMAL;
            color1 = new ColorLevel[3];
            color2 = new ColorLevel[3];

            color1[0] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);
            color1[1] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);
            color1[2] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);

            color2[0] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);
            color2[1] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);
            color2[2] = new ColorLevel(Color.Black, Keyboard.Color.OFF, Keyboard.Level.HIGH);
        }

        public static List<Profile> Load()
        {
            List<Profile> list = new List<Profile>();

            if (File.Exists(Config.fldr + "Profiles.xml"))
            {
                XmlDocument settings = new XmlDocument();

                settings.Load(Config.fldr + "Profiles.xml");

                XmlNode profiles_node = settings.SelectSingleNode("profiles");
                XmlNodeList profiles = profiles_node.ChildNodes;

                foreach (XmlNode nodelist in profiles_node)
                {
                    Profile p = new Profile
                    {
                        name = nodelist.SelectSingleNode("name").InnerText,
                        mode = (Keyboard.Mode)int.Parse(nodelist.SelectSingleNode("mode").InnerText),
                        delay = int.Parse(nodelist.SelectSingleNode("delay").InnerText)
                    };

                    p.color1[0] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color1_left").InnerText);
                    p.color1[1] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color1_center").InnerText);
                    p.color1[2] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color1_right").InnerText);

                    p.color2[0] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color2_left").InnerText);
                    p.color2[1] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color2_center").InnerText);
                    p.color2[2] = ColorLevel.FromRGB(nodelist.SelectSingleNode("color2_right").InnerText);

                    list.Add(p);
                }
            }

            return list;
        }

        public static void Save(List<Profile> profiles)
        {
            if (!Directory.Exists(Config.fldr))
            {
                Directory.CreateDirectory(Config.fldr);
            }
            else if (File.Exists(Config.fldr + "Profiles.xml"))
            {
                File.Delete(Config.fldr + "Profiles.xml");
            }

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            XmlWriter writer = XmlWriter.Create(Config.fldr + "Profiles.xml", settings);

            writer.WriteStartDocument();

            writer.WriteStartElement("profiles");

            foreach (Profile p in profiles)
            {
                writer.WriteStartElement("profile");

                // Info
                writer.WriteStartElement("name");
                writer.WriteValue(p.name);
                writer.WriteEndElement();

                writer.WriteStartElement("mode");
                writer.WriteValue((int)p.mode);
                writer.WriteEndElement();

                writer.WriteStartElement("delay");
                writer.WriteValue(p.delay);
                writer.WriteEndElement();

                // Colors
                writer.WriteStartElement("color1_left");
                writer.WriteValue(p.color1[0].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("color1_center");
                writer.WriteValue(p.color1[1].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("color1_right");
                writer.WriteValue(p.color1[2].ToString());
                writer.WriteEndElement();

                // Colors
                writer.WriteStartElement("color2_left");
                writer.WriteValue(p.color2[0].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("color2_center");
                writer.WriteValue(p.color2[1].ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("color2_right");
                writer.WriteValue(p.color2[2].ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();
        }

        public class ColorLevel
        {
            public Color rgb;
            public Keyboard.Color color;
            public Keyboard.Level level;

            public ColorLevel(Color c_rgb, Keyboard.Color c, Keyboard.Level l)
            {
                rgb = c_rgb;
                color = c;
                level = l;
            }

            public override string ToString()
            {
                return "#" + rgb.R.ToString("X2") + rgb.G.ToString("X2") + rgb.B.ToString("X2");
            }

            public static ColorLevel FromRGB(string rgb)
            {
                Color c = ColorTranslator.FromHtml(rgb);

                return FromRGB(c);
            }

            public static ColorLevel FromRGB(Color rgb)
            {
                foreach (ColorLevel cl in color_level)
                {
                    if (cl.rgb.R == rgb.R && cl.rgb.G == rgb.G && cl.rgb.B == rgb.B)
                    {
                        return cl;
                    }
                }

                throw new Exception("Color " + rgb + " not found!");
            }
        }

        public static List<ColorLevel> color_level;

        static Profile()
        {
            color_level = new List<ColorLevel>
            {
                new ColorLevel(Color.FromArgb(unchecked((int)0xffe60118)), Keyboard.Color.RED, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffe6401d)), Keyboard.Color.RED, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffe55435)), Keyboard.Color.RED, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffee845c)), Keyboard.Color.RED, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xffef8d00)), Keyboard.Color.ORANGE, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfff2a420)), Keyboard.Color.ORANGE, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfff3a93e)), Keyboard.Color.ORANGE, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfff5be6e)), Keyboard.Color.ORANGE, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xfff8e60a)), Keyboard.Color.YELLOW, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfffef542)), Keyboard.Color.YELLOW, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfff9ef7c)), Keyboard.Color.YELLOW, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xfffdf6b0)), Keyboard.Color.YELLOW, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xff9be11d)), Keyboard.Color.GREEN, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffa4da3a)), Keyboard.Color.GREEN, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffa2c956)), Keyboard.Color.GREEN, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffbad77d)), Keyboard.Color.GREEN, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xff35baf5)), Keyboard.Color.SKY, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff38b2eb)), Keyboard.Color.SKY, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff74c9f2)), Keyboard.Color.SKY, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xffa2d9f8)), Keyboard.Color.SKY, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xff0355a1)), Keyboard.Color.BLUE, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff1c5fac)), Keyboard.Color.BLUE, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff316cb0)), Keyboard.Color.BLUE, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff718fc5)), Keyboard.Color.BLUE, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xff5d197e)), Keyboard.Color.PURPLE, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff743293)), Keyboard.Color.PURPLE, Keyboard.Level.MED),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff804796)), Keyboard.Color.PURPLE, Keyboard.Level.LOW),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff9c70ad)), Keyboard.Color.PURPLE, Keyboard.Level.LIGHT),

                new ColorLevel(Color.FromArgb(unchecked((int)0xFFFFFFFF)), Keyboard.Color.WHITE, Keyboard.Level.HIGH),
                new ColorLevel(Color.FromArgb(unchecked((int)0xff000000)), Keyboard.Color.OFF, Keyboard.Level.HIGH)
            };

            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xFFFFFFFF)), Keyboard.Color.WHITE, Keyboard.Level.MED));
            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xFFFFFFFF)), Keyboard.Color.WHITE, Keyboard.Level.LOW));
            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xFFFFFFFF)), Keyboard.Color.WHITE, Keyboard.Level.LIGHT));

            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xff000000)), Keyboard.Color.OFF, Keyboard.Level.MED));
            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xff000000)), Keyboard.Color.OFF, Keyboard.Level.LOW));
            //color_level.Add(new ColorLevel(Color.FromArgb(unchecked((int)0xff000000)), Keyboard.Color.OFF, Keyboard.Level.LIGHT));
        }
    }
}
