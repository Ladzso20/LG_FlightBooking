namespace FlightBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Flight flight1 = new Flight("valmi", "valami", 3, 23103);
            Flight flight2 = new Flight("valmi", "valami", 1, 231);

            flight2.BookSeat();
            flight2.Describe();
            flight2.BookSeat();
            flight2.Describe();
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
