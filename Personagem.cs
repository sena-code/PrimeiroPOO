namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome = "RiriWilliams";

        public int idade = 18;

        public string frase = "Suprise Bicth";

        public string armadura;

        public int Atacar(int forca, int potencia){

            return forca * potencia;
        }

        public string Defesa(){

            return "O personagem defendeu.";
        }
        

    }
}