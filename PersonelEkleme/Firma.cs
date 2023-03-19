using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OdevvErdıncHoca
{
    public class Firma
    {
        public void BilgileriKontrolEt(Personel personel , Form1 form)
        {
            personel.ID = form.txtID.Text;
            personel.Ad = form.txtAd.Text;
            personel.Soyad = form.txtSoyad.Text;
            personel.Yas = form.dtpDogumTarihi.Value;
            personel.Adres = form.txtAdres.Text;
            personel.Telefon = form.mtbTelefon.Text;
            personel.Mail = form.txtMail.Text;
            personel.IseGirisTarihi = form.dtpIseGirisTarihi.Value;
            if (form.pbResim.ImageLocation.Contains(".jpg") || form.pbResim.ImageLocation.Contains(".png"))
                personel.ResimYolu = form.pbResim.ImageLocation;
            else
                personel.ResimYolu = "Resim Yok";
        }

        public void ListeyeEkle(List<Personel> personeller , ListView lvPersonelBilgileri)
        {
            lvPersonelBilgileri.Items.Clear();
            for (int i = 0; i < personeller.Count; i++)
            {
                lvPersonelBilgileri.Items.Add(personeller[i].ID);
                lvPersonelBilgileri.Items[i].SubItems.Add(personeller[i].Ad);
                lvPersonelBilgileri.Items[i].SubItems.Add(personeller[i].Soyad);
                lvPersonelBilgileri.Items[i].SubItems.Add(personeller[i].IseGirisTarihi.ToShortDateString());
                lvPersonelBilgileri.Items[i].SubItems.Add(personeller[i].Mail);
                lvPersonelBilgileri.Items[i].SubItems.Add(personeller[i].ResimYolu);
            }
        }

        public void BilgeriDoldur (List<Personel>personeller , Form1 form)
        {
            form.txtID.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].ID;
            form.txtAd.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Ad;
            form.txtSoyad.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Soyad;
            form.mtbTelefon.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Telefon;
            form.dtpDogumTarihi.Value = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Yas;
            form.txtID.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].ID;
            form.txtAdres.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Adres;
            form.txtMail.Text = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].Mail;
            form.dtpIseGirisTarihi.Value = personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].IseGirisTarihi;
            form.pbResim.ImageLocation =personeller[form.lvPersonelBilgileri.SelectedItems[0].Index].ResimYolu;
        }





    }
}
