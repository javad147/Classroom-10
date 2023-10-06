using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_10.Models
{
    internal class Car
    {
        public int speed;
        public string color;
        private string vin;
        //public string Name { get; set; }
        //public int Year { get; set }
        public string Vin
        {
            get
            {
                if (speed > 450)
                {
                    return vin;

                }
                return null;

            }

            set
            {
                vin = value;

            }

        }

    }
}
