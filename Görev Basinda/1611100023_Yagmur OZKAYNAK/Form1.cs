using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 

namespace gorevbasinda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

	

		int yapraksayisi =17, deger ,skor, yapraksirasi = 0, Puan = 0, konum = 140, Can = 3;
        ArrayList yapraklar = new ArrayList(); 
        Random rnd = new Random();  
        private void yapraklarOlustur()
        {
            for (int i = 0; i < yapraksayisi; i++)
            {
                PictureBox yaprak = new PictureBox();	
                deger = rnd.Next(1, 17);  
                skor = 10;
                yaprak.Size = new Size(65, 65);	
                yaprak.SizeMode = PictureBoxSizeMode.StretchImage; 
                yaprak.ImageLocation = "png/" + Convert.ToString(deger) + ".png"; 
                yaprak.Location = new Point(350, 5); 
                yaprak.Visible = false;  
                this.Controls.Add(yaprak); 
                yapraklar.Add(yaprak); 
            } 
        }

       

        private void yapraklarDusur()
        {
            if (yapraksirasi < yapraksayisi)
            {
                PictureBox yaprak = ((PictureBox)yapraklar[yapraksirasi]);
                string dosya_adi = yaprak.ImageLocation;
                yaprak.Visible = true;
                yaprak.Top = yaprak.Top + Form4.zorluk*2;
                yaprak.Location = new Point(konum, yaprak.Location.Y);
				yaprak.BackColor = Color .Transparent;
                if (dosya_adi == "png/15.png" || dosya_adi == "png/16.png" || dosya_adi == "png/17.png") skor = -10;
                else skor = 10;

                if (yaprak.Bottom >= yaprak_sepeti.Top + 5 && yaprak.Left >= yaprak_sepeti.Left && yaprak.Right <= yaprak_sepeti.Right) 
                {
                        yapraksirasi++;
                        yaprak.Visible = false;
                        Puan = Puan + skor;   
                }

                labelSkor.Text = Puan.ToString();
             }

                    else
                     {
                        timer1.Stop();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Tebrikler!Oyun bitti.Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    Form4 frm = new Form4();
                    frm.Show();
                }
                
            }
         }

        private void KalanHak(object sender, EventArgs e)
        {


            if (yapraksirasi < yapraksayisi)
            {

                PictureBox yaprak = ((PictureBox)yapraklar[yapraksirasi]);
                

                    if (yaprak.Bottom > yaprak_sepeti.Bottom && !(yaprak.Right >= yaprak_sepeti.Left && yaprak.Left <= yaprak_sepeti.Right))
                    {
                        if (skor == 10)
                        {
                            Can--;
                                             

                        for (int i = 0; i < yapraklar.Count; i++)
                        {
                            PictureBox a = ((PictureBox)yapraklar[yapraksirasi]);
                            ((PictureBox)yapraklar[yapraksirasi]).Dispose();
                        }
                        yapraklar.Clear();
                        DialogResult devam = DialogResult.None;
                        timer1.Stop();
                        if (Can > 0)
                        {
                            devam = MessageBox.Show("Kaçırdınız!!Kalan Hakkınız = " + Can.ToString());
                            if (devam == DialogResult.OK)
                            {
                                Form1_Load(sender, e);

                            }
                        } }
                        
                     else
                        {
                            Puan = Puan + 0;
                            yapraksirasi++;
                            yaprak.Visible = false;
                            Form1_Load(sender, e); }
                                              
                        }


                    labelCan.Text = Can.ToString();
                    if (Can == 0)
                    {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Hakkınız kalmadı!Oyun bitti.Programdan çıkılsın mı?", "UYARI", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        //this.Close();
                        Application.Exit();
                    }
                    else
                    {
                        this.Hide();
                        Form4 frm = new Form4();
                        frm.Show();
                        
                    }
                }
               
                
            }

            else
            {
                timer1.Stop();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Tebrikler!Oyun bitti.Programdan çıkılsın mı?", "UYARI", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.Hide();
                    Form4 frm = new Form4();
                    frm.Show();
                }
            }
            }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            yaprak_sepeti.Left = e.X; 
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            yapraklarOlustur(); 
            timer1.Start(); 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            yapraklarDusur();
            KalanHak(sender, e); 
        }


        private void labelSkor_TextChanged(object sender, EventArgs e)
        {
            konum = rnd.Next(50, 1000);
        }		
	}
}
