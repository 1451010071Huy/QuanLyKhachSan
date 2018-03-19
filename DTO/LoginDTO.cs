using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoginDTO
    {
        private string username;
        private string tenNV;
        private string chucVu;
        private string maNV;

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

        public string TenNV
        {
            get
            {
                return tenNV;
            }
            set
            {
                tenNV = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                maNV = value;
            }
        }

        public string ChucVu
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
