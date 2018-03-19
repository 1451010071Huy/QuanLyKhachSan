using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietDatPhongDTO
    {
        private string maPhieuDat;
        private string maPhong;

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
    }
}
