using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLFA.Classes;
namespace ProyectoLFA
{
    public partial class FileAnalyser : Form
    {
        public FileAnalyser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                AnalizarArchivo(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show(@"Error al leer el archivo.");
            }
        }
            private void AnalizarArchivo(string file)
            {
                TXTPath.Text = file;
                RTBGrammar.Select(0, RTBGrammar.Lines.Length);
                RTBGrammar.SelectionColor = Color.Black;

                try
                {
                    int line1 = 0;
                    string text = File.ReadAllText(file);
                    //Send line
                    TResult.Text = Classes.GrammarFormat.AnalyseFile(text, ref line1);
                    RTBGrammar.Text = text;

                if (TResult.Text.Contains("Correcto"))
                    {
                        TResult.BackColor = Color.LightGray;
                        TResult.ForeColor = Color.Green;

                    }
                    else
                    {
                        TResult.BackColor = Color.LightGray;
                        TResult.ForeColor = Color.Crimson;

                        //Ubicacion del error
                        int lineCounter = 0;

                        foreach (string line in RTBGrammar.Lines)
                        {
                            if (line1 - 1 == lineCounter)
                            {
                                RTBGrammar.Select(RTBGrammar.GetFirstCharIndexFromLine(lineCounter), line.Length);
                                RTBGrammar.SelectionColor = Color.Red;
                            }
                            lineCounter++;
                        }
                    }

                }
                catch (Exception ex)
                {

                    TResult.BackColor = Color.LightGray;
                    TResult.ForeColor = Color.Crimson;
                    TResult.Text = @"Error en TOKENS";
                    MessageBox.Show(ex.Message);

                    //Show in red all lines in tokens
                    int lineCounter = 0;

                    foreach (string line in RTBGrammar.Lines)
                    {
                        if (line.Contains("TOKEN"))
                        {
                            RTBGrammar.Select(RTBGrammar.GetFirstCharIndexFromLine(lineCounter), line.Length);
                            RTBGrammar.SelectionColor = Color.Red;
                        }
                        lineCounter++;
                    }
                }
            }

        private void TResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTBGrammar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();

            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

