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
            cmbtipo.Items.AddRange(objconversiones.Tipo);
            cmbtipo.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtsolucion.Text = "Valor: " + objconversiones.convertir(cmbde.SelectedIndex, cmba.SelectedIndex, double.Parse(txtcantidad.Text), cmbtipo.SelectedIndex) + " " + objconversiones.etiquetas[cmbtipo.SelectedIndex][cmba.SelectedIndex];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbde.Items.Clear();
            cmba.Items.Clear();
            cmbde.Items.AddRange(objconversiones.etiquetas[cmbtipo.SelectedIndex]);
            cmba.Items.AddRange(objconversiones.etiquetas[cmbtipo.SelectedIndex]);
            txtsolucion.Text = "Convertidor de " + objconversiones.Tipo[cmbtipo.SelectedIndex];
            cmbde.SelectedIndex = 0;
            cmba.SelectedIndex = 1;
            txtsolucion.Text = "?";
            txtcantidad.Text = "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtcantidad.Text = " ";
            txtsolucion.Text = " ? ";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

