using System;

namespace Aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        
        public void AumentarLimite(float acrescimo){
            limite = limite + acrescimo;
        }

        public string Bloquear(){
            return "O cartão foi bloqueado";
        }

        
    }
}