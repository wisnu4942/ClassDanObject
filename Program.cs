namespace LatihanClassDanObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nama = "Wisnu";
            saya.Nim = "22.11.4942";
            saya.Ipk = 3.90f;

            kamu.Nama = "Rosa";
            kamu.Nim = "22.11.2494";
            kamu.Ipk = 2.90f;

            saya.Data();
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Data();
            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
            Console.WriteLine("Hello, World!");
        }
    }
}