using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private string maLoai;
        private decimal gia;
        private int soNguoi;

        public string Maloai
        {
            get
            {
                return maLoai;
            }
            set
            {
                maLoai = value;
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

        public int Songuoi
        {
            get
            {
                return soNguoi;
            }
            set
            {
                soNguoi = value;
            }
        }
    }
}
