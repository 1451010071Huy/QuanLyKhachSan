using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuThuePhongDTO
    {
        private string maPhieuThue;
        private string maPhieuDat;
        private string username;

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
