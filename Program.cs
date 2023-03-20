namespace LatihanClassDanObject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Rojali";
            taxi.OnDuty = false;
            taxi.NumPassanger = 5;

            taxi.TaxiInfo();
            taxi.PicUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}