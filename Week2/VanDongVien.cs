/*  
    MSSV: 3121410361
    Họ và tên: Trần Thuỵ Ái Nhân
*/

using System;
namespace Week2
{
    public class VanDongVien
    {
        // private fields
        string maSo;
        string hoTen;
        int soAo;
        DateTime batDau;
        DateTime ketThuc;
        static TimeSpan thanhTichChuan = new TimeSpan(1, 30, 0);

        // public constructor
        public VanDongVien()
        {
            MaSo = "";
            HoTen = "";
            SoAo = 0;
            BatDau = DateTime.Today;
            KetThuc = DateTime.Today;
        }
        public VanDongVien(string maSo, string hoTen, int soAo)
        {
            MaSo = maSo;
            HoTen = hoTen;
            SoAo = soAo;
            BatDau = DateTime.Today;
            KetThuc = DateTime.Today;
        }
        public VanDongVien(string maSo, string hoTen, int soAo, DateTime batDau)
        {
            MaSo = maSo;
            HoTen = hoTen;
            SoAo = soAo;
            BatDau = batDau;
            KetThuc = batDau;
        }
        public VanDongVien(string maSo, string hoTen, int soAo, DateTime batDau, DateTime ketThuc)
        {
            MaSo = maSo;
            HoTen = hoTen;
            SoAo = soAo;
            BatDau = batDau;
            KetThuc = ketThuc;
        }

        // public properties
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoAo { get => soAo; set => soAo = value; }
        public DateTime BatDau { get => batDau; set => batDau = value; }
        public DateTime KetThuc { get => ketThuc; set => ketThuc = value; }
        public static TimeSpan ThanhTichChuan { get => thanhTichChuan; set => thanhTichChuan = value; }

        // public methods
        bool KiemTraBatDau(string str)
        {
            DateTime batDau = new DateTime();
            if (DateTime.TryParseExact(str, "H:m:s", null, 0, out batDau))
            {
                BatDau = batDau;
                return true;
            } 
            else return false;
        }
        bool KiemTraKetThuc(string str)
        {
            DateTime ketThuc = new DateTime();
            DateTime.TryParseExact(str, "H:m:s", null, 0, out ketThuc);
            if (ketThuc > BatDau)
            {
                KetThuc = ketThuc;
                return true;
            }
            else return false;
        }
        public string ThanhTich()
        {
            TimeSpan thanhTich = KetThuc.Subtract(BatDau);
            return thanhTich < ThanhTichChuan ? thanhTich.ToString(@"hh\:mm\:ss") : "Khong dat";
        }
        public void Nhap()
        {
            Console.Write("Nhap ma so van dong vien -> ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap ho va ten van dong vien -> ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so ao van dong vien -> ");
            int.TryParse(Console.ReadLine(), out soAo);
            Console.Write("Nhap thoi gian bat dau HH:mm:ss -> ");
            while (!KiemTraBatDau(Console.ReadLine()))
                Console.Write(">> Sai dinh dang! Nhap lai thoi gian bat dau -> ");
            Console.Write("Nhap thoi gian ket thuc HH:mm:ss -> ");
            while (!KiemTraKetThuc(Console.ReadLine()))
                Console.Write(">> Sai dinh dang! Nhap lai thoi gian ket thuc -> ");
        }
        public void Xuat()
        {
            Console.WriteLine("Ma so: {0}", MaSo);
            Console.WriteLine("Ho va ten: {0}", HoTen);
            Console.WriteLine("So ao: {0}", SoAo);
            Console.WriteLine("Thoi gian bat dau: {0:HH:mm:ss}", BatDau);
            Console.WriteLine("Thoi gian ket thuc: {0:HH:mm:ss}", KetThuc);
            Console.WriteLine("Thanh tich: {0}", ThanhTich());
        }

        // main
        public static void Main(string[] args)
        {
            VanDongVien e = new VanDongVien();
            e.Nhap();
            e.Xuat();
        }
    }
}