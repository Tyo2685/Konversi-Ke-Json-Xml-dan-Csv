using System;
using System.IO;
using System.Xml.Serialization;

    public class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using(StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                serializer.Serialize(writer,mhs);

                string xml = writer.ToString();

                Console.WriteLine("\nHasil konversi ke xml :\n");
                Console.WriteLine(xml);

            }
        }
    }
