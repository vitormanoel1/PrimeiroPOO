using System;

namespace atividades6
{
    class personagem
    {
        public string nome;

        public int idade;

        public double altura;

        public double peso;

        public string armadura;

        public string ia;

        public int vida = 1000;

        public int ataque1(){
            Console.WriteLine("ataque1 luz solar!");
            return 250;
        }

        public int ataque2(){
            Console.WriteLine("ataque2 rochas venenosas!");
            return 500;
        }

        public int defender(int ataque){
            this.vida = this.vida - ataque;

            return this.vida = this.vida - ataque;
        }
    }
}