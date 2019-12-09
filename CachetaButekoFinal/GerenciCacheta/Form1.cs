using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciCacheta
{
    public partial class frmCadastro : Form
    {
        int reentrada = 0;
        RadioButton rbnSelecionado = null;
        RadioButton rbnSelecionado1 = null;
        RadioButton rbnSelecionado2 = null;
        RadioButton rbnSelecionado3 = null;
        RadioButton rbnSelecionado4 = null;
        RadioButton rbnSelecionado5 = null;
        RadioButton rbnSelecionado6 = null;
        RadioButton rbnSelecionado7 = null;

        int totaljogadores = 0;
        int totalaposta;
        public object TxtCadastro1 { get; internal set; }

        public void setNometxt(string cadastro)
        {
            this.txtCadastro1.Text = cadastro;
        }

        public void zerarRBT()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;

        }

        public void renovarTabStop()
        {
            radioButton1.TabStop = true;
            radioButton8.TabStop = true;
            radioButton5.TabStop = true;
            radioButton4.TabStop = true;
            radioButton13.TabStop = true;
            radioButton16.TabStop = true;
            radioButton22.TabStop = true;
            radioButton19.TabStop = true;
        }
        public void limparRadio()
        {
            rbnSelecionado = null;
            rbnSelecionado1 = null;
            rbnSelecionado2 = null;
            rbnSelecionado3 = null;
            rbnSelecionado4 = null;
            rbnSelecionado5 = null;
            rbnSelecionado6 = null;
            rbnSelecionado7 = null;
        }
        public frmCadastro()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


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
            textBox19.Text = "1";

            //hora
            textBox20.Text = "Data: " + DateTime.Now.ToString("dd-MM-y");
            textBox21.Text = "Hora: " + DateTime.Now.ToString("HH:mm");
            listBox1.Items.Add("Inicio as: " + DateTime.Now.ToString("HH:mm") + " do dia: " + DateTime.Now.ToString("dd-MM-y"));
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro7.TabStop = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int jogadores = 8;
                int vazio = 0;

                if (String.IsNullOrEmpty(txtCadastro1.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro2.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro3.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro4.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro5.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro6.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro7.Text))
                {
                    vazio++;
                }
                if (String.IsNullOrEmpty(txtCadastro8.Text))
                {
                    vazio++;
                }


                int a = 0;
                if (String.IsNullOrEmpty(textBox10.Text))
                { }
                else a = Convert.ToInt32(textBox10.Text);

                totaljogadores = (jogadores - vazio);
                int apostabase = totaljogadores * a;
                totalaposta = apostabase + (a * reentrada);
                textBox9.Text = Convert.ToString(totalaposta);
            }
            catch (Exception)
            {
                MessageBox.Show("Ta jogando em Dubai caralho?", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox9.Text = "0";
                textBox10.Text = "0";
            }
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
            listBox1.Items.Clear();
            listBox1.Items.Add("Rodada: " + textBox19.Text + " do dia: " + DateTime.Now.ToString("dd-MM-y") + " às: " + DateTime.Now.ToString("HH:mm"));


            textbox19 = Convert.ToInt32(textBox19.Text) + 1;
            textBox19.Text = Convert.ToString(textbox19);


            if (String.IsNullOrEmpty(txtCadastro1.Text) | (txtCadastro1.Enabled == false))
            { }
            else
            {
                int textbox1 = Convert.ToInt32(textBox1.Text);
                int i = textbox1;


                if (rbnSelecionado.Text.Equals("C") & i != 0)
                {
                    textbox1 = Convert.ToInt32(textBox1.Text) - 1;
                    textBox1.Text = Convert.ToString(textbox1);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro1.Text));
                }
                else if (rbnSelecionado.Text.Equals("D") & i != 0)
                {
                    textbox1 = Convert.ToInt32(textBox1.Text) - 2;
                    textBox1.Text = Convert.ToString(textbox1);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro1.Text));
                }
                else if (rbnSelecionado.Text.Equals("V") & i != 0)
                {
                    textbox1 = Convert.ToInt32(textBox1.Text);
                    textBox1.Text = Convert.ToString(textbox1);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro1.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Selecionando o RBT para o player 2
            if (String.IsNullOrEmpty(txtCadastro2.Text) | (txtCadastro2.Enabled == false))
            { }
            else
            {
                int textbox2 = Convert.ToInt32(textBox2.Text);
                int i2 = textbox2;

                if (rbnSelecionado1.Text.Equals("C") & i2 != 0)
                {
                    textbox2 = Convert.ToInt32(textBox2.Text) - 1;
                    textBox2.Text = Convert.ToString(textbox2);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro2.Text));
                }
                else if (rbnSelecionado1.Text.Equals("D") & i2 != 0)
                {
                    textbox2 = Convert.ToInt32(textBox2.Text) - 2;
                    textBox2.Text = Convert.ToString(textbox2);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro2.Text));
                }
                else if (rbnSelecionado1.Text.Equals("V") & i2 != 0)
                {
                    textbox2 = Convert.ToInt32(textBox2.Text);
                    textBox2.Text = Convert.ToString(textbox2);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro2.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Selecionando o RBT para o player 3
            if (String.IsNullOrEmpty(txtCadastro3.Text) | (txtCadastro3.Enabled == false))
            { }
            else
            {
                int textbox3 = Convert.ToInt32(textBox3.Text);
                int i3 = textbox3;

                if (rbnSelecionado2.Text.Equals("C") & i3 != 0)
                {
                    textbox3 = Convert.ToInt32(textBox3.Text) - 1;
                    textBox3.Text = Convert.ToString(textbox3);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro3.Text));
                }
                else if (rbnSelecionado2.Text.Equals("D") & i3 != 0)
                {
                    textbox3 = Convert.ToInt32(textBox3.Text) - 2;
                    textBox3.Text = Convert.ToString(textbox3);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro3.Text));
                }
                else if (rbnSelecionado2.Text.Equals("V") & i3 != 0)
                {
                    textbox3 = Convert.ToInt32(textBox3.Text);
                    textBox3.Text = Convert.ToString(textbox3);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro3.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Selecionando o RBT para o player 4
            if (String.IsNullOrEmpty(txtCadastro4.Text) | (txtCadastro4.Enabled == false))
            { }
            else
            {
                int textbox4 = Convert.ToInt32(textBox4.Text);
                int i4 = textbox4;

                if (rbnSelecionado3.Text.Equals("C") & i4 != 0)
                {
                    textbox4 = Convert.ToInt32(textBox4.Text) - 1;
                    textBox4.Text = Convert.ToString(textbox4);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro4.Text));
                }
                else if (rbnSelecionado3.Text.Equals("D") & i4 != 0)
                {
                    textbox4 = Convert.ToInt32(textBox4.Text) - 2;
                    textBox4.Text = Convert.ToString(textbox4);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro4.Text));
                }
                else if (rbnSelecionado3.Text.Equals("V") & i4 != 0)
                {
                    textbox4 = Convert.ToInt32(textBox4.Text);
                    textBox4.Text = Convert.ToString(textbox4);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro4.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Selecionando o RBT para o player 5
            if (String.IsNullOrEmpty(txtCadastro5.Text) | (txtCadastro5.Enabled == false))
            { }
            else
            {
                int textbox5 = Convert.ToInt32(textBox5.Text);
                int i5 = textbox5;

                if (rbnSelecionado4.Text.Equals("C") & i5 != 0)
                {
                    textbox5 = Convert.ToInt32(textBox5.Text) - 1;
                    textBox5.Text = Convert.ToString(textbox5);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro5.Text));
                }
                else if (rbnSelecionado4.Text.Equals("D") & i5 != 0)
                {
                    textbox5 = Convert.ToInt32(textBox5.Text) - 2;
                    textBox5.Text = Convert.ToString(textbox5);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro5.Text));
                }
                else if (rbnSelecionado4.Text.Equals("V") & i5 != 0)
                {
                    textbox5 = Convert.ToInt32(textBox5.Text);
                    textBox5.Text = Convert.ToString(textbox5);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro5.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Selecionando o RBT para o player 6
            if (String.IsNullOrEmpty(txtCadastro6.Text) | (txtCadastro6.Enabled == false))
            { }
            else
            {
                int textbox6 = Convert.ToInt32(textBox6.Text);
                int i6 = textbox6;

                if (rbnSelecionado5.Text.Equals("C") & i6 != 0)
                {
                    textbox6 = Convert.ToInt32(textBox6.Text) - 1;
                    textBox6.Text = Convert.ToString(textbox6);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro6.Text));
                }
                else if (rbnSelecionado5.Text.Equals("D") & i6 != 0)
                {
                    textbox6 = Convert.ToInt32(textBox6.Text) - 2;
                    textBox6.Text = Convert.ToString(textbox6);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro6.Text));
                }
                else if (rbnSelecionado5.Text.Equals("V") & i6 != 0)
                {
                    textbox6 = Convert.ToInt32(textBox6.Text);
                    textBox6.Text = Convert.ToString(textbox6);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro6.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Selecionando o RBT para o player 7
            if (String.IsNullOrEmpty(txtCadastro7.Text) | (txtCadastro7.Enabled == false))
            { }
            else
            {
                int textbox7 = Convert.ToInt32(textBox7.Text);
                int i7 = textbox7;

                if (rbnSelecionado6.Text.Equals("C") & i7 != 0)
                {
                    textbox7 = Convert.ToInt32(textBox7.Text) - 1;
                    textBox7.Text = Convert.ToString(textbox7);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro7.Text));
                }
                else if (rbnSelecionado6.Text.Equals("D") & i7 != 0)
                {
                    textbox7 = Convert.ToInt32(textBox7.Text) - 2;
                    textBox7.Text = Convert.ToString(textbox7);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro7.Text));
                }
                else if (rbnSelecionado6.Text.Equals("V") & i7 != 0)
                {
                    textbox7 = Convert.ToInt32(textBox7.Text);
                    textBox7.Text = Convert.ToString(textbox7);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro7.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Selecionando o RBT para o player 8
            if (String.IsNullOrEmpty(txtCadastro8.Text) | (txtCadastro8.Enabled == false))
            { }
            else
            {

                int textbox8 = Convert.ToInt32(textBox8.Text);
                int i8 = textbox8;

                if (rbnSelecionado7.Text.Equals("C") & i8 != 0)
                {
                    textbox8 = Convert.ToInt32(textBox8.Text) - 1;
                    textBox8.Text = Convert.ToString(textbox8);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Fuga do Jogador: ", txtCadastro8.Text));
                }
                else if (rbnSelecionado7.Text.Equals("D") & i8 != 0)
                {
                    textbox8 = Convert.ToInt32(textBox8.Text) - 2;
                    textBox8.Text = Convert.ToString(textbox8);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Derrota do Jogador: ", txtCadastro8.Text));
                }
                else if (rbnSelecionado7.Text.Equals("V") & i8 != 0)
                {
                    textbox8 = Convert.ToInt32(textBox8.Text);
                    textBox8.Text = Convert.ToString(textbox8);
                    listBox1.Items.Add(String.Format("{0,0}{1,1:L}", "Vitória do Jogador: ", txtCadastro8.Text));
                }
                else
                    MessageBox.Show("Pontos Zerados - Pague Novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (textBox1.Text == "0")
            {
                txtCadastro1.Enabled = false;
            }
            if (textBox2.Text == "0")
            {
                txtCadastro2.Enabled = false;
            }
            if (textBox3.Text == "0")
            {
                txtCadastro3.Enabled = false;
            }
            if (textBox4.Text == "0")
            {
                txtCadastro4.Enabled = false;
            }
            if (textBox5.Text == "0")
            {
                txtCadastro5.Enabled = false;
            }
            if (textBox6.Text == "0")
            {
                txtCadastro6.Enabled = false;
            }
            if (textBox7.Text == "0")
            {
                txtCadastro7.Enabled = false;
            }
            if (textBox8.Text == "0")
            {
                txtCadastro8.Enabled = false;
            }
            zerarRBT();
            limparRadio();
            //Adicionar Hora do Sistema
            string data = DateTime.Now.ToString("dd-MM-y");
            string hora = DateTime.Now.ToString("HH:mm");

            listBox1.Items.Add("--------------------------------------------");

            // salvar no txt
            ListBox mylist = new ListBox();

            // mylist.Items.Add("Teste");

            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath, true);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
            renovarTabStop();

            Form3 h = new Form3();
            string vitoria;

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
                & txtCadastro6.Enabled == false & txtCadastro7.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro8.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
    & txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro7.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
& txtCadastro7.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro6.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro7.Enabled == false
& txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro5.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro7.Enabled == false & txtCadastro5.Enabled == false
& txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro4.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro2.Enabled == false & txtCadastro7.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
& txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro3.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro1.Enabled == false & txtCadastro7.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
& txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro2.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }

            if (txtCadastro7.Enabled == false & txtCadastro2.Enabled == false & txtCadastro3.Enabled == false & txtCadastro4.Enabled == false & txtCadastro5.Enabled == false
& txtCadastro6.Enabled == false & txtCadastro8.Enabled == false)
            {
                vitoria = "Vitória do Jogador \n" + txtCadastro1.Text;
                h.label1.Text = vitoria;
                h.ShowDialog();
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textBox1.Text)<0) {
                textBox1.Text = "0";   
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadastro1_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged (sender, e);

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }


        }

        public void button18_Click(object sender, EventArgs e)
        {
            frmCadastro f = new frmCadastro();
            f.txtCadastro1.Text = txtCadastro1.Text;
            f.txtCadastro2.Text = txtCadastro2.Text;
            f.txtCadastro3.Text = txtCadastro3.Text;
            f.txtCadastro4.Text = txtCadastro4.Text;
            f.txtCadastro5.Text = txtCadastro5.Text;
            f.txtCadastro6.Text = txtCadastro6.Text;
            f.txtCadastro7.Text = txtCadastro7.Text;
            f.txtCadastro8.Text = txtCadastro8.Text;
            this.Hide();
            f.ShowDialog();
            

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int box1 = Convert.ToInt32(textBox1.Text);
            if (String.IsNullOrEmpty(txtCadastro1.Text) ||box1 !=0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box11 = Convert.ToInt32(textBox11.Text) + 1;


                if (box2 < minimo & box2 !=0)
                {
                    minimo = box2;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox11.Text = Convert.ToString(box11); //quantidade de re-entrada
                textBox1.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro1.Enabled = true;
            }
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro2_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro2.TabStop = false;
        }

        private void txtCadastro3_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro3.TabStop = false;
        }

        private void txtCadastro4_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro4.TabStop = false;
        }

        private void txtCadastro5_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro5.TabStop = false;
        }

        private void txtCadastro6_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro6.TabStop = false;
        }

        private void txtCadastro8_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
            txtCadastro8.TabStop = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int box2 = Convert.ToInt32(textBox2.Text);
            if (String.IsNullOrEmpty(txtCadastro2.Text) || box2 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box12 = Convert.ToInt32(textBox12.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox12.Text = Convert.ToString(box12); //quantidade de re-entrada
                textBox2.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro2.Enabled = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int box3 = Convert.ToInt32(textBox3.Text);
            if (String.IsNullOrEmpty(txtCadastro3.Text) || box3 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box13 = Convert.ToInt32(textBox13.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox13.Text = Convert.ToString(box13); //quantidade de re-entrada
                textBox3.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro3.Enabled = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int box4 = Convert.ToInt32(textBox4.Text);
            if (String.IsNullOrEmpty(txtCadastro4.Text) || box4 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box14 = Convert.ToInt32(textBox14.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox14.Text = Convert.ToString(box14); //quantidade de re-entrada
                textBox4.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro4.Enabled = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int box5 = Convert.ToInt32(textBox5.Text);
            if (String.IsNullOrEmpty(txtCadastro5.Text) || box5 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box15 = Convert.ToInt32(textBox15.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox15.Text = Convert.ToString(box15); //quantidade de re-entrada
                textBox5.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro5.Enabled = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int box6 = Convert.ToInt32(textBox6.Text);
            if (String.IsNullOrEmpty(txtCadastro6.Text) || box6 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box16 = Convert.ToInt32(textBox16.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox16.Text = Convert.ToString(box16); //quantidade de re-entrada
                textBox6.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro6.Enabled = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int box7 = Convert.ToInt32(textBox7.Text);
            if (String.IsNullOrEmpty(txtCadastro7.Text) || box7 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box17 = Convert.ToInt32(textBox17.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box8 < minimo & box8 != 0)
                {
                    minimo = box8;
                }

                textBox17.Text = Convert.ToString(box17); //quantidade de re-entrada
                textBox7.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro7.Enabled = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int box8 = Convert.ToInt32(textBox8.Text);
            if (String.IsNullOrEmpty(txtCadastro8.Text) || box8 != 0)
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);

                int box18 = Convert.ToInt32(textBox18.Text) + 1;


                if (box1 < minimo & box1 != 0)
                {
                    minimo = box1;
                }

                if (box2 < minimo & box2 != 0)
                {
                    minimo = box2;
                }

                if (box4 < minimo & box4 != 0)
                {
                    minimo = box4;
                }

                if (box3 < minimo & box3 != 0)
                {
                    minimo = box3;
                }

                if (box5 < minimo & box5 != 0)
                {
                    minimo = box5;
                }

                if (box6 < minimo & box6 != 0)
                {
                    minimo = box6;
                }

                if (box7 < minimo & box7 != 0)
                {
                    minimo = box7;
                }

                textBox18.Text = Convert.ToString(box18); //quantidade de re-entrada
                textBox8.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
                textBox10_TextChanged(sender, e);
                txtCadastro8.Enabled = true;
            }
        }

            //jogador 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado = c;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado = d;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado = v;
            }
        }
            //jogador 2
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado1 = c;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado1 = d;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado1 = v;
            }
        }
        //jogador 3
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado2 = c;
            }
    }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
             RadioButton d = (RadioButton)sender;
             if (d.Checked)
             {
                 rbnSelecionado2 = d;
             }
}

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado2 = v;
            }
        }
            // jogador 4
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado3 = c;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado3 = d;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado3 = v;
            }
        }
            // jogador 5

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado4 = c;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado4 = d;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado4 = v;
            }
        }

        //jogador 6
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado5 = c;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado5 = d;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado5 = v;
            }
        }

        //jogador 7
        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado6 = c;
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado6 = d;
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado6 = v;
            }
        }

        //jogador 8
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                rbnSelecionado7 = c;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton d = (RadioButton)sender;
            if (d.Checked)
            {
                rbnSelecionado7 = d;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton v = (RadioButton)sender;
            if (v.Checked)
            {
                rbnSelecionado7 = v;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox21.Text = ("Hora: " + DateTime.Now.ToString("HH:mm"));
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int jogadores = 0;

             // Inicialização dos TextBox dos pontos
            textBox1.Text = textBox22.Text;
            textBox2.Text = textBox22.Text;
            textBox3.Text = textBox22.Text;
            textBox4.Text = textBox22.Text;
            textBox5.Text = textBox22.Text;
            textBox6.Text = textBox22.Text;
            textBox7.Text = textBox22.Text;
            textBox8.Text = textBox22.Text;


            //bloqueando textbox


            if (string.IsNullOrEmpty(txtCadastro1.Text))
            {
                textBox1.Enabled = false;
                groupBox4.Enabled = false;
                button1.Enabled = false;
                checkBox1.Enabled = false;
                txtCadastro1.Enabled = false;
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Enabled = false;
                groupBox4.Enabled = true;
                button1.Enabled = true;
                jogadores++;

            }

            if (string.IsNullOrEmpty(txtCadastro2.Text))
            {
                textBox2.Enabled = false;
                groupBox5.Enabled = false;
                button19.Enabled = false;
                checkBox2.Enabled = false;
                txtCadastro2.Enabled = false;
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Enabled = false;
                groupBox5.Enabled = true;
                button19.Enabled = true;
                jogadores++;
            }
          
            if (string.IsNullOrEmpty(txtCadastro3.Text))
            {
                textBox3.Enabled = false;
                groupBox6.Enabled = false;
                button21.Enabled = false;
                checkBox3.Enabled = false;
                txtCadastro3.Enabled = false;
                textBox3.Text = "0";
            }
            else
            {
                textBox3.Enabled = false;
                groupBox6.Enabled = true;
                button21.Enabled = true;
                jogadores++;
            }

            if (string.IsNullOrEmpty(txtCadastro4.Text))
            {
                textBox4.Enabled = false;
                groupBox7.Enabled = false;
                button20.Enabled = false;
                checkBox4.Enabled = false;
                txtCadastro4.Enabled = false;
                textBox4.Text = "0";
            }
            else
            {
                textBox4.Enabled = false;
                groupBox7.Enabled = true;
                button20.Enabled = true;
                jogadores++;
            }

            if (string.IsNullOrEmpty(txtCadastro5.Text))
            {
                textBox5.Enabled = false;
                groupBox8.Enabled = false;
                button23.Enabled = false;
                checkBox5.Enabled = false;
                txtCadastro5.Enabled = false;
                textBox5.Text = "0";
            }
            else
            {
                textBox5.Enabled = false;
                groupBox8.Enabled = true;
                button23.Enabled = true;
                jogadores++;
            }

            if (string.IsNullOrEmpty(txtCadastro6.Text))
            {
                textBox6.Enabled = false;
                groupBox9.Enabled = false;
                button22.Enabled = false;
                checkBox6.Enabled = false;
                txtCadastro6.Enabled = false;
                textBox6.Text = "0";
            }
            else
            {
                textBox6.Enabled = false;
                groupBox9.Enabled = true;
                button22.Enabled = true;
                jogadores++;
            }

            if (string.IsNullOrEmpty(txtCadastro7.Text))
            {
                textBox7.Enabled = false;
                groupBox10.Enabled = false;
                button25.Enabled = false;
                checkBox7.Enabled = false;
                txtCadastro7.Enabled = false;
                textBox7.Text = "0";
            }
            else
            {
                textBox7.Enabled = false;
                groupBox10.Enabled = true;
                button25.Enabled = true;
                jogadores++;
            }

            if (string.IsNullOrEmpty(txtCadastro8.Text))
            {
                textBox8.Enabled = false;
                groupBox2.Enabled = false;
                button24.Enabled = false;
                checkBox8.Enabled = false;
                txtCadastro8.Enabled = false;
                textBox8.Text = "0";
            }
            else
            {
                textBox8.Enabled = false;
                groupBox2.Enabled = true;
                button24.Enabled = true;
                jogadores++;
            }

          
            if (jogadores < 2)
            {
                MessageBox.Show("No minimo 2 jogadores, Não esquece de definir os pontos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                groupBox1.Enabled = true;
                //escondendo picture box pontos
                pictureBox4.Hide();
                textBox22.Hide();
                label18.Hide();

                //ajustando localização aposta e total
                pictureBox2.Location = new Point(2, 488);
                pictureBox3.Location = new Point(155, 488);
                label13.Location = new Point(84, 485);
                label12.Location = new Point(235, 485);
                textBox10.Location = new Point(87, 510);
                textBox9.Location = new Point(238, 510);

                label17.Hide();
                //escondendo button
                button2.Hide();

                //redimensionando frmCadastro
                this.Height = 645;


                //liberando button

                button28.Enabled = true;
                button18.Enabled = true;
                button26.Enabled = true;

                //liberando labbel
                label1.Enabled = true;
                label15.Enabled = true;
                label11.Enabled = true;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
