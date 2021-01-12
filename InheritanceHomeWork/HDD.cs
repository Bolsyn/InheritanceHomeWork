using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceHomeWork
{
    public class HDD : Storage
    {
        public double SpeedUSB2 { get; set; }
        public int CountSection { get; set; }
        public double VolumeSection { get; set; }
        public double WritedMemory { get; set; }

        public HDD(double SpeedUSB2, int CountSection, double VolumeSection)
        {
            this.SpeedUSB2 = SpeedUSB2;
            this.CountSection = CountSection;
            this.VolumeSection = VolumeSection;
        }

        public override void CopyToDevice(double FileSize)
        {
            if (FileSize < CountSection * VolumeSection)
                WritedMemory = FileSize;
            else
            {
                Console.WriteLine("not enoght memory");
            }

        }

        public override double GetFreeMemory()
        {
            if (WritedMemory > 0)
                return (CountSection * VolumeSection) - WritedMemory;
            else
                return CountSection * VolumeSection;
        }

        public override void GetInfo()
        {
            Console.Write("Model: ");
            Console.WriteLine(Model);
            Console.Write("Name: ");
            Console.WriteLine(Name);
            Console.Write("Volume: ");
            Console.WriteLine(CountSection * VolumeSection);
        }

        public override double GetMemory()
        {
            return CountSection * VolumeSection;
        }
    }
}
