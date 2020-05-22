using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem RiriWilliams = new Personagem();
            RiriWilliams.armadura = "IronHeart";
            int forcatotal = RiriWilliams.Atacar(40, 15);
            RiriWilliams.Defesa();

            Personagem2 SuperGirl = new Personagem2();
            SuperGirl.armadura = "BlackWall";
            int forcatotal2 = SuperGirl.ContraAtacar(50, 80);
            SuperGirl.Defesa2();

                Console.WriteLine(RiriWilliams.nome);

             Console.WriteLine(RiriWilliams.idade);

             Console.WriteLine(RiriWilliams.frase);

             Console.WriteLine( "Riri deu " + forcatotal + " de dano");

             Console.WriteLine(SuperGirl.nome);

             Console.WriteLine(SuperGirl.idade);

             Console.WriteLine(SuperGirl.Defesa2());

             Console.WriteLine(SuperGirl.frase2);

             Console.WriteLine( "SuperGirl retornou " + forcatotal2 + " de dano");








        }
    }
}
