using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
        public float Ipk { get; set; }
        public void Data()
        {
            Console.WriteLine("NAMA: {0}", Nama);
            Console.WriteLine("NIM: {0}", Nim);
            Console.WriteLine("IPK: {0}", Ipk);
        }
        public void Registrasi()
        {
            Console.WriteLine("\nSudah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("Sedang mengisi Krs\n");
        }
    }
}
