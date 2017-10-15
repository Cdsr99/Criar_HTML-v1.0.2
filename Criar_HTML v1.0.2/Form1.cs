using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criar_HTML_v1._0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            atributos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region diretório
        public void diretorio()
        {

            String name;
            name = html_name.Text;
            String caminho = @"C:\Windows\Temp\Criador_pasta03.bat";
            String caminho02 = comboBox1.Text;
            String caminho_padrao = @"C:\Users\Cdsr99\Google Drive\Programas\HTML\Practice";
            if (comboBox1.Text == "Cdsr99")
            {
                comboBox1.Text = caminho_padrao;
            }

            StreamWriter pasta = new StreamWriter(caminho);
            pasta.WriteLine("c:");
            pasta.WriteLine("cd " + comboBox1.Text);
            pasta.WriteLine("md " + name);
            //pasta.WriteLine("pause");
            pasta.Close();

            Process chamar = new Process();
            chamar.StartInfo.FileName = caminho;
            chamar.Start();

        }
        #endregion

        #region Criar arquivos
        #region HTML
        public void html()
        {
            // html_name = "";
            String name = html_name.Text;
            String caminho = comboBox1.Text + "\\" + name + "\\" + name + ".html";
           

            if (comboBox1.Text == "Cdsr99")
            {
                caminho = @"C:\Users\Cdsr99\Google Drive\Programas\HTML\Practice\\"+ name +"\\" + name +".html";
            }

            MessageBox.Show(caminho);
            try
            {
                StreamWriter conteudo = new StreamWriter(caminho);
                conteudo.WriteLine("<!DOCTYPE html>");
                conteudo.WriteLine("<html>");
                conteudo.WriteLine("<head>");
                conteudo.WriteLine("	<title>Cdsr99</title>");
                conteudo.WriteLine("</head>");
                conteudo.WriteLine("<body>");
                conteudo.WriteLine("");
                conteudo.WriteLine("</body>");
                conteudo.WriteLine("</html>");

                conteudo.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, put an way valid", "Erro");
            }

        }

        #endregion

        #region CSS
        public void Css()
        {
            String caminho = comboBox1.Text +"\\"+ html_name.Text + "\\estilo.css";
            if (comboBox1.Text == "Cdsr99")
            {
                caminho = @"C:\Users\Cdsr99\Google Drive\Programas\HTML\Practice\\" + html_name.Text +"\\"+ "estilo.css";
            }
            StreamWriter conteudocss = new StreamWriter(caminho);
            conteudocss.Close();
        }
        #endregion

        #region js
        public void Js()
        {
            String caminho = comboBox1.Text + "\\" + html_name.Text + "\\script.js";
            if (comboBox1.Text == "Cdsr99")
            {
                caminho = @"C:\Users\Cdsr99\Google Drive\Programas\HTML\Practice\\script.js";
            }
            StreamWriter conteudojs = new StreamWriter(caminho);
            conteudojs.Close();
        }
        #endregion
        #endregion

        #region atributos
        public void atributos()
        {
            string users = System.Environment.GetEnvironmentVariable("USERNAME");
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("C:\\Users\\" + users + "\\Desktop");
            comboBox1.Items.Add("C:\\Users\\" + users + "\\Documents");
        //C: \Users\Cdsr99\Desktop
        }
        #endregion

        #region Condição
        public void Condição()
        {
            if (css.Checked && js.Checked)
            {
                Css();
                Js();
            }
            else if (css.Checked)
            {
                Css();
            }
            else if (js.Checked)
            {
                Js();
            }
        }


        #endregion

        #region botão
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && html_name.Text == "")
            {
                MessageBox.Show("Please, put the way and the html name.");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please, put the way!");
            }
            else if (html_name.Text == "")
            {
                MessageBox.Show("Please, put the html name!");
            }
            else
            {
                diretorio();
                System.Threading.Thread.Sleep(5090);
                html();
                Condição();
            }

        }
        
        #region botão Design

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void pinkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the colors above are to change program color");
        }
        #endregion

        #region botão Letter

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }
        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ForeColor = Color.ForestGreen;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Pink;
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The colors above are to change the color of letter ");
        }
        #endregion

        #region add/attrib
        private void addAttribToolStripMenuItem_Click(object sender, EventArgs e)
        {
            css.Checked = true;
            js.Checked = true;
        }


        #endregion

        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String caminho = @"C:\Windows\Temp\html.html";

            StreamWriter conteudo = new StreamWriter(caminho);

            conteudo.WriteLine("<!DOCTYPE html>");
            conteudo.WriteLine("<html>");
            conteudo.WriteLine("<head>");
            conteudo.WriteLine("	<title>About</title>");
            conteudo.WriteLine("</head>");
            conteudo.WriteLine("<body>");
            conteudo.WriteLine("<center>");
            conteudo.WriteLine(@"<img src = ""C:\Users\Cdsr99\Google Drive\Google Fotos\2017\Snapchat-1999095595.jpg""><br>");
            conteudo.WriteLine("<br>");
            conteudo.WriteLine("This program is to help the people to create your webpage, people that create very page with this program you can create your project with more easy.");
            conteudo.WriteLine("</center>");
            conteudo.WriteLine("</body>");
            conteudo.WriteLine("</html>");

            conteudo.Close();
            try
            {
                Process chamar = new Process();
                chamar.StartInfo.FileName = @"C:\Windows\Temp\html.html";
            }
            catch (Exception)
            {

                MessageBox.Show("Erro, don't exit this file");
            }


            
        }
    }
}
