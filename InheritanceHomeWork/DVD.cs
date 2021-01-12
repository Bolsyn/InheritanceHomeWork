using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceHomeWork
{
    public class DVD : Storage
    {
        public double SpeedWrite { get; set; }
        public string Type { get; set; }
        public double Memory { get; set; }
        public double WritedMemory { get; set; }

        public DVD(double SpeedWrite, string Type, double Memory)
        {
            this.SpeedWrite = SpeedWrite;
            this.Type = Type;
            this.Memory = Memory;
        }

        public override void CopyToDevice(double FileSize)
        {
            if (FileSize < Memory)
                WritedMemory = FileSize;
            else
            {
                Console.WriteLine("not enoght memory");
            }
        }

        public override double GetFreeMemory()
        {
            if (WritedMemory>0)
                return Memory - WritedMemory;
            else
                return Memory;
        }

        public override void GetInfo()
        {
            Console.Write("Model: ");
            Console.WriteLine(Model);
            Console.Write("Name: ");
            Console.WriteLine(Name);
            Console.Write("Type: ");
            Console.WriteLine(Type);
        }

        public override double GetMemory()
        {
            return Memory;
        }
    }
}
