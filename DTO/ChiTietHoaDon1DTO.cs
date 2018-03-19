using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDon1DTO
    {

        private string maHoaDon;
        private string phong;
        private float giaPhong;
        private DateTime ngayDen;
        private DateTime ngayDi;
        private int soNgayO;
        private float thanhTien;
        private string nhanVien;
        private string khachHang;
        private float tienDatCoc;
        private float tienDichVu;

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

        public float Giaphong
        {
            get
            {
                return giaPhong;
            }
            set
            {
                giaPhong = value;
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

        public int Songayo
        {
            get
            {
                return soNgayO;
            }
            set
            {
                soNgayO = value;
            }
        }

        public float Thanhtien
        {
            get
            {
                return thanhTien;
            }
            set
            {
                thanhTien = value;
            }
        }

        public string Tennhanvien
        {
            get
            {
                return nhanVien;
            }
            set
            {
                nhanVien = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return khachHang;
            }
            set
            {
                khachHang = value;
            }
        }

        public float Tiendatcoc
        {
            get
            {
                return tienDatCoc;
            }
            set
            {
                tienDatCoc = value;
            }
        }

        public float Tiendichvu
        {
            get
            {
                return tienDichVu;
            }
            set
            {
                tienDichVu = value;
            }
        }
    }
}
