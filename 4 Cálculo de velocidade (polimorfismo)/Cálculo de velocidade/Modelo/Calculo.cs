using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_velocidade.Modelo
{
    public class Calculo: absPropriedades
    {
        public Calculo(Double valorDistancia, Double valorTempo): base(valorDistancia, valorTempo)
        {
            Executar();
        }

        public override void Executar()
        {
            this.resposta = "A velocidade é de: \n" + (valorDistancia / (valorTempo)).ToString("0.##") + " km/h"; 
        }
    }
}
