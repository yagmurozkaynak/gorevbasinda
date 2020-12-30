using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorevbasinda
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
         public static int zorluk;
        private void button1_Click(object sender, EventArgs e)
        {
          
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

			try
			{
				if (radioButton1.Checked) zorluk = 1;      
				else if (radioButton2.Checked) zorluk = 2; 
				else if (radioButton3.Checked) zorluk = 3; 

				else
				{   
					MessageBox.Show("Seçenek seçilmedi");
                    this.Close();
				}

			}
			catch (Exception hata)
			{ MessageBox.Show("hata" + hata.Message);} 
		
		
	}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
