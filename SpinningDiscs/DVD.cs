using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        public void burn(BaseDisc disc)
        {
            if (disc.IsBurnable == false)
            {
                throw new Exception("This DVD cannot be burned");
            }            
            Console.WriteLine("DVD is being burned");
        }

        public void run()
        {
            IsRunning = true;
            Console.WriteLine("Running!");
        }

        public void spin()
        {
            Console.WriteLine("DVD spins at a rate of 570 - 1600 rpm");
        }

        public void stop()
        {
            IsRunning = false;
            Console.WriteLine("Stopped!");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(double storageSize, double storageUsed, List<string> fileType, bool isBurnable, bool isRunning) : base(storageSize, storageUsed, fileType, isBurnable, isRunning)
        {

        }
    }
}
