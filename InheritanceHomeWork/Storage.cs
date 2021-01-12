using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceHomeWork
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public abstract double GetMemory();
        public abstract void CopyToDevice(double FileSize);
        public abstract double GetFreeMemory();
        public abstract void GetInfo();
    }
}
