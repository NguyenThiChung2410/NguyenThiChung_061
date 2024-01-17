using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Vuong : ChuNhat 
    {
        private double canh;
        public Vuong() : base()
        {

        }
        public Vuong(double canh) : base()
        {
            this.canh = canh;
        }
        public double Canh
        {
            set { canh = value; }
            get { return canh; }  

        }
        public double Chuvi()
        {
            double chuvi = canh * 4;
            return chuvi;
        }
        public double DienTich()
        {
            double dienticH;
            return dienticH = canh * canh;
        }
        public override void Xuat()
        {
            Console.Write("Canh: {0}", canh);
            Console.Write("chu vi: {0}", Chuvi());
            Console.Write("dien tich:{0}", DienTich();
        }
    }
}
