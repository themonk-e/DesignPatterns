namespace designPattern.Structural.Flyweight
{
    public class WarriorCharacter : CharacterFactory
    {

        private readonly string _Mesh;
        private readonly string _Texture;

        private readonly string _Animation;
        public WarriorCharacter(String Mesh3D, String texture, String animations)
        {
            _Mesh = Mesh3D;
            _Texture = texture;
            _Animation = animations;
        }

        public void CreateCharacter()
        {
            Console.WriteLine("Creating Character warrior character");
            Console.WriteLine($"Warrior Character with {_Mesh} {_Texture} {_Animation} has been created...");
        }

         
    }
}