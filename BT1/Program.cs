using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class SinhVien
    {
        private string hoTen;
        private double diemToan;
        private double diemVan;
        private double diemNgoaiNgu;
        private double khoiHoc;


        public SinhVien() { }
        public string HoTen
        {
            set { hoTen = value; }
            get { return hoTen; }
        }
        public double DiemToan
        {
            set { diemToan = value; }
            get { return diemToan; }

        }
        public double DiemVan
        {
            set { diemVan = value; }
            get { return diemVan; }
        }
        public double DiemNgoaiNgu
        {
            set { diemNgoaiNgu = value; }
            get { return diemNgoaiNgu; }
        }
        public double KhoiHoc
        {
            set { khoiHoc = value; }
            get { return khoiHoc; }
        }
       
        public double TinhDiemTrungBinh()
        {
            double heSo = 1;
            switch (KhoiHoc)
            {
                case 'A':
                    heSo = 2;
                    break;
                case 'B':
                    heSo = 2;
                    break;
                case 'C':
                    heSo = 2;
                    break;
                    
                  
            }
            return (diemToan + diemVan + diemNgoaiNgu) / 3;

        }
        public string XepLoai()
        {
            if (TinhDiemTrungBinh() > 5)
            {
                return "Duoc len Lop";
            }
            else
                return " khong duoc len lop ";
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten: {0}", hoTen);
            Console.WriteLine("Diem Trung Binh: {0}", TinhDiemTrungBinh());
            Console.WriteLine("Xep Loai: {0}", XepLoai());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* xuat thong tin *************");
       
            SinhVien sv1 = new SinhVien();
            sv1.HoTen = "Nguyễn Văn A";
            sv1.DiemToan = 8;
            sv1.DiemVan = 9;
            sv1.DiemNgoaiNgu = 7;
            sv1.InThongTin();
            Console.ReadLine();
        }
    }
}
