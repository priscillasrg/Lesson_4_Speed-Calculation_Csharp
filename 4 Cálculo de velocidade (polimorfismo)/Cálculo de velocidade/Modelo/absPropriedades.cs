    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_velocidade.Modelo
{
   public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        public String resposta;
        public String distancia;
        public String tempo;
        public Double valorDistancia;
        public Double valorTempo;
        

        public absPropriedades(String distancia, String tempo)
        {
            this.distancia = distancia;
            this.tempo = tempo;
        }

        public absPropriedades(Double valorDistancia, Double valorTempo)
        {
            this.valorDistancia = valorDistancia;
            this.valorTempo = valorTempo;
        }
        
        public virtual void Executar ()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }
    }
}
