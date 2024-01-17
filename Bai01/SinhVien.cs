using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class SinhVien
    {
        private string Hoten;
        private int DiemToan;
        private int DiemVan;
        private int DiemNgoaiNgu;
        private string KhoiHoc;
        public SinhVien() { }
        public SinhVien(string hoten,int diemtoan,int diemvan,int diemngoaingu,string khoihoc)
        {
            this.hoten = Hoten;
            this.diemtoan = DiemToan;
            this.diemvan = DiemVan;
            this.diemngoaingu = DiemNgoaiNgu;
            this.khoihoc = KhoiHoc;


        }
        public string hoten
        {
            set { Hoten = value; }
            get { return Hoten; }
        }
        public int diemtoan
        {
            set { DiemToan = value; }
            get { return DiemToan; }

        }
        public int diemvan
        {
            set { DiemVan = value; }
            get { return DiemVan; }
        }
        public int diemngoaingu
        {
            set { DiemNgoaiNgu = value; }
            get { return DiemNgoaiNgu; }
        }
        public string khoihoc
        {
            set { KhoiHoc = value; }
            get { return KhoiHoc; }
        }
        public double TinhTrungBinh(string KhoiHoc, int DiemToan, int DiemVan, int DiemNgoaiNgu)
        {
            if (KhoiHoc == "A")
            {
                return DiemToan * 2;
            }
            else if (KhoiHoc == "D")
            {
                return DiemNgoaiNgu * 2;
            }
            else if (KhoiHoc == "C")
            {
                return DiemVan * 2;
            }
            double diemtb = (DiemToan + DiemVan + DiemNgoaiNgu) / 3;
            return diemtb;
        }
        public void XepLoai(double diemtb)
        {
            if (diemtb>=5)
            {
                Console.Write("Duoc len lop");
            }
            else
            {
                Console.Write("Luu ban");
            }
        }
        public string InThongTin()
        {
            Console.Write("ho ten:{0}", hoten);
            Console.Write("Diem trung binh:{0}", TinhTrungBinh());
            Console.Write("xep loai:{0}", XepLoai());
            
        }


    }
}
