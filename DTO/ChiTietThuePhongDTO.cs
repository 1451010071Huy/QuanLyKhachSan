using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietThuePhongDTO
    {
        private string maPhieuThue;
        private string maPhong;
        private DateTime ngay;
        private string maDichVu;
        private int soLuong;

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

        public string Maphong
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

        public string Madichvu
        {
            get
            {
                return maDichVu;
            }
            set
            {
                maDichVu = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soLuong;
            }
            set 
            { 
                soLuong = value;
            }
        }
    }
}
