using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DichVuDTO
    {
        private string maDichVu;
        private string tenDichVu;
        private decimal gia;
        private string donViTinh;

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

        public decimal Gia
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
    }
}
