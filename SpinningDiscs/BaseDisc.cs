using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        // Total storage size
        public double StorageSize { get; set; }
        // Total storage used
        public double StorageUsed { get; set; }
        // Data type
        public List<string> FileType { get; set; } = new List<string>();
        // Burnable or not?
        public bool IsBurnable { get; set; }
        // Running or not
        public bool IsRunning { get; set; }
        
        public BaseDisc(double storageSize, double storageUsed, List<string> fileType, bool isBurnable, bool isRunning)
        {
            StorageSize = storageSize;
            StorageUsed = storageUsed;
            FileType = fileType;
            IsBurnable = isBurnable;
            IsRunning = isRunning;
        }
    }
}
