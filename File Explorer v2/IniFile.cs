using System.IO;
using System.Xml.Serialization;

namespace File_Explorer_v2
{
    public class IniFile
    {
        public static string Config = "Config.xml";
        public string LeftPathIni;
        public string RightPathIni;

        public static IniFile LoadIniFile()
        {
            IniFile ini;
            var filename = Config;
            if (File.Exists(filename))
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    var xser = new XmlSerializer(typeof(IniFile));
                    ini = (IniFile)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else
                ini = new IniFile();
            return ini;
        }
        public void SaveIniFile()
        {
            var filename = Config;
            if (File.Exists(filename))
                File.Delete(filename);
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                var xser = new XmlSerializer(typeof(IniFile));
                xser.Serialize(fs, this);
                fs.Close();
            }
        }
    }
}
