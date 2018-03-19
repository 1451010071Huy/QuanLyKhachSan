using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class InHoaDonDichVuDTO
    {
        protected string maHoaDon;
        protected string maPhieuThue;
        protected string tenDichVu;
        protected Decimal gia;
        protected string donViTinh;
        protected int soLuong;
        private string maPhong;
        private DateTime ngay;

        
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

        public string Maphieuthue
        {
            get
            {
                return maPhieuThue;
            }
            set
            {
                maPhieuThue = value;
            }
        }

        public string Tendichvu
        {
            get
            {
                return tenDichVu;
            }
            set
            {
                tenDichVu = value;
            }
        }

        public Decimal Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }

        public string Donvitinh
        {
            get
            {
                return donViTinh;
            }
            set
            {
                donViTinh = value;
            }
        }

        public int Soluong
        {
            get{
                return soLuong;
            }set{
                soLuong=value;
            }
        }

        public string MaPhong
        {
            get
            {
                return maPhong;
            }
            set
            {
                maPhong = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }
            set
            {
                ngay = value;
            }
        }
    }
}
