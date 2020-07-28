using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    /*"Izjavljam, da sem nalogo opravil samostojno in da sem njen avtor. Zavedam se, da v primeru, če izjava prvega stavka ni resnična, kršim disciplinska pravila."*/

    public partial class TicTacToe : Form
    {

        bool Navrsti = true; // true= X; false=Y
        int Navrsti_stej = 0;
        static String igralec1, igralec2;
         
        public TicTacToe()
        {
            InitializeComponent();
        }
        public static void NastaviImenaIgralcev(String ime1, String ime2)
        {
            igralec1 = ime1;
            igralec2 = ime2;
        }

        private void omeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seminarska naloga narejena v okviru predmeta Programiranje 1 \n\nAvtor: Gašper Črtalič, 1l", "O aplikaciji");
        }

        private void zapriToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void pritisk_gumb(object sender, EventArgs e)
        {
            Button b = (Button)sender; //če pritisnes na gumb, glede na to kdo je na vrsti se izpiše x ali o
            timer1.Start();
            if (Navrsti)
            {
                b.Text = "X";
                timer1.Start();
            }
                
            else
                b.Text = "O";

            Navrsti = !Navrsti;
            b.Enabled = false; //Ko igralec klikne na gumb in mu da vrednost, se le ta ko znova kliknem nesprmemeni

            Navrsti_stej++; //vsakic ko pritisnemo na gumb spremenljivka steje

            preveri_Zmago();
        }

        

        private void preveri_Zmago() //preverjanje ali imamo zmagovalca
        {
            bool jeZmagovalec = false;
            //preverjanje vodoravnih kombinacij
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))/*Če je gumb A1 ugasnen in so vsi trije v isti vrsti enaki potem je zmagovalec*/
                jeZmagovalec = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                jeZmagovalec = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                jeZmagovalec = true;

            //preverjanje navpičnih kombinacij
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))/*Če je gumb A1 ugasnen in so vsi trije v istem stolpcu enaki potem je zmagovalec*/
                jeZmagovalec = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                jeZmagovalec = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                jeZmagovalec = true;

            //preverjanje diagonalnih kombinacij           
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                jeZmagovalec = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                jeZmagovalec = true;


            if (jeZmagovalec)
            {
                Onemogoci_gumbe();
                timer1.Stop();
                
                string zmagovalec = "";

                if (Navrsti)
                {
                    zmagovalec = igralec2;
                    stetjeZmagaO.Text = (Int32.Parse(stetjeZmagaO.Text) + 1).ToString();
                }

                else
                {
                    zmagovalec = igralec1;
                    stetjeZmagaX.Text = (Int32.Parse(stetjeZmagaX.Text) + 1).ToString();

                }

                MessageBox.Show(zmagovalec + " je zmagal!", "Čestitke!");

                //beleženje najhitrejših zmag
                string[] najZmaga = new string[5];

                if (jeZmagovalec)
                {
                    int najCas = 0;
                    if (cas > najCas)
                    {
                        najCas = cas;
                        for (int i = 0; i < 1; i++)
                        {
                            najZmaga[i] = " | " + zmagovalec + " | " + cas + " sekund";
                        }
                        //beleženeje v tekstovno datoteko

                        StreamWriter SW = new StreamWriter(@"najZmaga.txt");

                        for (int i = 0; i < 1; i++)
                        {
                            SW.WriteLine(najZmaga[i]);
                        }

                        SW.Close();
                    }
                    
                }

            else
            {
                if (Navrsti_stej == 9)
                {
                    stetjeDraw.Text = (Int32.Parse(stetjeDraw.Text) + 1).ToString();
                    MessageBox.Show("Izid je neodločen :/", "Jooj!"); //če je pritiskov 9 in ni zmagovalca je izid neodločen
                }
                    
            }
           
            }                     
                
        }
        
        private void Onemogoci_gumbe() //ko se igra konca se onemogočijo gumbi
        {
            try 
            {
                foreach (Control c in Controls) //Control je generična spremenljivka za to jo convertamo v gumb
                {
                    Button b = (Button)c; //za vsak gumb na nasi aplikcaiji ga ugasnemo
                    b.Enabled = false;
                }
            }
            catch { } //ni edinstvene vrednsoti za to catch pustimo prazen
            
        }

        private void igrajZnovaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Navrsti = true;                      //zavihek igraj znova
            Navrsti_stej = 0;
           
                foreach (Control c in Controls) 
                {
                    try
                    {
                        Button b = (Button)c; 
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch { }
            }          
        }

        private void vGumb(object sender, EventArgs e)  
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (Navrsti)
                    b.Text = "X";
                else
                    b.Text = "O";
            }                          //metodi za prepoznavanje kdo je va vrsti brez da bi kliknili na gumb
            
        }

        private void izGumb(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void štejOdZačetkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stetjeDraw.Text = "0";
            stetjeZmagaO.Text = "0";
            stetjeZmagaX.Text = "0";
        }

        int cas = 0; //štoparica
        private void timer1_Tick(object sender, EventArgs e)
        {         
            cas++;
            casomer.Text = cas.ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            casomer.Text = "0";
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.ShowDialog(); //odpre prvo login form nato sele igrico
            label1.Text = igralec1;
            label3.Text = igralec2;
        }

        
        

    }
}
