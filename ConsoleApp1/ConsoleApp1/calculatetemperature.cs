using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class calculatetemperature
    {

        public float psay { get; set; }
        public char ptemp { get; set; }

        public calculatetemperature(float csay, char ctemp)
        {
            psay = csay;
            ptemp = ctemp;
        }
        public float toCelsius()
        {
            float temp = -10000;
            switch (ptemp)
            {
                case 'c': temp = psay; break;
                case 'f': temp = (psay - 32) * 5 / 9; break;
                case 'k': temp = psay - 273; break;
            }
            return temp;
        }
        public float toKelvin()
        {
            float temp = -10000;
            switch (ptemp)
            {
                case 'k': temp = psay; break;
                case 'c': temp = psay + 273; break;
                case 'f': temp = (psay - 32) * 5 / 9 + 273; break;
            }
            return temp;
        }
        public float toFahrenheight()
        {
            float temp = -10000;
            switch (ptemp)
            {
                case 'f': temp = psay; break;
                case 'c': temp = psay * 9 / 5 + 32; break;
                case 'k': temp = (psay - 273) * 9 / 5 + 32; break;
            }
            return temp;
        }
    }
}