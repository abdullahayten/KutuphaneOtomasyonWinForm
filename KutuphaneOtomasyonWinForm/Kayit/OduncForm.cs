using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kayit
{
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();

        private void OduncForm_Load(object sender, EventArgs e)
        {
            //listeledik(kayıtlar)
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //listeledik(kaynaklar)
            var kaynakList = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            //istenmeyen kaynak ve kullanıcı kolonunu gizledik
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adları duzenledik
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = TCBultxt.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            else
                label2.Text = "Böyle bir kullanıcı henüz yok";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }
    }
}
