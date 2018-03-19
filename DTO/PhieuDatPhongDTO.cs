using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuDatPhongDTO
    {

        private string maPhieuDat;
        private string maKhachHang;
        private DateTime ngayDen;
        private DateTime ngayDi;
        private decimal soTienDatCoc;
        private string username;
        private string tinhTrang;
        private int soNguoi;

        public string Maphieudat
        {
            get
            {
                return maPhieuDat;
            }
            set
            {
                maPhieuDat = value;
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

        public DateTime Ngayden
        {
            get
            {
                return ngayDen;
            }
            set
            {
                ngayDen = value;
            }
        }

        public DateTime Ngaydi
        {
            get
            {
                return ngayDi;
            }
            set
            {
                ngayDi = value;
            }
        }

        public decimal Sotiendatcoc
        {
            get
            {
                return soTienDatCoc;
            }
            set
            {
                soTienDatCoc = value;
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

        public string Tinhtrang
        {
            get
            {
                return tinhTrang;
            }
            set
            {
                tinhTrang = value;
            }
        }

        public int Songuoi
        {
            get
            {
                return soNguoi;
            }
            set
            {
                soNguoi = value;
            }
        }
    }
}
