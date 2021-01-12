using System;

namespace InheritanceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double allFileSize = 585;
            double file = 780;

            Storage hard = new HDD(147,10,100);
            Storage flashCard = new Flash(25, 32);
            Storage disc = new DVD(1.3, "Double", 9.7);

            double allSizeOfDevices = hard.GetMemory() + flashCard.GetMemory() + disc.GetMemory();
            double CountOfDevicesToCopy = allFileSize % hard.GetFreeMemory() + (allFileSize-(allFileSize % hard.GetFreeMemory()))% flashCard.GetFreeMemory() + (allFileSize -((allFileSize - (allFileSize % hard.GetFreeMemory())) % flashCard.GetFreeMemory()))%disc.GetFreeMemory();

        }
    }
}
