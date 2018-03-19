using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonDTO
    {

        private string maHoaDon;
        private DateTime ngayThanhToan;
        private decimal tongTien;
        private string maPhieuThue;
        private string maKhachHang;
        private string username;

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

        public DateTime Ngaythanhtoan
        {
            get
            {
                return ngayThanhToan;
            }
            set
            {
                ngayThanhToan = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return tongTien;
            }
            set
            {
                tongTien = value;
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

        public string Makhachhang
        {
            get
            {
                return maKhachHang;
            }
            set
            {
                maKhachHang = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
    }
}
