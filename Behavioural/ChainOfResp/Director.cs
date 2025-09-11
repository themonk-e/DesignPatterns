namespace designPattern.Behavioural.ChainOfResp
{
    public class Director : Handler
    {
        public override void HandlesRequest(string document, ResponsibilityEnum responsibility)
        {
            if (responsibility.Equals(ResponsibilityEnum.Director))
            {
                Console.WriteLine($"{document} is being reviewed by {ResponsibilityEnum.Director.ToString()}");
                Console.WriteLine($"{document} is approved");
            }
            else if (NextHandler is null)
            {
                Console.WriteLine("Please choose the correct person to for approval");
            }
        }
    }
    
}