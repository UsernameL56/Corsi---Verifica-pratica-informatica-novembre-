using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classi;

namespace Corsi___Verifica_pratica_informatica__novembre_
{
    public partial class Form1 : Form
    {
        Immobili[] immobili;
        int indice;
        double[] rendite;
        public Form1()
        {
            InitializeComponent();
            immobili = new Immobili[100];
            indice = 0;
            rendite = new double[100];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiunta_Click(object sender, EventArgs e)
        {
            if (terrenoButton.Checked)
            {
                immobili[indice] = new Terreni(double.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), fabbricabile.Checked);
                rendite[indice] = immobili[indice].RenditaBase();
                MessageBox.Show("" + rendite[indice]);
                indice++;
            }
            else if (abitazioneButton.Checked)
            {
                immobili[indice] = new Abitazioni(double.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                indice++;
            }
            else if (atticoButton.Checked)
            {
                immobili[indice] = new Attici(double.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), double.Parse(textBox5.Text));
                indice++;
            }
            else
            {
                MessageBox.Show("Selezionare una categoria", "Info");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (immobili != null)
            {
                foreach (var immobile in immobili)
                {
                    //rendita = immobile.RenditaBase();
                    if (immobile != null)
                        listView1.Items.Add(immobile.ToString());
                }
            }
        }

        private void terrenoButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
        }
        private void abitazioneButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
        }
        private void atticoButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}