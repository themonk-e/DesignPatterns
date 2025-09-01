namespace designPattern.Structural.Flyweight
{
    public class FlyweightCharacterFactory
    {
        public static Dictionary<String,CharacterFactory> Characters = new Dictionary<String,CharacterFactory>();
        
        

        public static CharacterFactory GetCharacter(string characterDefinition)
        {
            if (Characters.ContainsKey(characterDefinition))
            {
                return Characters[characterDefinition];
            }
            else
            {
                if (characterDefinition.Equals("Warrior3DMesh-SmoothTexture-SwirlAnimation"))
                {
                    Characters[characterDefinition] = new WarriorCharacter("Warrior3DMesh", "SmoothTexture", "SwirlAnimation");
            
                    return Characters[characterDefinition];
                }
                else
                {
                    return null;
                }
               
            }
        }
    }
}