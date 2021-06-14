using System;

namespace testing_stuff
{
    class Program
    {
        static void Main(string[] args)
        {           
            var locations = DB.ReadSomething();
            foreach(var location in locations) {
                Console.WriteLine(location);
            }
        }
    }
}
