using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_velocidade.Modelo
{
   public class Validacao: absPropriedades
    {
        public Validacao(String distancia, String tempo): base (distancia, tempo)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.valorDistancia = Convert.ToDouble(this.distancia);
                this.valorTempo = Convert.ToDouble(this.tempo);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão";               
            }
        }
    }
}
