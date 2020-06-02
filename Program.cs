using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito( );
            visa.limite = 1200f;

            Console.WriteLine("Deseja aumentar seu limite? Quanto de acréscimo?");
            float acres = float.Parse( Console.ReadLine() );
            
            visa.AumentarLimite(acres);

            Console.WriteLine("Novo limite: R$ "+visa.limite);


            Console.WriteLine("Qual o valor do pagamento?");
            float valorPago = float.Parse( Console.ReadLine() );

            Console.WriteLine("O valor pago foi de : R$ "+valorPago);
            
        }
    }
}
