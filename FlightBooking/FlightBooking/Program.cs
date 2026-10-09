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
        }
    }
}
