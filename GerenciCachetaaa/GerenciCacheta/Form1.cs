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
        int reentrada = 1;
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

            textBox20.Text = "Data: " + DateTime.Now.ToString("dd-MM-y");
            textBox21.Text = "Hora: " + DateTime.Now.ToString("HH:mm");        }
  
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
            textBox10_TextChanged(sender, e);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
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

            int total = reentrada * a;
            jogadores = (jogadores - vazio) * total;

            textBox9.Text = Convert.ToString(jogadores);
            reentrada = 1;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://icon-icons.com/pt/icone/plus-adicionar-insira/36851
            //https://icon-icons.com/pt/icone/adicionar-inserir-novo-al%C3%A9m-disso-acrescentar/77928
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

            //Salvando arquivos do listbox em um txt
            ListBox mylist = new ListBox();

            mylist.Items.Add("Teste");

            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in mylist.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Rodada Salva no Histórico!");
            // Ler o que está abaixo para fazer o processo inverso e ou mudar o de cima
            //https://pablobatistacardoso.wordpress.com/2012/12/15/ler-aquivo-txt-e-armazenar-em-um-list-c/

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
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

        private void button18_Click(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {

                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box11 = Convert.ToInt32(textBox11.Text) + 1;


                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox11.Text = Convert.ToString(box11); //quantidade de re-entrada
                textBox1.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo

            }
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro2_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro3_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro4_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro5_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro6_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void txtCadastro8_TextChanged(object sender, EventArgs e)
        {
            textBox10_TextChanged(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box12 = Convert.ToInt32(textBox12.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }


                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox12.Text = Convert.ToString(box12); //quantidade de re-entrada
                textBox2.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box13 = Convert.ToInt32(textBox13.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }



                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox13.Text = Convert.ToString(box13); //quantidade de re-entrada
                textBox3.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box14 = Convert.ToInt32(textBox14.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox14.Text = Convert.ToString(box14); //quantidade de re-entrada
                textBox4.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box15 = Convert.ToInt32(textBox15.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }



                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox15.Text = Convert.ToString(box15); //quantidade de re-entrada
                textBox5.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box16 = Convert.ToInt32(textBox16.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox16.Text = Convert.ToString(box16); //quantidade de re-entrada
                textBox6.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box17 = Convert.ToInt32(textBox17.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }



                if (box7 < minimo)
                {
                    minimo = box7;
                }

                if (box8 < minimo)
                {
                    minimo = box8;
                }

                textBox17.Text = Convert.ToString(box17); //quantidade de re-entrada
                textBox7.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCadastro1.Text))
            { }
            else
            {
                reentrada++;
                int minimo = 10;
                int box1 = Convert.ToInt32(textBox1.Text);
                int box2 = Convert.ToInt32(textBox2.Text);
                int box3 = Convert.ToInt32(textBox3.Text);
                int box4 = Convert.ToInt32(textBox4.Text);
                int box5 = Convert.ToInt32(textBox5.Text);
                int box6 = Convert.ToInt32(textBox6.Text);
                int box7 = Convert.ToInt32(textBox7.Text);
                int box8 = Convert.ToInt32(textBox8.Text);

                int box18 = Convert.ToInt32(textBox18.Text) + 1;


                if (box1 < minimo)
                {
                    minimo = box1;
                }

                if (box2 < minimo)
                {
                    minimo = box2;
                }

                if (box3 < minimo)
                {
                    minimo = box3;
                }

                if (box4 < minimo)
                {
                    minimo = box4;
                }

                if (box5 < minimo)
                {
                    minimo = box5;
                }

                if (box6 < minimo)
                {
                    minimo = box6;
                }

                if (box7 < minimo)
                {
                    minimo = box7;
                }



                textBox18.Text = Convert.ToString(box18); //quantidade de re-entrada
                textBox8.Text = Convert.ToString(minimo); //definindo valor de retorno ao jogo
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox21_ModifiedChanged(object sender, EventArgs e)
        {
  
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox21.Text = ("Hora: " + DateTime.Now.ToString("HH:mm"));
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
