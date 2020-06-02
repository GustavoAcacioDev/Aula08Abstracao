namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string Transferir(float valor){
            return "Transferência efetuada";
        }
        public string PagarTitulo(){
            return "Titulo pago";
        }
    }
}