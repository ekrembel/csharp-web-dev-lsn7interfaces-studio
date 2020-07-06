using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            List<string> filesCd = new List<string> { "mp3", "pdf", "doc", "img" };
            CD cd = new CD(4, 2, filesCd, true, false);

            List<string> filesDvd = new List<string> { "mp4" };
            DVD dvd = new DVD(32, 12, filesDvd, false, false);

            // TODO: Call each CD and DVD method to verify that they work as expected.
            cd.burn(cd);
            cd.run();
            Console.WriteLine(cd.IsRunning);
            cd.spin();
            cd.stop();
            Console.WriteLine(cd.IsRunning);

            try
            {
                dvd.burn(dvd);
            }
            catch(Exception)
            {
                Console.WriteLine("This DVD isn't burnable.");
            }

            dvd.run();
            Console.WriteLine(dvd.IsRunning);
            dvd.spin();
            dvd.stop();
            Console.WriteLine(dvd.IsRunning);
        }
    }
}
