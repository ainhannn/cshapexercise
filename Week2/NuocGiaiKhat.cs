/*  
    MSSV: 3121410361
    Họ và tên: Trần Thuỵ Ái Nhân
*/

using System;
namespace Week2
{
    public class NuocGiaiKhat
    {
        // field
        private string dvt;
        private static float vat = 0.1f;

        // constructors
        public NuocGiaiKhat()
        {
            TenHang = "Nước Giải Khát";
            DonViTinh = "Kết";
            SoLuong = 0;
            DonGia = 0f;
        }
        public NuocGiaiKhat(string tenHang, string dvt, int soLuong, float donGia)
        {
            TenHang = tenHang;
            DonViTinh = dvt;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        // properties
        public string TenHang { get; set; }
        public string DonViTinh
        {
            get => dvt;
            set => dvt = ("KếtThùngChaiLon".Contains(value)) ? value : "Kết";
        }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public static float VAT
        {
            get => vat;
            set => vat = value;
        }

        // methods
        public double ThanhTien()
        {
            if ("KếtThùng".Contains(dvt))
                return SoLuong * DonGia * (1+NuocGiaiKhat.vat);
            else if ("Chai".Contains(dvt))
                return SoLuong * DonGia/20 * (1+NuocGiaiKhat.vat);
            else
                return SoLuong * DonGia/24 * (1+NuocGiaiKhat.vat);
        }
        public void Nhap() {
            Console.Write("Tên hàng: ");
            TenHang = Console.ReadLine();
            
            Console.Write("Đơn vị tính: ");
            DonViTinh = Console.ReadLine();
            
            Console.Write("Số lượng: ");
            int soLuong = 0;
            while (!(soLuong > 0))
                int.TryParse(Console.ReadLine(), out soLuong);
            SoLuong = soLuong;

            Console.Write("Đơn giá: ");
            float donGia = 0f;
            while (!(donGia > 0))
                float.TryParse(Console.ReadLine(), out donGia);
            DonGia = donGia;
        }
        public void Xuat() {
            Console.WriteLine(ToString());
        }
        public override string ToString() => "Tên hàng: " + TenHang + "\nĐơn vị tính: " + dvt + "\nSố lượng: " + SoLuong +
                                            "\nĐơn giá: " + DonGia + "\nThuế VAT: " + NuocGiaiKhat.VAT + "\nThành tiền: " + Math.Round(ThanhTien(),3);
    
        // main
        public static void Main(string[] args)
        {
            NuocGiaiKhat ngk = new NuocGiaiKhat();
            ngk.Nhap();
            Console.WriteLine(">> Trước khi thay đổi VAT");
            ngk.Xuat();
            
            NuocGiaiKhat.VAT = 0.2f;
            Console.WriteLine(">> Sau khi thay đổi VAT");
            ngk.Xuat();       
        }
    }
}