using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes
{
    internal class Car: CarDetail
    {
        public string model;
        public string color;        
        public double engine;
        public int price;
        private int year;
        private string brand;

        public void message()
        {
            for (int i = 0; i < 2; i++)
            {
                MessageBox.Show("Welcome!");
            }            
        }

        public int YEAR
        {
            get { return year; }
            set { year = Math.Abs(value); }
        }

        public string BRAND
        {
            get { return brand; }
            set { brand = value.ToUpper(); }
        }
    }
}
