using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MargaretOvoAccount
{
    [Serializable]
    public class MargaretOvoAccout
    {
        #region DATA MEMBER
        private string name;
        private int ovoCash;
        private string ovoId;
        private int ovoPoints;
        private string phoneNumber;
        private string pin;
        #endregion

        #region CONTRUCTORS
        public MargaretOvoAccout(string name, string ovoId, string phoneNumber, string pin)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Pin = pin;
            this.OvoId = ovoId;
            this.OvoCash = 0;
            this.OvoPoints = 0;
        }
        #endregion

        #region PROPERTIES
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Nama Jangan Kosong!");
                }
            }
        }
        public int OvoCash
        {
            get => ovoCash;
            private set
            {
                if(value >= 0)
                {
                    ovoCash = value;
                }
                else
                {
                    ovoCash = 0;
                }
            }
        }
        public string OvoId
        {
            get => ovoId;
            set
            {
                if (value != "")
                {
                    ovoId = value;
                }
                else
                {
                    throw new Exception("OVO ID Jangan Kosong!");
                }
            }
        }
        public int OvoPoints
        {
            get => ovoPoints;
            private set
            {
                if (value >= 0)
                {
                    ovoPoints = value;
                }
                else
                {
                    ovoPoints = 0;
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value != "")
                {
                    bool isNumeric = int.TryParse(value, out int result);
                    if (isNumeric)
                    {
                        phoneNumber = value;
                    }
                    else
                    {
                        throw new Exception("Masukkan Nomor Telepon dengan Angka!");
                    }
                }
                else
                {
                    throw new Exception("Nomor Telepon tidak boleh kosong");
                }
            }
        }
        public string Pin
        {
            set
            {
                if(value.Length == 6)
                {
                    bool isNumeric = int.TryParse(value, out int result);
                    if(isNumeric)
                    {
                        pin = value;
                    }
                    else
                    {
                        throw new Exception("Pin Harus Angka!");
                    }
                }
                else
                {
                    throw new Exception("Pin Harus Berjumlah 6");
                }
            }
        }
        #endregion

        #region METHOD
        public void Buy(string itemType, int itemPrice)
        {
            if(itemPrice >= 5000)
            {
                if (ovoCash >= itemPrice)
                {
                    ovoCash -= itemPrice;
                    if (itemType == "Internet Voucher")
                    {
                        ovoPoints += (int)(itemPrice * 0.1);
                    }
                }
                else
                {
                    throw new Exception("OvoCash Tidak Mencukupi!");
                }
            }
            else
            {
                throw new Exception("Beli harga barang yang lebih dari 5000");
            }
        }

        public void TopUp(int nominal)
        {
            if (nominal >= 10000)
            {
                OvoCash = OvoCash + nominal;
            }
            else
            {
                throw new Exception("Minimum top up is Rp. 10.000");
            }
        }

        public string DisplayData()
        {
            string data = "Name : " + this.Name +
                           "\nPhone Number : " + this.PhoneNumber +
                           "\nOvo Id : " + this.OvoId +
                           "\nOvo Cash : " + this.OvoCash +
                           "\nOvo Points : " + this.OvoPoints + "\n";
            return data;
        }
        #endregion
    }
}