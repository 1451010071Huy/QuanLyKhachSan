using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhongDTO
    {
        private string maPhong;
        private string maLoai;
        private Boolean daDat;
        private Boolean daNhan;

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

        public Boolean Dadat
        {
            get
            {
                return daDat;
            }
            set
            {
                daDat = value;
            }
        }

        public Boolean Danhan
        {
            get
            {
                return daNhan;
            }
            set
            {
                daNhan = value;
            }
        }
    }
}
