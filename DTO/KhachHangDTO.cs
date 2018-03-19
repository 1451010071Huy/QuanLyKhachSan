using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {

        private string maKhachHang;
        private string tenKhachHang;
        private Boolean gioiTinh;
        private string cmnd;
        private string diaChi;
        private string coQuan;
        private string sdt;
        private string email;

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

        public string Tenkhachhang
        {
            get
            {
                return tenKhachHang;
            }
            set
            {
                tenKhachHang = value;
            }
        }

        public Boolean Gioitinh
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

        public string CMND_PASSPORT
        {
            get
            {
                return cmnd;
            }
            set
            {
                cmnd = value;
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

        public string Coquan
        {
            get
            {
                return coQuan;
            }
            set
            {
                coQuan = value;
            }
        }

        public string Sodienthoai
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

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
