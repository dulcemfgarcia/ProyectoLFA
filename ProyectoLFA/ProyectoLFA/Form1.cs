using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLFA.Utilities.DFA_Procedures;
using Action = ProyectoLFA.Utilities.DFA_Procedures.Action;
namespace ProyectoLFA
{
    public partial class Form1 : Form
    {
        public Form1()
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
               
               
                pathTextBox.Text = file;

                //Return to default color
                RTBGrammar.Select(0, RTBGrammar.Lines.Length);
            RTBGrammar.SelectionColor = Color.Black;

                try
                {

                    int linea = 0;
              string text = File.ReadAllText(file);
                TResult.Text = Utilities.AnalizarGramatica.analizarAchivoGramatica(text, ref linea);
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
                            if (linea - 1 == lineCounter)
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
    }
    }

