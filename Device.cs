using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17_03_07_2024
{
    internal class Device
    {
        public string DevName {  get; set; }
        public string DevManuf { get; set; }
        public double Price { get; set; }
        public Device() { }
        public Device (string devName,string devManuf, double price)
        {
            DevName = devName;
            DevManuf = devManuf;
            Price = price;

        }
        public override string ToString()
        {
            return $"Device name: {DevName}\nDevice manufacturer: {DevManuf}\nDevice price: {Price}";
        }
    }
}
