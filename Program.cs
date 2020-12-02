using System;

namespace atividades6
{
    class Program
    {
        static void Main(string[] args)
        {
            // jogadores e suas características
            personagem jogador1 = new personagem();
            jogador1.nome = "vitor";
            jogador1.idade = 17;
            jogador1.altura = 1.70;
            jogador1.peso = 70.60;
            jogador1.armadura = "Lex Luthor";
            jogador1.ia = "tecnologia Kryptoniana";

            personagem jogador2 = new personagem();
            jogador2.nome = "homem de ferro";
            jogador2.idade = 35;
            jogador2.altura = 1.65;
            jogador2.peso = 65.90;
            jogador2.armadura = "MK3";
            jogador2.ia = "Jarvis";

            // pré combate
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"combate: {jogador1.nome} VS {jogador2.nome}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"idade do jogador1: {jogador1.idade} || idade do jogador2:  {jogador2.idade}");
            Console.WriteLine($"altura do jogador1: {jogador1.altura} || peso do jogador2: {jogador2.altura}");
            Console.WriteLine($"peso do jogador1: {jogador1.peso} || peso do jogador2: {jogador2.peso}");
            Console.WriteLine($"armadura do jogador1: {jogador1.armadura} ||  do jogador2: {jogador2.armadura}");
            Console.WriteLine($"I.A do jogador1: {jogador1.ia} || I.A do jogador2: {jogador2.ia}");
            Console.ResetColor();

            // inicio de luta
            Console.ForegroundColor = ConsoleColor.Green;
            int VidaDoJogador2 = jogador2.defender(jogador1.ataque1());
            if(VidaDoJogador2 <= 0){
                Console.WriteLine($"o jogador morreu");
            }
            else{
                Console.WriteLine($"jogador 2 depois de receber um ataque ficou com {jogador2.vida} de vida");
            }
        }
    }
}
