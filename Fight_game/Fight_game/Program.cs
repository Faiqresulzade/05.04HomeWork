using System;

namespace Fight_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player
            {
                Name = "Thor",
                AttackPower = 20,
                Health = 100
            };
            Enemy enemy = new Enemy
            {
                Name = "Goblin",
                Health = 100,
                AttackPower = 20
            };
            
            StartApplication(player,enemy);
        }

        private static void StartApplication(Player player,Enemy enemy)
        {
            if (enemy.Health == 0 || player.Health == 0) return;
            Console.WriteLine($"1.{player.Name} hucum etsin");
            Console.WriteLine($"2.{enemy.Name} hucum etsin");
            string choice = Console.ReadLine();
            Choice(choice,player,enemy);
        }

        private static void Choice(string choice,Player player, Enemy enemy)
        {
            if (choice == "1")
            {
                PlayerAttack(player,enemy);
            }
            else if (choice == "2")
            {
                GamerAttack(player, enemy);
            }
        }

        private static void GamerAttack(Player player, Enemy enemy)
        {
            Console.Clear();
            if (player.Health > 0)
            {
                enemy.EnemyAttack(player);
                StartApplication(player, enemy);
            }
        }
        private static void PlayerAttack(Player player,Enemy enemy)
        {
            Console.Clear();
            if (enemy.Health >0)
            {
                player.PlayerAttack(enemy);
                StartApplication(player, enemy);
            }
        }
    }
    abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
    }
    class Player : Character
    {
        public void PlayerAttack(Enemy character)
        {
            character.Health -= character.AttackPower;
            Console.WriteLine($"{character.Name}-in cani {character.Health} qaldi");
            if (character.Health <= 0)
            {
                Console.WriteLine($"{Name} qazandi ");
                return;
            }
        }
    }
    class Enemy : Character
    {
        public void EnemyAttack(Player player)
        {
            player.Health -= player.AttackPower;
            Console.WriteLine($"{player.Name}-in cani {player.Health} qaldi");
            if (player.Health <= 0)
            {
                Console.WriteLine($"{Name} qazandi ");
                return;
            }
        }
    }
}
