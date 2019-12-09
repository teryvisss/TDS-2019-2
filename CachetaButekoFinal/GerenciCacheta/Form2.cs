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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader x;
            //abrindo um arquivo texto indicado
            x = File.OpenText("save.txt");

            while (x.EndOfStream != true)
            {
                //lendo conteúdo da linha do arquivo texto
                string linha = x.ReadLine();

                //escrevendo este conteúdo na tela
                //mais podemos salvar esse conteúdo em uma variável
                //do tipo string, para utilização no nosso código

                listBox1.Items.Add(linha);


            }
            //fecha arquivo texto
            x.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            File.WriteAllText("save.txt", string.Empty);
            listBox1.Items.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
