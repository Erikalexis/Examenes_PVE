using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_monedas
{
    public partial class Form1 : Form
    {
        public Conversor Monedas = new Conversor(); 
        public Form1()
        {
            InitializeComponent();
            this.Monedas = new Conversor();
        }

        private void MonedaAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            this.Monedas.Monto = double.Parse(this.Monto.Text);
            switch (MonedaAC.SelectedIndex)
            {
                case 0:
                    this.DolarCon.Text = "";

                    double ConversionPeso = this.Monedas.Monto * 20.25;
                    this.PesoCon.Text = ConversionPeso.ToString();

                    double ConversionDolarcan = this.Monedas.Monto * 1.36;
                    this.DolarCanCon.Text = ConversionDolarcan.ToString();

                    double ConversionEuro = this.Monedas.Monto * 1.03;
                    this.EuroCon.Text = ConversionEuro.ToString();

                    double ConversionYen = this.Monedas.Monto * 144.33;
                    this.YenCon.Text = ConversionYen.ToString();                   
                    break;

                case 1:
                    this.PesoCon.Text = "";

                    double ConversionDolar = this.Monedas.Monto * 0.05;
                    this.DolarCon.Text = ConversionDolar.ToString();

                    ConversionDolarcan = this.Monedas.Monto * 0.07;
                    this.DolarCanCon.Text = ConversionDolarcan.ToString();

                    ConversionEuro = this.Monedas.Monto * 0.05;
                    this.EuroCon.Text = ConversionEuro.ToString();

                    ConversionYen = this.Monedas.Monto * 7.13;
                    this.YenCon.Text = ConversionYen.ToString();
                    break;

                case 2:
                    this.DolarCanCon.Text = "";

                    ConversionDolar = this.Monedas.Monto * 0.73;
                    this.DolarCon.Text = ConversionDolar.ToString();

                    ConversionPeso = this.Monedas.Monto * 14.84;
                    this.PesoCon.Text = ConversionPeso.ToString();

                    ConversionEuro = this.Monedas.Monto * 0.76;
                    this.EuroCon.Text = ConversionEuro.ToString();

                    ConversionYen = this.Monedas.Monto * 105.74;
                    this.YenCon.Text = ConversionYen.ToString();
                    break;
                 
                case 3:
                    this.EuroCon.Text = "";

                    ConversionDolar = this.Monedas.Monto * 0.97;
                    this.DolarCon.Text = ConversionDolar.ToString();

                    ConversionPeso = this.Monedas.Monto * 19.62;
                    this.PesoCon.Text = ConversionPeso.ToString();

                    ConversionDolarcan = this.Monedas.Monto * 1.32;
                    this.DolarCanCon.Text = ConversionDolarcan.ToString();

                    ConversionYen = this.Monedas.Monto * 139.89;
                    this.YenCon.Text = ConversionYen.ToString();
                    break;
                    
                case 4:
                    this.YenCon.Text = "";

                    ConversionDolar = this.Monedas.Monto * 0.01;
                    this.DolarCon.Text = ConversionDolar.ToString();

                    ConversionPeso = this.Monedas.Monto * 0.14;
                    this.PesoCon.Text = ConversionPeso.ToString();

                    ConversionDolarcan = this.Monedas.Monto * 0.1;
                    this.DolarCanCon.Text = ConversionDolarcan.ToString();

                    ConversionEuro = this.Monedas.Monto * 0.1;
                    this.EuroCon.Text = ConversionEuro.ToString();
                    break;

            }
        }
    }
}
