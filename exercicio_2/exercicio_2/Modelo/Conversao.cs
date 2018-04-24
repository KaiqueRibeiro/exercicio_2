using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2.Modelo
{
    public class Conversao : absPropriedades, intMetodos
    {

        public Conversao(String tipo, Double temperatura)
            : base(tipo, temperatura)
        {
            Executar();
        }

        public void Executar()
        {

            //C = F  * 1,8 + 32
            //F = (C – 32) / 1,8

            if (this.tipo.Equals("CF"))
            {
                this.temperatura = (this.temperatura - 32) / 1.8;
                this.resposta = this.temperatura.ToString();
            }
            if(this.tipo.Equals("FC"))
            {
                this.temperatura = this.temperatura * 1.8 + 32;
                this.resposta = this.temperatura.ToString();
            }
        }
    }
}
