using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietVatTuDTO
    {
        private string maVatTu;
        private string maLoaiPhong;
        private int soLuong;

        public string Mavattu
        {
            get
            {
                return maVatTu;
            }
            set
            {
                maVatTu = value;
            }
        }

        public string Maloaiphong
        {
            get
            {
                return maLoaiPhong;
            }
            set
            {
                maLoaiPhong = value;
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
