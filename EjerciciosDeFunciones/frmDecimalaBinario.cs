using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosDeFunciones
{
    public partial class frmDecimalaBinario : Form
    {
        public frmDecimalaBinario()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool esNumeroCorrecto = int.TryParse(this.txtNumero.Text, out int numero);
            if (!esNumeroCorrecto)
            {
                MessageBox.Show("Debe de ingresar un valor numerico.....");
                return;
            }
            if (!(numero > 0 && numero <= 255))
            {
                MessageBox.Show("Numero fuera de rango....");
                return;
            }

            int[] res = binario(numero);
            Console.WriteLine("Inicio");
            for (int i=res.Length-1; i>0; i--)
            {
                if(res[0] ==1)
                {
                    this.Control1.Checked = true;
                }
                else
                {
                    this.Control1.Checked = false;
                }
                if (res[1] == 1)
                {
                    this.Control2.Checked = true;
                }
                else
                {
                    this.Control2.Checked = false;
                }
                if (res[2] == 1)
                {
                    this.Control3.Checked = true;
                }
                else
                {
                    this.Control3.Checked = false;
                }
                if (res[3] == 1)
                {
                    this.Control4.Checked = true;
                }
                else
                {
                    this.Control4.Checked = false;
                }
                if (res[4] == 1)
                {
                    this.Control5.Checked = true;
                }
                else
                {
                    this.Control5.Checked = false;
                }
                if (res[5] == 1)
                {
                    this.Control6.Checked = true;
                }
                else
                {
                    this.Control6.Checked = false;
                }
                if (res[6] == 1)
                {
                    this.Control7.Checked = true;
                }
                else
                {
                    this.Control7.Checked = false;
                }
                if (res[7] == 1)
                {
                    this.Control8.Checked = true;
                }
                else
                {
                    this.Control8.Checked = false;
                }
                Console.WriteLine("{0}", res[i]);
            }
        }
        //Console.WriteLine("Fin");
        //this.checkBox1.Checked = true;

        private int[] binario(int num)
        {
            int[] bin = {0, 0, 0, 0, 0, 0, 0, 0};
            //int[] bin = new int[8]
            int i = 0;
            int resto = 0;
            while(num > 0)
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                //Console.WriteLine("{0}", resto);
            }
            return bin;
        }

        private void btnBinDec_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Control1.Checked) num += 1;
            if (Control2.Checked) num += 2;
            if (Control3.Checked) num += 3;
            if (Control4.Checked) num += 4;
            if (Control5.Checked) num += 5;
            if (Control6.Checked) num += 6;
            if (Control7.Checked) num += 7;
            if (Control8.Checked) num += 8;
            this.txtNumero.Text = num.ToString();

        }

        private void Control1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
