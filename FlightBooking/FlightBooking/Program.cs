namespace FlightBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Passenger passenger1 = new Passenger("Pista", 12);
            Passenger passenger2 = new Passenger("Jani", 15);
            passenger2.AddBag();
            passenger2.AddBag();
            passenger2.AddBag();
            Console.WriteLine(passenger2.BagCount);
            passenger1.IsChild();

        }
    }
}
