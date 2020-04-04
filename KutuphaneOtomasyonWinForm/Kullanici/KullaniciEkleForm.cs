using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kullanici
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar =new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTCtxt.Text;
            kullanicilar.kullanici_tel = kullaniciTeltxt.Text;
            kullanicilar.kullanici_mail = kullaniciMailtxt.Text;
            kullanicilar.kullanici_ceza =Convert.ToDouble(kullaniciCezatxt.Text);
            if (radioE.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();

            //id ve kayıtlar kolonunu gizledik.
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            //kalan kolonların isimlerini düzenledik.
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon No";
            dataGridView1.Columns[6].HeaderText = "Ceza";
            dataGridView1.Columns[7].HeaderText = "Cinsiyet";
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
