using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_6
{
    public class PC {
        public string Case_name { get; set; }
        public string Video_card_name { get; set; }
        public string Motherboard_name { get; set; }
        public string Processor_name { get; set; }
        public int Amount_of_RAM { get; set; }
        public int Number_of_ports { get; set; }
        public double Power_supply { get; set; }
        public bool Hard_drive_support { get; set; }
        public int GetNumberOfThreads() {
            return (Amount_of_RAM * 2);
        }
        public PC(){ }
        public PC(string case_name, string video_card_name, string motherboard_name, string processor_name,
            int amount_of_RAM, int number_of_ports, double power_supply, bool hard_drive_support) {
            Case_name = case_name;
            Video_card_name = video_card_name;
            Motherboard_name = motherboard_name;
            Processor_name = processor_name;
            Amount_of_RAM = amount_of_RAM;
            Number_of_ports = number_of_ports;
            Power_supply = power_supply;
            Hard_drive_support = hard_drive_support;
        }
    }
}