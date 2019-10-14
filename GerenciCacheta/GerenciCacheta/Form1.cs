using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciCacheta
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização dos TextBox dos pontos
            textBox1.Text = "10";
            textBox2.Text = "10";
            textBox3.Text = "10";
            textBox4.Text = "10";
            textBox5.Text = "10";
            textBox6.Text = "10";
            textBox7.Text = "10";
            textBox8.Text = "10";

            // Inicialização dos TextBox das reentradas
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";

            // Inicialização do TextBox da Rodada
            textBox19.Text = "0";


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
           
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int i = textbox1;

            if (i != 0)
            {
                textbox1 = Convert.ToInt32(textBox1.Text) - 1;
                textBox1.Text = Convert.ToString(textbox1);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int i = textbox1;

            if (i != 10)
            {
                textbox1 = Convert.ToInt32(textBox1.Text) + 1;
                textBox1.Text = Convert.ToString(textbox1);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int textbox2 = Convert.ToInt32(textBox2.Text);
            int i = textbox2;

            if (i != 0)
            {
                textbox2 = Convert.ToInt32(textBox2.Text) - 1;
                textBox2.Text = Convert.ToString(textbox2);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int textbox2 = Convert.ToInt32(textBox2.Text);
            int i = textbox2;

            if (i != 10)
            {
                textbox2 = Convert.ToInt32(textBox2.Text) + 1;
                textBox2.Text = Convert.ToString(textbox2);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int textbox3 = Convert.ToInt32(textBox3.Text);
            int i = textbox3;

            if (i != 0)
            {
                textbox3 = Convert.ToInt32(textBox3.Text) - 1;
                textBox3.Text = Convert.ToString(textbox3);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            int textbox3 = Convert.ToInt32(textBox3.Text);
            int i = textbox3;

            if (i != 10)
            {
                textbox3 = Convert.ToInt32(textBox3.Text) + 1;
                textBox3.Text = Convert.ToString(textbox3);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int textbox4 = Convert.ToInt32(textBox4.Text);
            int i = textbox4;

            if (i != 0)
            {
                textbox4 = Convert.ToInt32(textBox4.Text) - 1;
                textBox4.Text = Convert.ToString(textbox4);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int textbox4 = Convert.ToInt32(textBox4.Text);
            int i = textbox4;

            if (i != 10)
            {
                textbox4 = Convert.ToInt32(textBox4.Text) + 1;
                textBox4.Text = Convert.ToString(textbox4);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int textbox5 = Convert.ToInt32(textBox5.Text);
            int i = textbox5;

            if (i != 0)
            {
                textbox5 = Convert.ToInt32(textBox5.Text) - 1;
                textBox5.Text = Convert.ToString(textbox5);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int textbox5 = Convert.ToInt32(textBox5.Text);
            int i = textbox5;

            if (i != 10)
            {
                textbox5 = Convert.ToInt32(textBox5.Text) + 1;
                textBox5.Text = Convert.ToString(textbox5);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int textbox6 = Convert.ToInt32(textBox6.Text);
            int i = textbox6;

            if (i != 0)
            {
                textbox6 = Convert.ToInt32(textBox6.Text) - 1;
                textBox6.Text = Convert.ToString(textbox6);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int textbox6 = Convert.ToInt32(textBox6.Text);
            int i = textbox6;

            if (i != 10)
            {
                textbox6 = Convert.ToInt32(textBox6.Text) + 1;
                textBox6.Text = Convert.ToString(textbox6);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int textbox7 = Convert.ToInt32(textBox7.Text);
            int i = textbox7;

            if (i != 0)
            {
                textbox7 = Convert.ToInt32(textBox7.Text) - 1;
                textBox7.Text = Convert.ToString(textbox7);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int textbox7 = Convert.ToInt32(textBox7.Text);
            int i = textbox7;

            if (i != 10)
            {
                textbox7 = Convert.ToInt32(textBox7.Text) + 1;
                textBox7.Text = Convert.ToString(textbox7);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int textbox8 = Convert.ToInt32(textBox8.Text);
            int i = textbox8;

            if (i != 0)
            {
                textbox8 = Convert.ToInt32(textBox8.Text) - 1;
                textBox8.Text = Convert.ToString(textbox8);
            }
            else
                MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int textbox8 = Convert.ToInt32(textBox8.Text);
            int i = textbox8;

            if (i != 10)
            {
                textbox8 = Convert.ToInt32(textBox8.Text) + 1;
                textBox8.Text = Convert.ToString(textbox8);
            }
            else
                MessageBox.Show("Máximos de pontos Atingidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int textbox19;
            textbox19 = Convert.ToInt32(textBox19.Text) + 1;
            textBox19.Text = Convert.ToString(textbox19);

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadastro1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
           

                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }

            
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}

