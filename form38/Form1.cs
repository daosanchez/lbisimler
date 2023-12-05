using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form38
{
    public partial class Form1 : Form
    { 
        List<string> kisiler = new List<string>();
        int indexsira = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           lbİsimler.Items.Clear();


            kisiler.Add("Nursevim");
            kisiler.Add("Hilal");
            kisiler.Add("Ravza");
            kisiler.Add("Yezda");

            lbİsimler.DataSource = kisiler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtİsim.Text);


            lbİsimler.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtİsim.Text);
            if (durum)
            {
                MessageBox.Show("Aradığınız İsim Mevcut");
            }
            else
            {
                MessageBox.Show("Aradığınız İsim Mevcut Değil");
            }
                        

        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtİsim.Text);
            if(sira > -1)
            {
                MessageBox.Show(txtİsim.Text + " " + sira + ". Sırasındadır .");
            }
            else
            {
                MessageBox.Show(txtİsim.Text + " Sıralamada Yuooğk");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtİsim.Text);
            if(sira > -1)
            {
                kisiler.RemoveAt(sira);
            }

            lbİsimler.DataSource = kisiler.ToList();
        }

        private void btnRemoveSil_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtİsim.Text);
            if (durum)
            {
                kisiler.Remove(txtİsim.Text);  //Kişi adı ile liste silme
            }

            lbİsimler.DataSource = kisiler.ToList();  //listboxu güncelle
        }

        private void lbİsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtİsim.Text = lbİsimler.SelectedValue.ToString();
            indexsira = lbİsimler.SelectedIndex;

            //Listbox içindeki sırasını belirler
            //Aynı sıralama List(Kisiler) içinde geçerli
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //Mesaggebox.Show(İndexsira.ToString());

            kisiler[indexsira] = txtİsim.Text;

            lbİsimler.DataSource = kisiler.ToList();  // listbox güncelle
        }

        private void btnArtan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            lbİsimler.DataSource = kisiler.ToList(); // listbox güncelle
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();

            lbİsimler.DataSource = kisiler.ToList(); // listbox güncelle
        }

        private void btnKarakter_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                 
                if(kisiler[1].Length == 5)
                {
                    sayac++;
                }

            }

            MessageBox.Show("5 Krakterli :" + sayac + " tane öğrenci mevcut");
        }

        private void btnHarf_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {

                string kisi = kisiler[i];
                if (kisi[kisi.Length - 1] == 'M')
                {
                    sayac++;
                }

            }
            MessageBox.Show("Son Harfi a Karakteri :" + sayac + " tane öğrenci mevcut");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiler.Clear();
            lbİsimler.DataSource = kisiler.ToList(); // listbox güncelle
        }

        private void btnHarf2_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {

                string kisi = kisiler[i];
                if (kisi[kisi.Length - 1] == 'a')
                {
                    sayac++;
                }

            }
            MessageBox.Show("Son Harfi a Karakteri :" + sayac + " tane öğrenci mevcut");
        }
    }
    
}
