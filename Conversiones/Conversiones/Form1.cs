using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones
{
    public partial class Form1 : Form
    {
        Formula objconversiones = new Formula();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtsolucion.Text = "Valor: " + objconversiones+(cmbde.SelectedIndex, cmba.SelectedIndex, double.Parse(txtsolucion.Text)) + " " + objconversiones.etiquetas[cmba.SelectedIndex];
            }

            catch (Exception error)
            {
                    MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbde.Items.Clear();
                cmba.Items.Clear();
                cmbde.Items.AddRange(objconversiones.etiquetas);
                cmba.Items.AddRange(objconversiones.etiquetas);
                txtsolucion.Text = "Convertidor de " + objconversiones;
                cmbde.SelectedIndex = 0;
                cmba.SelectedIndex = 1;
                txtsolucion.Text = "?";
                txtcantidad.Text = "1";
            }
        }
    }

