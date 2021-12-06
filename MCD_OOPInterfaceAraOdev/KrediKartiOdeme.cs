using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceAraOdev
{
    public class KrediKartiOdeme : Odeme, IOdeme
    {
        public string KartSahibiAd { get; set; }
        public string KartSahibiSoyad { get; set; }
        public byte SonKullanimAy { get; set; }
        public int SonKullanimYili { get; set; }
        public short CVV { get; set; }

        private string _kartNumarasi;

        public string KartNumarasi
        {
            get 
            { 
                return _kartNumarasi;
            }
            set
            {
                char[] dizi = value.ToCharArray();
                bool rakamDegilMi = false;
                foreach (var item in dizi)
                {
                    if (!char.IsDigit(item))//digit olmayan varsa
                    {
                        rakamDegilMi = true; // hemen yakala
                        break;// çık
                    }
                }//döngü bitti


                if (!rakamDegilMi && value.Length == 16)
                {
                    _kartNumarasi = value;
                }
                else
                {
                    throw new FormatException("HATA: Kart numarası 16 haneli değil veya uygun formatta girilmemiştir.");
                }
            }
        }


        public void OdemeSekliAyariYap()
        {
            throw new NotImplementedException();
        }

        public void OdemeYap()
        {
            throw new NotImplementedException();
        }
    }
}
