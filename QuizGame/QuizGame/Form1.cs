using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class QuizGame : Form
    {

        //quizgame varijable
        int tacanOdgovor;
        int brojPitanja = 1;
        int rezultat;
        int procenat;
        int ukupnoPitanja;


        public QuizGame()
        {
            InitializeComponent();

            pitajPitanje(brojPitanja);

            ukupnoPitanja = 6;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void proveriOdgovorEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == tacanOdgovor)
            {
                rezultat++;
            }

            if(brojPitanja == ukupnoPitanja)
            {
                //računanje procenta
                procenat = (int)Math.Round((double)(rezultat * 100) / ukupnoPitanja);

                MessageBox.Show(
                    "Kraj kviza" + Environment.NewLine + 
                    "Broj pitanja na koje ste tačno dali odgovor: " + rezultat + Environment.NewLine +
                    "Vaš ukupan procenat je: " + procenat + "%" + Environment.NewLine +
                    "Kliknite na OK da igrate ponovo."
                    );

                rezultat = 0;
                brojPitanja = 0;
                pitajPitanje(brojPitanja);

            }

            brojPitanja++;
            pitajPitanje(brojPitanja);

        }

        private void pitajPitanje(int pBroj)
        {
            switch(pBroj)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.pitanje1;
                    lblPitanje.Text = "Koji fudbaler se nalazi na slici?";
                    button1.Text = "Leo Messi";
                    button2.Text = "Kylian Mbappe";
                    button3.Text = "Cristiano Ronaldo";
                    button4.Text = "Ronaldo";
                    tacanOdgovor = 3;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.pitanje2;
                    lblPitanje.Text = "Koji košarkaš se nalazi na slici?";
                    button1.Text = "Michael Jordan";
                    button2.Text = "LeBron James";
                    button3.Text = "Nikola Jokic";
                    button4.Text = "Russell Westbrook";
                    tacanOdgovor = 1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.pitanje3;
                    lblPitanje.Text = "Koji fudbaler se nalazi na slici?";
                    button1.Text = "Neymar Jr.";
                    button2.Text = "Hulk";
                    button3.Text = "N'golo Kante";
                    button4.Text = "Didier Drogba";
                    tacanOdgovor = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.pitanje4;
                    lblPitanje.Text = "Koji glumac se nalazi na slici?";
                    button1.Text = "Jackie Chan";
                    button2.Text = "Tom Holland";
                    button3.Text = "Mark Wahlberg";
                    button4.Text = "Tom Cruise";
                    tacanOdgovor = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.pitanje5;
                    lblPitanje.Text = "Koji fudbaler se nalazi na slici?";
                    button1.Text = "David Beckham";
                    button2.Text = "Ronaldinho";
                    button3.Text = "Roberto Carlos";
                    button4.Text = "Johan Cruyff";
                    tacanOdgovor = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.pitanja;
                    lblPitanje.Text = "Ko je osvojio najvise zlatnih lopti?";
                    button1.Text = "Leo Messi";
                    button2.Text = "Cristiano Ronaldo";
                    button3.Text = "Neymar Jr.";
                    button4.Text = "David Beckham";
                    tacanOdgovor = 1;
                    break;
            }
        }
    }
}
