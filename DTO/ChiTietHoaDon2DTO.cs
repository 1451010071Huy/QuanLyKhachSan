using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDon2DTO
    {

        private string maHoaDon;
        private string dichVu;
        private string phong;
        private DateTime ngayDichVu;
        private float giaDichVu;
        private int soLuongDichVu;

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

        public string Dichvu
        {
            get
            {
                return dichVu;
            }
            set
            {
                dichVu = value;
            }
        }

        public string Phong
        {
            get
            {
                return phong;
            }
            set
            {
                phong = value;
            }
        }

        public DateTime NgayDV
        {
            get
            {
                return ngayDichVu;
            }
            set
            {
                ngayDichVu = value;
            }
        }

        public float GiaDV
        {
            get
            {
                return giaDichVu;
            }
            set
            {
                giaDichVu = value;
            }
        }

        public int SoluongDV
        {
            get
            {
                return soLuongDichVu;
            }
            set
            {
                soLuongDichVu = value;
            }
        }
    }
}
