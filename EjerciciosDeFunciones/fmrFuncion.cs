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
    public partial class fmrFuncion : Form
    {
        public fmrFuncion()
        {
            InitializeComponent();
        }

        private void fmrFuncion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int contador = cuenta_letra(this.txtFrase.Text, "a");
            this.txtResultado.Text = contador.ToString();
        }
        /// <summary>
        /// Cuenta la cantidad de 'a' que tiene una frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        private int cuenta_letra(string frase, string letra)
        {
            int cont = 0;
            for(int i=0; i<frase.Length; i++)
            {
                if (frase[i].ToString() .ToLower() == letra.ToLower())
                    cont++;

            }
            return cont;

        }

    }
}
