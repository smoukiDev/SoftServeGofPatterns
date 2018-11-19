using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Hero
    {
        private int patrons; 
        private int lives;

        public Hero(int lives, int patrons)
        {
            this.lives = lives;
            this.patrons = patrons;
        }

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine($"Hero has shot. {patrons} patrons last");
            }
            else
            {
                Console.WriteLine("Empty сage.");
            }
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine($"Save game. Parameters: {patrons} patrons, {lives} lives");
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine($"Restore game. Parameters: {patrons} patrons, {lives} lives");
        }
    }
}
