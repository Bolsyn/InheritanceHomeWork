using System;

namespace InheritanceHomeWork
{
    public class Flash : Storage
    {
        public double SpeedUSB3 { get; set; }
        public double MemorySize { get; set; }
        public double WritedMemory { get; set; }

        public Flash(double SpeedUSB3, double Memory)
        {
            this.SpeedUSB3 = SpeedUSB3;
            this.MemorySize = Memory;
        }

        public override void CopyToDevice(double FileSize)
        {
            if (FileSize<MemorySize)
                WritedMemory = FileSize;
            else
            {
                Console.WriteLine("not enoght memory");
            }
        }

        public override double GetFreeMemory()
        {
            return MemorySize - WritedMemory;
        }

        public override void GetInfo()
        {
            Console.Write("Model: ");
            Console.WriteLine(Model);
            Console.Write("Name: ");
            Console.WriteLine(Name);
            Console.Write("MemorySize: ");
            Console.WriteLine(MemorySize);
        }

        public override double GetMemory()
        {
            return MemorySize;
        }
    }
}
