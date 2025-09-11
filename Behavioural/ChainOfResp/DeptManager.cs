namespace designPattern.Behavioural.ChainOfResp
{
    public class DeptManager : Handler
    {
        public override void HandlesRequest(string document, ResponsibilityEnum responsibility)
        {
            if (responsibility.Equals(ResponsibilityEnum.Manager))
            {
                Console.WriteLine($"{document} is being reviewed by {ResponsibilityEnum.Manager.ToString()}");
                Console.WriteLine($"{document} is approved");
            }
            else
            {
                NextHandler.HandlesRequest(document, responsibility);
            }
        }
    }
    
}