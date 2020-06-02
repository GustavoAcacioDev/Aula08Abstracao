namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "jkashfwiueshr8934fdiuosjfa89corw28ur290jaslfa0f";
        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }   
}