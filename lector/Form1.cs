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
using System.Text.RegularExpressions;

namespace lector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto(.txt)|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                int contcaracteres = 0;
                int contpalabras = 0;
                int contvocales = 0;
                int contconsonantes = 0;
                int contespacios = 0;
                int contabulador = 0;

             

                txtRuta.Text = abrir.FileName;
                ruta = txtRuta.Text;
                txtTexto.Text = System.IO.File.ReadAllText(ruta);

                for (int i = 0; i < txtTexto.Text.Length; i++)
                {
                    switch (txtTexto.Text[i])
                    {
                        case 'a':
                            contvocales++;
                            break;
                        case 'e':
                            contvocales++;
                            break;
                        case 'i':
                            contvocales++;
                            break;
                        case 'o':
                            contvocales++;
                            break;
                        case 'u':
                            contvocales++;
                            break;
                        case 'á':
                            contvocales++;
                            break;
                        case 'ó':
                            contvocales++;
                            break;
                        case ' ':
                            contespacios++;
                            contpalabras++;
                            break;
                        case '\t':
                            contabulador++;
                            break;
                        default:
                            contconsonantes++;
                            break;
                    }
                }
                contpalabras++;
                contpalabras++;
                contpalabras = contpalabras + contabulador;
                contconsonantes = contconsonantes - txtTexto.Lines.Count();
                contcaracteres = contcaracteres - txtTexto.Lines.Count();
                contcaracteres = (contcaracteres + txtTexto.Text.Length) - contespacios-contabulador;
                lblCaracteres.Text = contcaracteres.ToString().Trim().Replace(" ", "");

                lblVocales.Text = contvocales.ToString();
                lblConsonantes.Text = contconsonantes.ToString();
                lblEspacios.Text = contespacios.ToString();
                lblPalabras.Text = contpalabras.ToString();
                lblLineas.Text = txtTexto.Lines.Count().ToString();
                lblTab.Text = contabulador.ToString();

                if (contcaracteres == 0)
                {
                    lblPalabras.Text = "0";
                    lblLineas.Text = "0";
                }
            }
        }
                         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtTexto.Multiline = true;
            txtTexto.ReadOnly = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            if (cboQuitar.Text == "Espacios en blanco")
            {
                txtTexto.Text = txtTexto.Text.Replace(" ", "");
                txtTexto.Text = txtTexto.Text.Replace("\t", "");

                int contcaracteres = 0;
                int contpalabras = 0;
                int contvocales = 0;
                int contconsonantes = 0;
                int contespacios = 0;
                int contabulador = 0;

                for (int i = 0; i < txtTexto.Text.Length; i++)
                {
                    switch (txtTexto.Text[i])
                    {
                        case 'a':
                            contvocales++;
                            break;
                        case 'e':
                            contvocales++;
                            break;
                        case 'i':
                            contvocales++;
                            break;
                        case 'o':
                            contvocales++;
                            break;
                        case 'u':
                            contvocales++;
                            break;
                        case 'á':
                            contvocales++;
                            break;
                        case 'ó':
                            contvocales++;
                            break;
                        case ' ':
                            contespacios++;
                            contpalabras++;
                            break;
                        case '\t':
                            contabulador++;
                            break;
                        default:
                            contconsonantes++;
                            break;
                    }
                }

                contpalabras++;
                contpalabras++;
                contpalabras = contpalabras + contabulador;
                contconsonantes = contconsonantes - txtTexto.Lines.Count();
                contcaracteres = contcaracteres - txtTexto.Lines.Count();
                contcaracteres = (contcaracteres + txtTexto.Text.Length) - contespacios - contabulador;
                lblCaracteres.Text = contcaracteres.ToString().Trim().Replace(" ", "");

                lblVocales.Text = contvocales.ToString();
                lblConsonantes.Text = contconsonantes.ToString();
                lblEspacios.Text = contespacios.ToString();
                lblPalabras.Text = contpalabras.ToString();
                lblLineas.Text = txtTexto.Lines.Count().ToString();
                lblTab.Text = contabulador.ToString();

                if (contcaracteres == 0)
                {
                    lblPalabras.Text = "0";
                    lblLineas.Text = "0";
                }
            }

            if (cboQuitar.Text == "Vocales")
            {
                txtTexto.Text = txtTexto.Text.ToLower().Replace("a", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("e", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("i", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("o", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("u", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("á", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("é", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("í", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("ó", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("ú", "");

                int contcaracteres = 0;
                int contpalabras = 0;
                int contvocales = 0;
                int contconsonantes = 0;
                int contespacios = 0;
                int contabulador = 0;

                for (int i = 0; i < txtTexto.Text.Length; i++)
                {
                    switch (txtTexto.Text[i])
                    {
                        case 'a':
                            contvocales++;
                            break;
                        case 'e':
                            contvocales++;
                            break;
                        case 'i':
                            contvocales++;
                            break;
                        case 'o':
                            contvocales++;
                            break;
                        case 'u':
                            contvocales++;
                            break;
                        case 'á':
                            contvocales++;
                            break;
                        case 'ó':
                            contvocales++;
                            break;
                        case ' ':
                            contespacios++;
                            contpalabras++;
                            break;
                        case '\t':
                            contabulador++;
                            break;
                        default:
                            contconsonantes++;
                            break;
                    }
                }

                contpalabras++;
                contpalabras++;
                contpalabras = contpalabras + contabulador;
                contconsonantes = contconsonantes - txtTexto.Lines.Count();
                contcaracteres = contcaracteres - txtTexto.Lines.Count();
                contcaracteres = (contcaracteres + txtTexto.Text.Length) - contespacios - contabulador;
                lblCaracteres.Text = contcaracteres.ToString().Trim().Replace(" ", "");

                lblVocales.Text = contvocales.ToString();
                lblConsonantes.Text = contconsonantes.ToString();
                lblEspacios.Text = contespacios.ToString();
                lblPalabras.Text = contpalabras.ToString();
                lblLineas.Text = txtTexto.Lines.Count().ToString();
                lblTab.Text = contabulador.ToString();

                if (contcaracteres == 0)
                {
                    lblPalabras.Text = "0";
                    lblLineas.Text = "0";
                }
            }

            if (cboQuitar.Text == "Consonantes")
            {
                txtTexto.Text = txtTexto.Text.ToLower().Replace("b", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("c", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("d", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("f", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("g", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("h", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("j", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("k", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("l", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("m", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("n", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("ñ", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("p", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("q", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("r", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("s", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("t", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("v", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("w", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("x", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("y", "");
                txtTexto.Text = txtTexto.Text.ToLower().Replace("z", "");

                int contcaracteres = 0;
                int contpalabras = 0;
                int contvocales = 0;
                int contconsonantes = 0;
                int contespacios = 0;
                int contabulador = 0;              
                

                for (int i = 0; i < txtTexto.Text.Length; i++)
                {
                    switch (txtTexto.Text.ToLower()[i])
                    {
                        case 'a':
                            contvocales++;
                            break;
                        case 'e':
                            contvocales++;
                            break;
                        case 'i':
                            contvocales++;
                            break;
                        case 'o':
                            contvocales++;
                            break;
                        case 'u':
                            contvocales++;
                            break;
                        case 'á':
                            contvocales++;
                            break;
                        case 'ó':
                            contvocales++;
                            break;
                        case ' ':
                            contespacios++;
                            contpalabras++;
                            break;
                        case '\t':
                            contabulador++;
                            break;
                        default:
                            contconsonantes++;
                            break;
                    }
                }

                contpalabras++;
                contpalabras++;
                contpalabras = contpalabras + contabulador;
                contconsonantes = contconsonantes - txtTexto.Lines.Count();
                contcaracteres = contcaracteres - txtTexto.Lines.Count();
                contcaracteres = (contcaracteres + txtTexto.Text.Length) - contespacios - contabulador;
                lblCaracteres.Text = contcaracteres.ToString().Trim().Replace(" ", "");

                lblVocales.Text = contvocales.ToString();
                lblConsonantes.Text = contconsonantes.ToString();
                lblEspacios.Text = contespacios.ToString();
                lblPalabras.Text = contpalabras.ToString();
                lblLineas.Text = txtTexto.Lines.Count().ToString();
                lblTab.Text = contabulador.ToString();
                
                if (contcaracteres == 0)
                {
                    lblPalabras.Text = "0";
                    lblLineas.Text = "0";
                }            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string contenidoGuardar = string.Empty;

            SaveFileDialog cuadroguardar = new SaveFileDialog();
            cuadroguardar.Filter = "Archivo de texto(.txt)|*.txt";        

            if (lblCaracteres.Text != "0")
            {
                if(cuadroguardar.ShowDialog() == DialogResult.OK)
                {
                    contenidoGuardar = txtTexto.Text;
                    StreamWriter guardar = File.CreateText(cuadroguardar.FileName);
                    guardar.Write(txtTexto.Text);
                    guardar.Flush();
                }
            }
            else
            {
                MessageBox.Show("No hay nada para guardar!", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void cboQuitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQuitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
