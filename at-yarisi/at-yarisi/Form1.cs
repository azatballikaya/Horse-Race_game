using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string bahisatno;
        int kazananatno;
        int bahismiktarı;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;

        }
        Random rastgele=new Random();
        
        




        private void button3_Click(object sender, EventArgs e)
        {

            if ( Convert.ToInt32(label_bakiye.Text)< Convert.ToInt32(comboBox2.Text))
                MessageBox.Show("Bakiyen YETERSİZ\n YERİM SENİN GİBİ KUMARBAZI");
            else
            {
                bahismiktarı = Convert.ToInt32(comboBox2.Text);
                label_bakiye.Text = (Convert.ToInt32(label_bakiye.Text) - bahismiktarı).ToString();
                bahisatno = comboBox1.Text;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left+=rastgele.Next(5, 15);
            pictureBox3.Left+=rastgele.Next(5, 15);


            if(pictureBox1.Left>pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label6.Text = "1. AT ÖNDE GİDİYOR!!!";
            }
            else if(pictureBox2.Left>pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label6.Text = "2. AT ÖNDE GİDİYOR!!!";
            }
            else if(pictureBox3.Left>pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label6.Text = "3. AT ÖNDE GİDİYOR!!!";
            }


            if (pictureBox1.Left + pictureBox1.Width >= label5.Left)
            {

                timer1.Enabled = false;
                MessageBox.Show("1. AT KAZANDI");
                kazananatno = 1;
                if (bahisatno == "1")
                {
                    MessageBox.Show("Tebrikler Kazandınız!!!");
                    label_bakiye.Text=((bahismiktarı*2)+Convert.ToInt32(label_bakiye.Text)).ToString();
                }


            }
            if (pictureBox2.Left + pictureBox2.Width >= label5.Left)
            {

                timer1.Enabled = false;
                MessageBox.Show("2. AT KAZANDI");
                kazananatno = 2;
                if (bahisatno == "2")
                {
                    MessageBox.Show("Tebrikler Kazandınız!!!");
                    label_bakiye.Text = ((bahismiktarı*2) + Convert.ToInt32(label_bakiye.Text)).ToString();
                }
            }
            if (pictureBox3.Left + pictureBox3.Width >= label5.Left)
            {

                timer1.Enabled = false;
                MessageBox.Show("3. AT KAZANDI");
                kazananatno = 3;
                if (bahisatno == "3")
                {
                    MessageBox.Show("Tebrikler Kazandınız!!!");
                    label_bakiye.Text = ((bahismiktarı*2) + Convert.ToInt32(label_bakiye.Text)).ToString();
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  timer1.Enabled = true;
            label6.Text = "";
            pictureBox1.Location = new Point(-3,38);
            pictureBox2.Location = new Point(-3, 168);
            pictureBox3.Location = new Point(-3, 298);
            button1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("***HOŞGELDİN EKREM ABİ***");
        }
        /*   int bahismiktarı;
  private void button3_Click(object sender, EventArgs e)
  {

      if (bakiye < Convert.ToInt32(comboBox2.Text))
          MessageBox.Show("Bakiyeniz Yetersiz!!!");
      bahismiktarı = Convert.ToInt32(comboBox2.Text);
  }*/
    }
}
