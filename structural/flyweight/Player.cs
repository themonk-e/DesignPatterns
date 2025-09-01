using System.Runtime.InteropServices;

namespace designPattern.Structural.Flyweight
{
    public class Player
    {

        private readonly string _Name;

        private readonly CharacterFactory _Character;
        public int HealthPoints { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
        public Player(string name, CharacterFactory character, int hp, int x, int y)
        {
            _Name = name;
            _Character = character;
            HealthPoints = hp;
            X = x;
            Y = y;
        }

        public void CreatePlayer()
        {
            _Character.CreateCharacter();
            Console.WriteLine("Player Created...");
        }

         
    }
}