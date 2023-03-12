using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Configuration;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    { 



        string data_sijainti = "C:\\temp\\henkilöstö.txt";
       
        
        //Antaa lokiin ajan
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd.MM.yyyy - HH.mm.ss.ffff");
        }


        public void Tallenna()
        {



            //Tallentaa dataGridViewin datan tekstitiedostoon
            //Lohkot erotetaan ; -merkillä
            using (TextWriter tw = new StreamWriter(data_sijainti))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write(';');
                        }
                    }
                    tw.WriteLine();
                }
            }


            //Tallentaa tietoja lokiin
            string aika = GetTimestamp(DateTime.Now);
            using (TextWriter sw = File.AppendText(@"c:\\temp\\loki.txt"))
            {
                sw.WriteLine("\n" + "------------------------------------------------------");
                sw.WriteLine("KONEEN NIMI: {0}", Environment.MachineName.ToString());
                sw.WriteLine("KÄYTTÄJÄ: {0}", Environment.UserName.ToString());
                sw.WriteLine("VIIMEKSI MUOKATTU: {0}", aika.ToString());
                sw.WriteLine("------------------------------------------------------");
            }

        }


        private void Poista()
        {
            //Poistaa valituista riveistä kaiken tiedon, sekä koko rivin
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);                                   
            }
        }


        public Form1()
        {
            InitializeComponent();
        }





        //Tämää kohta lisää dataGridViewiin uuden rivin jonka tidot on otettu textboxeista
        //
        //Vaatii, että jokaisessa kohdassa on tekstiä
        //
        //Lopuksi textboxit tyhjentyvät
        public void lisaa_btn_Click(object sender, EventArgs e)
        {

            if (txt_etunimi.Text.Length > 0 && txt_tokanimi.Text.Length > 0 && txt_sukunimi.Text.Length > 0 && txt_kutsumanimi.Text.Length > 0 && txt_hetu.Text.Length > 0 && txt_katuosoite.Text.Length > 0 && txt_postinro.Text.Length > 0 && txt_postipaikka.Text.Length > 0 && txt_titteli.Text.Length > 0 && txt_yksikkö.Text.Length > 0) 
            {
                dataGridView1.Rows.Add(txt_etunimi.Text, txt_tokanimi.Text, txt_sukunimi.Text, txt_kutsumanimi.Text, txt_hetu.Text, txt_katuosoite.Text, txt_postinro.Text, txt_postipaikka.Text, dateTimePicker1.Text, dateTimePicker2.Text, txt_titteli.Text, txt_yksikkö.Text);



                txt_etunimi.Clear();                                
                txt_tokanimi.Clear();
                txt_sukunimi.Clear();
                txt_hetu.Clear();
                txt_katuosoite.Clear();                                                                             //Tyhjentää tekstikentät
                txt_postinro.Clear();
                txt_postipaikka.Clear();
                txt_titteli.Clear();
                txt_yksikkö.Clear();
                txt_kutsumanimi.Clear();

            }
            else
            {
                MessageBox.Show("Sinun täytyy antaa kaikki tiedot!");
            }



            Tallenna();
        }









        //Seuraava osa poistaa valitut tiedot
        //Poistaminen vaatii käyttäjän vahvistuksen
        private void button1_Click(object sender, EventArgs e)
        {

            int poistamaara = dataGridView1.SelectedRows.Count;

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Haluatko varmasti poistaa " + poistamaara + " henkilön tiedot?", "HUOMIO!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Poista nappia painettaessa valitut osat poistuu
                        Poista();
                    }


                }

                else
                {
                    MessageBox.Show("Sinun pitää valita kokonainen rivi positettavaksi.", "HUOMIO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ota yhteyttä IT-tukeen tai palveluntarjoajaan.","Tapahtui odottamaton virhe!");
            }


            Tallenna();
        }









        //Tämä osio toteutuu kun sovellus avataan

        private void Form1_Load(object sender, EventArgs e)
        {

            FileInfo tallennus = new FileInfo(data_sijainti);


            try
            {
                if (tallennus.Exists == true)
                {
                    using (StreamReader lukija = new StreamReader(data_sijainti))
                    {
                        string[] rivit = File.ReadAllLines(data_sijainti);                                          //Jokainen rivi lisätää tekstistä listaan
                        string[] sisältö;


                        for (int i = 0; i < rivit.Length; i++)                                                      //Käy kaikki rivit läpi
                        {
                            sisältö = rivit[i].ToString().Split(';');                                               //Pilkkoo tekstin osiin

                            string[] row = new string[sisältö.Length];                                              //syöttää yhden rivin kaiken sisällön yhteen listan lokeroon

                            for (int j = 0; j < sisältö.Length; j++)
                            {
                                row[j] = sisältö[j].Trim();                                                         //syöttää kaikki tiedot yhteen listaan, missä yksi lohko on yhden rivin tiedot
                            }
                            dataGridView1.Rows.Add(row);                                                            //Syöttää tiedot dataGridViewiin
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Tapahtui odottamaton virhe!", "ERROR!");
            }
        }

        private void txt_hetu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
