using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_monedas
{
    public class Conversor
    {
        public double Monto { get; set; }
        public double Peso { get; set; }
        public double Dolar { get; set; }
        public double DolarCan { get; set; }
        public double Euro { get; set; }
        public double Yen { get; set; }
        public Conversor()
        {
            this.Monto = 0;
            this.Peso = 0;
            this.Dolar = 0;
            this.DolarCan = 0;
            this.Euro = 0;
            this.Yen = 0;
        }
        public Conversor(double Monto, double Peso, double Dolar, double DolarCan, double Euro, double Yen)
        {
            this.Monto = Monto;
            this.Peso = Peso;
            this.Dolar = Dolar;
            this.DolarCan = DolarCan;
            this.Euro = Euro;
            this.Yen = Yen;
        }
    }
}
