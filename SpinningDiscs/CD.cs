using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        public void burn(BaseDisc disc)
        {
            if (disc.IsBurnable == false)
            {
                throw new Exception("This DVD cannot be burned");
            }
            Console.WriteLine("CD is being burned");
        }

        public void run()
        {
            IsRunning = true;
            Console.WriteLine("Running!");
        }

        public void spin()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm");
        }

        public void stop()
        {
            IsRunning = false;
            Console.WriteLine("Stopped!");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public CD(double storageSize, double storageUsed, List<string> fileType, bool isBurnable, bool isRunning) : base(storageSize, storageUsed, fileType, isBurnable, isRunning)
        {

        }
    }
}
