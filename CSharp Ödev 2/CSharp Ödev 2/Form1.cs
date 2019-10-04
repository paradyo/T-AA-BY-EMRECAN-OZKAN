using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace CSharp_Ödev_2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public string AppConfigOkuma() 
        {
            String value = ConfigurationManager.AppSettings["acacagim_tab"];
            return value;
        }
        public void AppConfigYazma(string sonTab)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["acacagim_tab"].Value = sonTab;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public int ArmstrongSayiBul(int baslangic, int bitis) 
        {
            double a, b, c, d;
            if (100 <= baslangic && bitis < 1000)
            {
                for (int armstrongSayi = baslangic; armstrongSayi <= bitis; armstrongSayi++)
                {
                    a = armstrongSayi % 10;
                    b = (armstrongSayi / 10) % 10;
                    c = (armstrongSayi / 100);

                    if (armstrongSayi == Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3))
                    {
                        listViewArmstrong.Items.Add(armstrongSayi.ToString());
                    }
                }
            }
            else {
                MessageBox.Show("Ya 100 ile 1000 arası bir değer giriniz\nya da 1000 ile 10000 arası değer giriniz.");
            }
            if (1000 <= baslangic && bitis < 10000)
            {
                for (int armstrongSayi = baslangic; armstrongSayi <= bitis; armstrongSayi++)
                {
                    a = armstrongSayi % 10;
                    b = (armstrongSayi / 10) % 10;
                    c = (armstrongSayi / 100) %10;
                    d = (armstrongSayi / 1000);

                    if (armstrongSayi == Math.Pow(a, 4) + Math.Pow(b, 4) + Math.Pow(c, 4) + Math.Pow(d, 4))
                    {
                        listViewArmstrong.Items.Add(armstrongSayi.ToString());
                    }
                }
            }
            return 0;
        }
        public int AsalSayiBul(int baslangic, int bitis) 
        {
            int sayac = 0;
            for (int asalSayi = baslangic; asalSayi <= bitis; asalSayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < asalSayi; i++)
                {
                    if (asalSayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol != 1)
                {
                    listViewAsal.Items.Add(asalSayi.ToString());
                    sayac++;
                }
            }

            return 0;
        }
        public int TekSayiBul(int baslangic, int bitis)
        {
            
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 != 0)
                {
                    listViewTek.Items.Add(i.ToString());
                }
            }
            return 0;
        }
        public int CiftSayiBul(int baslangic, int bitis)
        {

            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 0)
                {
                    listViewCift.Items.Add(i.ToString());
                }
            }
            return 0;
        }
        void logYaz(string cikti)
        {
            MessageBox.Show(cikti);
        }
        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBoxBaslangic.Text);
                Convert.ToInt32(txtBoxBitis.Text);
                return true;
            }
            catch (Exception e)
            {
                logYaz("Başarısız oldu! " + e.Message);
                return false;
            }
        }
        void EkraniAyarla(bool toplamBasarili = false)
        {
            if (!toplamBasarili)
            {
                txtBoxBaslangic.Text = txtBoxBitis.Text = "0";
                txtBoxBaslangic.SelectAll();
                txtBoxBaslangic.Focus();
            }

        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(txtBoxBaslangic.Text);
            int bitis = Convert.ToInt32(txtBoxBitis.Text);
            if (tabTumTablar.SelectedTab == tabTekSayilar)
                {
                    TekSayiBul(baslangic, bitis);

                    int tekToplam = 0;
                    int tekCarpim = 1;

                    for (int i = 0; i < listViewTek.Items.Count; i++)
                    {
                        tekToplam += Convert.ToInt32(listViewTek.Items[i].Text);
                        tekCarpim *= Convert.ToInt32(listViewTek.Items[i].Text);
                    }
                    listViewTek.Items.Add("Toplamı: " + tekToplam.ToString());
                    listViewTek.Items.Add("Çarpımı: " + tekCarpim.ToString());
                    DebugLoguYaz(tekToplam.ToString());
                    DebugLoguYaz(tekCarpim.ToString());
            }
            if (tabTumTablar.SelectedTab == tabCiftSayilar)
            {
                CiftSayiBul(baslangic, bitis);
                int ciftToplam = 0;
                int ciftCarpim = 1;

                for (int i = 0; i < listViewCift.Items.Count; i++)
                {
                    ciftToplam += Convert.ToInt32(listViewCift.Items[i].Text);
                    ciftCarpim *= Convert.ToInt32(listViewCift.Items[i].Text);
                }
                listViewCift.Items.Add("Toplamı: " + ciftToplam.ToString());
                listViewCift.Items.Add("Çarpımı: " + ciftCarpim.ToString());
                DebugLoguYaz(ciftToplam.ToString());
                DebugLoguYaz(ciftCarpim.ToString());
            }
            if (tabTumTablar.SelectedTab == tabAsalSayilar)
            {
                AsalSayiBul(baslangic, bitis);

                int asalToplam = 0;
                int asalCarpim = 1;

                for (int i = 0; i < listViewAsal.Items.Count; i++)
                {
                    asalToplam += Convert.ToInt32(listViewAsal.Items[i].Text);
                    asalCarpim *= Convert.ToInt32(listViewAsal.Items[i].Text);
                }
                listViewAsal.Items.Add("Toplamı: " + asalToplam.ToString());
                listViewAsal.Items.Add("Çarpımı: " + asalCarpim.ToString());
                DebugLoguYaz(asalToplam.ToString());
                DebugLoguYaz(asalCarpim.ToString());
            }
            if (tabTumTablar.SelectedTab == tabArmstrongSayilar)
            {
                ArmstrongSayiBul(baslangic, bitis);
                int armsToplam = 0;
                int armsCarpim = 1;

                for (int i = 0; i < listViewArmstrong.Items.Count; i++)
                {
                    armsToplam += Convert.ToInt32(listViewArmstrong.Items[i].Text);
                    armsCarpim *= Convert.ToInt32(listViewArmstrong.Items[i].Text);
                }
                listViewArmstrong.Items.Add("Toplamı: " + armsToplam.ToString());
                listViewArmstrong.Items.Add("Çarpımı: " + armsCarpim.ToString());
                DebugLoguYaz(armsToplam.ToString());
                DebugLoguYaz(armsCarpim.ToString());
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabTumTablar.SelectedIndex -= 1;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            tabTumTablar.SelectedIndex += 1;
        }

        private void txtBoxBaslangic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void txtBoxBitis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkraniAyarla();
            string acilacakTab = AppConfigOkuma();

            if (acilacakTab == "tabTekSayilar") {
                tabTumTablar.SelectedTab = tabTekSayilar;
            }
            if (acilacakTab == "tabCiftSayilar")
            {
                tabTumTablar.SelectedTab = tabCiftSayilar;
            }
            if (acilacakTab == "tabAsalSayilar")
            {
                tabTumTablar.SelectedTab = tabAsalSayilar;
            }
            if (acilacakTab == "tabArmstrongSayilar")
            {
                tabTumTablar.SelectedTab = tabArmstrongSayilar;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (tabTumTablar.SelectedTab == tabTekSayilar) 
            {
                listViewTek.Items.Clear();
            }
            if (tabTumTablar.SelectedTab == tabCiftSayilar)
            {
                listViewCift.Items.Clear();
            }
            if (tabTumTablar.SelectedTab == tabAsalSayilar)
            {
                listViewAsal.Items.Clear();
            }
            if (tabTumTablar.SelectedTab == tabArmstrongSayilar)
            {
                listViewArmstrong.Items.Clear();
            }
            
            txtBoxBaslangic.Text = txtBoxBitis.Text = "0";
            txtBoxBaslangic.SelectAll();
            txtBoxBaslangic.Focus();
        }
        public static void DebugLoguYaz(String Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // GitHub'a gider...
            System.Diagnostics.Process.Start("https://github.com/paradyo");
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000);
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sonTab = tabTumTablar.SelectedTab.Name;
            AppConfigYazma(sonTab);
        }
    }
}
