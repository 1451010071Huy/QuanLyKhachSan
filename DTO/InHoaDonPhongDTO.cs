using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class InHoaDonPhongDTO
    {
        private string maHoaDon;
        private string tenKhachHang;
        private string cmnd;
        private string diaChi;
        private string coQuan;
        private string sdt;
        private string email;
        private DateTime ngayDen;
        private DateTime ngayDi;
        private decimal soTienDatCoc;
        private decimal gia;
        private int soNgayO;
        private string maPhong;
        private string tenNhanVien;
        private decimal tongTien;

        public string Mahoadon
        {
            get
            {
                return maHoaDon;
            }
            set
            {
                maHoaDon = value;
            }
        }

        public string Tenkhachhang
        {
            get { return tenKhachHang;  }
            set
            {
                tenKhachHang = value;
            }
        }

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string Diachi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Coquan
        {
            get { return coQuan; }
            set { coQuan = value; }
        }

        public string Sodienthoai
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime Ngayden
        {
            get { return ngayDen; }
            set { ngayDen = value; }
        }

        public DateTime Ngaydi
        {
            get { return ngayDi; }
            set { ngayDi = value; }
        }

        public decimal Sotiendatcoc
        {
            get { return soTienDatCoc; }
            set { soTienDatCoc = value; }
        }

        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public int Songayo
        {
            get { return soNgayO; }
            set
            {
                soNgayO = value;
            }
        }

        public string Maphong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        public string Tennhanvien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public decimal Tongtien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
