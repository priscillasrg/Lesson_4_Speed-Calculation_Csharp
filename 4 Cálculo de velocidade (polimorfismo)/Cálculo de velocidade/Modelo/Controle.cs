using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_velocidade.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String distancia, String tempo) : base(distancia, tempo)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.distancia, this.tempo);

            if(validacao.mensagem.Equals(""))
            {
                absPropriedades calculo = new Calculo(validacao.valorDistancia, validacao.valorTempo);
                this.resposta = calculo.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
