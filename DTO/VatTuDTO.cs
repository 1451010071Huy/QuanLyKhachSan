using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VatTuDTO
    {
        private string maVatTu;
        private string tenVatTu;

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

        public string Tenvattu
        {
            get
            {
                return tenVatTu;
            }
            set
            {
                tenVatTu = value;
            }
        }
    }
}
