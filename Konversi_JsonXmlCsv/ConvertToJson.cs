using System;
using Newtonsoft.Json;

    public class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            //konversi objek mahasiswa ke json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("\nHasil Konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
