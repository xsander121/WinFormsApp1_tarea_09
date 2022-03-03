using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_generar_serie_Click(object sender, EventArgs e)
        {
            if (bttn_generar_serie.Text.Equals("Generar serie"))
            {
                if (!txtBx_pimer_numero.Text.Equals("") &&
                    !txtBx_segundo_numero.Text.Equals("") &&
                    !txtBx_tercer_numero.Text.Equals("") &&
                    !txtBx_tamaño.Text.Equals(""))
                {
                    txtBx_pimer_numero.Enabled = false;
                    txtBx_segundo_numero.Enabled = false;
                    txtBx_tercer_numero.Enabled = false;
                    txtBx_tamaño.Enabled = false;

                    bttn_generar_serie.Enabled = false;
                    bttn_generar_serie.Text = "Generando..";

                    int primer_numero = int.Parse(txtBx_pimer_numero.Text);
                    int segundo_numero = int.Parse(txtBx_segundo_numero.Text);
                    int tercer_numero = int.Parse(txtBx_tercer_numero.Text);
                    int tamaño = int.Parse(txtBx_tamaño.Text);

                    generar_serie(primer_numero, segundo_numero, tercer_numero, tamaño);

                    bttn_generar_serie.Enabled = true;
                    bttn_generar_serie.Text = "Clear";
                }
            }
            else {
                txtBx_pimer_numero.Enabled = true;
                txtBx_segundo_numero.Enabled = true;
                txtBx_tercer_numero.Enabled = true;
                txtBx_tamaño.Enabled = true;

                txtBx_pimer_numero.Text = "";
                txtBx_segundo_numero.Text = "";
                txtBx_tercer_numero.Text = "";
                txtBx_tamaño.Text = "";

                bttn_generar_serie.Enabled = true;
                bttn_generar_serie.Text = "Generar serie";

                txtBx_salida_serie.Text = "";
            }
        }

        private void generar_serie(int primer_numero, int segundo_numero, int tercer_numero, int tamaño) {
            txtBx_salida_serie.Text = "";
            int i = 1;
            int primer_numero_suma = 0;
            int tope = 0;
            while (i <= tamaño) {
                if (i <= tamaño) {
                    primer_numero_suma = primer_numero_suma + primer_numero;
                    mostrar_valor(i, tamaño, primer_numero_suma);
                    i++;
                }
                if (i <= tamaño) {
                    int segundo_numero_resta = primer_numero_suma - segundo_numero;
                    if (segundo_numero_resta >= 0)
                        mostrar_valor(i, tamaño, segundo_numero_resta);
                    else
                        mostrar_valor(i, tamaño, 0);
                    i++;
                }
                if (i <= tamaño) {
                    tope++;
                    mostrar_valor(i, tamaño, tope);
                    i++;
                }
            }
        }

        private void mostrar_valor(int i, int tamaño, int valor) {
            if (i != tamaño)
                txtBx_salida_serie.AppendText(valor.ToString() + ", ");
            else
                txtBx_salida_serie.AppendText(valor.ToString() + ". ");
        }

        private void txtBx_pimer_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_segundo_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_tercer_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_tamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_salida_serie_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
    }
}
