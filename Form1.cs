using Microsoft.VisualBasic.ApplicationServices;
using System.Resources;

namespace Oběšenec_grafická_verze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hadaneSlovo.VymysliNoveSlovo();
            hadaneSlovo.VygenerujCastecneOdhaleneSlovo();
            skryteSlovo.Text = hadaneSlovo.VratCastecneOdhaleneSlovo;
            pocetPismen.Text = "Počet písmen: " + hadaneSlovo.VratCastecneOdhaleneSlovo.Length;
        }

        HadaneSlovo hadaneSlovo = new HadaneSlovo();
        public char HadanePismeno;
        Button PomocneTlacitko = null;


        private void Button_Click(object sender, EventArgs e)
        {
            ZpracujKlikNaTlacitko(((Button)sender).Text);
            hadaneSlovo.JePismenoObsazeneVeSlove(HadanePismeno);
            skryteSlovo.Text = hadaneSlovo.VratCastecneOdhaleneSlovo;
            PomocneTlacitko = (Button)sender;
            if (hadaneSlovo.JePismenoVeSlove)
            {
                PomocneTlacitko.ForeColor = Color.Green;
            }
            else
            {
                PomocneTlacitko.ForeColor = Color.Red;
            }

            OdhalovaniObesence();




            if (hadaneSlovo.PocetNeuspesnychPokusu == hadaneSlovo.CelkovyPocetPokusu)
            {
                MessageBox.Show("Bohužel jsi prohrál. Hádané slovo bylo: " + hadaneSlovo.VymysleneSlovo);
                Application.Exit();
            }
            else if (!hadaneSlovo.JeSlovoUhodnute())
            {
                MessageBox.Show("Gratuluji k vítězství!");
                Application.Exit();
            }
        }

        private void ZpracujKlikNaTlacitko(string textTlacitka)
        {

            HadanePismeno = char.Parse(textTlacitka);
        }

        private void OdhalovaniObesence()
        {
            switch (hadaneSlovo.PocetNeuspesnychPokusu)
            {
                case 0:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_0;
                    break;
                case 1:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_1;
                    break;
                case 2:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_2;
                    break;
                case 3:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_3;
                    break;
                case 4:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_4;
                    break;
                case 5:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_5;
                    break;
                case 6:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_6;
                    break;
                case 7:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_7;
                    break;
                case 8:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_8;
                    break;
                case 9:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_9;
                    break;
                case 10:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_10;
                    break;
                case 11:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_11;
                    break;
                case 12:
                    pictureBoxObesenec.Image = Properties.Resources.sibenice_12;
                    break;
            }
        }
    }
}