namespace Aula71
{
    public class Pensionato
    {
        string Nome{get; set;}
        string Email{get;set;}
        public Pensionato(string nome, string email){
            Nome = nome;
            Email = email;
        }
        public override string ToString(){
            return Nome + ", " + Email;
        } 
    }
}