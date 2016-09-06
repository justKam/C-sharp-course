using System;

namespace km_to_m_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKm;
            int numOfM;
            numOfKm = Convert.ToInt32(Console.ReadLine());
            numOfM = numOfKm * 1000;
            Console.WriteLine("Here " + numOfM + "m");
        }
    }
}
