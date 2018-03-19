using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KiemTraPhongDTO
    {
        private string maPhieuDat;
        private string maPhong;
        private DateTime ngayDen;
        private DateTime ngayDi;
        private string tinhTrang;
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
    }
}
