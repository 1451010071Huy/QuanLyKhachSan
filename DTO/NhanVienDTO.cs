using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private Boolean gioiTinh;
        private string diaChi;
        private string sdt;
        private string chucVu;

        public string Manhanvien
        {
            get
            {
                return maNhanVien;
            }
            set
            {
                maNhanVien = value;
            }
        }

        public string Tennhanvien
        {
            get
            {
                return tenNhanVien;
            }
            set
            {
                tenNhanVien = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaySinh;
            }
            set
            {
                ngaySinh = value;
            }
        }

        public Boolean Phai
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }

        public string Phone
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucVu;
            }
            set
            {
                chucVu = value;
            }
        }
    }
}
