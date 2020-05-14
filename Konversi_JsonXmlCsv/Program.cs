using System;

namespace Konversi_JsonXmlCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm     = "19.11.2685";
            mhs.nama    = "Deny Agung Prasetyo";
            mhs.email   = "deny.prasetyo@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data : ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("1. Csv\n");

            Console.Write("Nomor Format Data [1-3] : ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; //deklarasi objek konversi

            if(nomorFormatData == 1)
                convert = new ConvertToJson();
            else if(nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            //konversi objek mhs berdasarkan format yang dipilih 
            convert.Convert(mhs);

            Console.ReadKey();

        }
    }
}
