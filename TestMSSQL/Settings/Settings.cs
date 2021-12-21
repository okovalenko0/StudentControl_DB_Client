using System;
using System.IO;
using System.Xml.Serialization;

namespace TestMSSQL
{
    public class SettingsFields
    {
        public string XMLFileName = Environment.CurrentDirectory + "\\settings.xml";
        public string Login = @"Student";
        public string Password = @"123";
        public bool SaveSettings = false;
    }

    class Settings
    {
        public SettingsFields Fields;

        public Settings()
        {
            Fields = new SettingsFields();
        }
        //Запись настроек в файл
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));

            TextWriter writer = new StreamWriter(Fields.XMLFileName);
            ser.Serialize(writer, Fields);
            writer.Close();
        }
        //Чтение насроек из файла
        public void ReadXml()
        {
            if (File.Exists(Fields.XMLFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));
                TextReader reader = new StreamReader(Fields.XMLFileName);
                Fields = ser.Deserialize(reader) as SettingsFields;
                reader.Close();
            }
        }
    }
}