using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HeThongDTO
    {
        private string userName;
        private string maNhanVien;
        private string password;

        public string Username
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

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

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
