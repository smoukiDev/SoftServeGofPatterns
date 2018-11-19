using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(5, 10);
            GameHistory game = new GameHistory();
            hero.Shoot();// 9
            game.History.Push(hero.SaveState());
            hero.Shoot();// 8
            hero.RestoreState(game.History.Pop());
            hero.Shoot(); // 8
            Console.ReadLine();
        }
    }
}
