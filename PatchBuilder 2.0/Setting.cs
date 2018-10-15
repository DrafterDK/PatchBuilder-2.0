using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace PatchBuilder_2._0
{
    public class Setting
    {
        public SettingFields Fields;

        public Setting()
        {
            Fields = new SettingFields();
        }

        //Запись настроек в файл
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(SettingFields));

            TextWriter writer = new StreamWriter(Fields.XMLFileName);
            ser.Serialize(writer, Fields);
            writer.Close();
        }
        //Чтение насроек из файла
        public void ReadXml()
        {
            if (File.Exists(Fields.XMLFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(SettingFields));
                TextReader reader = new StreamReader(Fields.XMLFileName);
                Fields = ser.Deserialize(reader) as SettingFields;
                reader.Close();
            }
            else
            {
                //можно написать вывод сообщения если файла не существует
            }
        }
    }
}
