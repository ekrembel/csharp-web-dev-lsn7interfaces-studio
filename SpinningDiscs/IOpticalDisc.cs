using System;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        // spin
        void spin();
        // burn
        void burn(BaseDisc disc);
        // run
        void run();
        // stop
        void stop();
        // 
        
    }
}
