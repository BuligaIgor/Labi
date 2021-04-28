using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    public class PC
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
}