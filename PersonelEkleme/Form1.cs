namespace OdevvErdıncHoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtID.Text = string.Empty;
            txtAdres.Text = string.Empty;
            mtbTelefon.Text = string.Empty;
            dtpDogumTarihi.Value = DateTime.Now;
            dtpIseGirisTarihi.Value = DateTime.Now;
            pbResim.Image = null;
            pbResim.ImageLocation = "Resim Yok";
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg)|*.jpg| Png (.png)|*.png";
            ofd.ShowDialog();
            pbResim.ImageLocation = ofd.FileName;

        }
        List<Personel> personeller = new List<Personel>();
        Firma firma = new Firma();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            try
            {
                firma.BilgileriKontrolEt(personel, this);
                personeller.Add(personel);
                firma.ListeyeEkle(personeller, lvPersonelBilgileri);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lvPersonelBilgileri.SelectedItems.Count > 0)
            {
                Personel personel = new Personel();
                try
                {
                    firma.BilgileriKontrolEt(personel, this);
                    personeller[lvPersonelBilgileri.SelectedItems[0].Index] = personel;
                    firma.ListeyeEkle(personeller, lvPersonelBilgileri);
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnKaydet.Enabled = true;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersonelBilgileri.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvPersonelBilgileri.SelectedItems)
                {
                    lvPersonelBilgileri.Items.Remove(item);

                    for (int i = 0; i < personeller.Count; i++)
                    {
                        if (personeller[i].ID == item.Text)
                            personeller.Remove(personeller[i]);
                    }

                }
                firma.ListeyeEkle(personeller, lvPersonelBilgileri);
            }
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void lvPersonelBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersonelBilgileri.SelectedItems.Count > 0)
            {
                btnKaydet.Enabled = false;
                btnResimSec.Enabled = true;
                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
                firma.BilgeriDoldur(personeller, this);
            }
            else
            {
                Temizle();
                btnKaydet.Enabled = true;
                btnResimSec.Enabled = true;
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
            }
        }
    }
}