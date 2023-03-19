using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OdevvErdıncHoca
{
    public class Personel
    {
        private string id;
        private DateTime yas;
        private string ad;
        private string soyad;
        private string mail;
        private string telefon;
        private string resimYolu;
        private DateTime iseGirisTarihi;
        public string Telefon
        {
            get
            {
                return this.telefon;
            }
            set
            {
                if (value.Count(char.IsDigit)==10)
                    telefon = value;
                else throw new Exception("Telefon Numarasi 10 haneli olmali");
            }
        }
        public string Adres { get; set; }
        public string ResimYolu
        {
            get
            {
                return resimYolu;
            }
            set
            {
                if (value != null)
                    resimYolu = value;
                else if (value == "Resim Yok")
                    resimYolu = "Resim Yok";
                else resimYolu = "Resim Yok";
            }
        }

        public DateTime IseGirisTarihi
        {
            get
            {
                return iseGirisTarihi;
            }
            set
            {
                if (value.Date < DateTime.Now)
                    iseGirisTarihi = value;
                else throw new Exception("Ise Giris Tarihi Bu gunden ileriki bir tarih olamaz !");
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                if (value.EndsWith("@bilgeadam.com"))
                    mail = value;
                else throw new Exception("Mail Uzantisi Gecersiz.");
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (value.Length > 1 && value.All(char.IsLetter))
                    ad = value;
                else throw new Exception("Personel adi gecersiz !");
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                if (value.Length > 1 && value.All(char.IsLetter))
                    soyad = value;
                else throw new Exception("Personel soyadi gecersiz !");
            }
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value.Length == 5 && value.All(char.IsDigit))
                    id = value;
                else throw new Exception("ID 5 haneli ve sadece sayilardan olusmali !");
            }
        }
        public DateTime Yas
        {
            get
            {
                return yas;
            }
            set
            {
                if (DateTime.Now.Year - value.Year > 17) yas = value;
                else throw new Exception("Personel 18 yasindan kucuk olamaz !");
            }
        }






    }
}
