using System;

namespace laba_2 
{
    class PC
    {
        public string Case_name, Video_card_name, Motherboard_name, Processor_name;
        public int Amount_of_RAM, Number_of_ports;
        public double Power_supply;
        public bool Hard_drive_support;

        public int GetNumberOfThreads()
        {
            return (Amount_of_RAM * 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Назва корпусу: ");
            string sCase_name = Console.ReadLine();

            Console.Write("Кількість оперативної пам'яті: ");
            string sAmount_of_RAM = Console.ReadLine();

            Console.Write("Назва процесора: ");
            string sProcessor_name = Console.ReadLine();

            Console.Write("Потужність блока живлення: ");
            string sPower_supply = Console.ReadLine();

            Console.Write("Кількість портів: ");
            string sNumber_of_ports = Console.ReadLine();

            Console.Write("Чи є підтримка жосткого диска? (y-так, n-нi): ");
            ConsoleKeyInfo keyHard_drive_support = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Назва відеокарти: ");
            string sVideo_card_name = Console.ReadLine();

            Console.Write("Материнська плата: ");
            string sMotherboard_name = Console.ReadLine();


            PC cmp = new PC();

            cmp.Case_name = sCase_name;
            cmp.Amount_of_RAM = int.Parse(sAmount_of_RAM);
            cmp.Motherboard_name = sMotherboard_name;
            cmp.Video_card_name = sVideo_card_name;
            cmp.Processor_name = sProcessor_name;
            cmp.Power_supply = double.Parse(sPower_supply);
            cmp.Number_of_ports = int.Parse(sNumber_of_ports);
            cmp.Hard_drive_support = keyHard_drive_support.Key == ConsoleKey.Y ? true : false;
            int NumberOfThreads = cmp.GetNumberOfThreads();

            Console.WriteLine(
            "\n__________________________" +
            "\n     Дані про об’єкт" +
            "\n__________________________" +
            "\nНазва Корпусу: " + cmp.Case_name +
            "\nКількість оперативної памяті: " + cmp.Amount_of_RAM.ToString() +
            "\nНазва відеокарти: " + cmp.Video_card_name +
            "\nНазва процесора: " + cmp.Processor_name +
            "\nПотужність блока живлення: " + cmp.Power_supply.ToString ("0.00")+
            "\nКількість портів: " + cmp.Number_of_ports.ToString()+
            "\nМатеринська плата: " + cmp.Motherboard_name +

            (cmp.Hard_drive_support ? "\nЄ підтримка Hard-drive-support" :
                             "\nНемає підтримки Hard-drive-support"));

            Console.ReadKey();
        }
    }
}