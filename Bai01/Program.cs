using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();

            Console.Write("Nhap ho ten sinh vien: ")
            sv1.hoten = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            sv1.diemtoan = int.Parse(Console.ReadLine());
            Console.Write("Nhap  diem van: ");
            sv1.diemvan = int.Parse(Console.ReadLine());
            Console.Write("Nhap  diem ngoai ngu: ");
            sv1.diemngoaingu = int.Parse(Console.ReadLine());
            Console.Write("Nhap Khoi hoc: ");
            sv1.khoihoc = Console.ReadLine();
            sv1.InThongTin;

            SinhVien sv2 = new SinhVien("Chung", 8, 6, 9, "B");
            sv2.Inthongtin();
            Console.ReadLine();
            




        }
    }
}
