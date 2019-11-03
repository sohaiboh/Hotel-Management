using System;

namespace hotel_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello World!");
            Guest sohaib = new Guest("sohaib", "0506496675", "arsl94@hotmail.com");
            Guest mariam = new Guest("mariam", "0506496675", "arsl94@hotmail.com");
            sohaib.Display();
            mariam.Display();
            Hotel sharetoon = new Hotel("sharetoon","coppistr. 20");
            sharetoon.AddRoom(sharetoon, RoomType.DOUBLE);
            sharetoon.AddRoom(sharetoon, RoomType.SINGLE);
            Console.WriteLine(sharetoon.roomsList.Count);

        }
    }
}
