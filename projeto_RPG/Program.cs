using System;
using projeto_RPG.src.Entities;

namespace projeto_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando o personagem:
            Knight Hero = new Knight("Hero", 10, "Knight", 100, 100);
            Wizard Wizard = new Wizard("Wizard", 15, "Wizard", 150, 200);
            Character Enemy = new Character("Enemy", 5, "Thief", 50, 50);
            Console.Write(Wizard.Attack(1));
        }
    }
}