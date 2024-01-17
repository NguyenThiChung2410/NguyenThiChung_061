using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class ChuNhat
    {
        private double rong;
        private double dai;
        public ChuNhat()
        {

        }
        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double Dai
        {
            set { dai = value; }
            get { return dai; }
        }
        public double Rong
        {
            set { rong = value; }
            get { return rong; }
        }
        public virtual double Chuvi(double dai, double rong)
        {
            double Chuvi;
            return Chuvi = (dai + rong) * 2;
            
        }
        public virtual double DienTich(double dai,double rong)
        {
            double DienTich;
            return DienTich = (dai * rong);
        }
        public void Xuat()
        {
            Console.Write("Chieu dai:{0}", dai);
            Console.Write("Chieu rong:{0}", rong);
            Console.Write("Chu vi: {0}", Chuvi());
            Console.Write("Dien Tich:{0}", DienTich();
        }
    }
}
