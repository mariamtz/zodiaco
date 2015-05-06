using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormSigno.SRSigno;

namespace FormSigno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SRSigno.HoroscoposSoapClient sz = new HoroscoposSoapClient();
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtDia.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(sz.Signos(int.Parse(txtDia.Text), cmbMes.SelectedIndex), "Tu fecha corresponde a:", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));

                }

            }
            else {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }

        }
    }
}
