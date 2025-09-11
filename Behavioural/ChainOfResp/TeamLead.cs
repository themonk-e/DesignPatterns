namespace designPattern.Behavioural.ChainOfResp
{
    public class TeamLead : Handler
    {
        public override void HandlesRequest(string document, ResponsibilityEnum responsibility)
        {
            if (responsibility.Equals(ResponsibilityEnum.TeamLead))
            {
                Console.WriteLine($"{document} is being reviewed by {ResponsibilityEnum.TeamLead.ToString()}");
                Console.WriteLine($"{document} is approved");
            }
            else
            {
                NextHandler.HandlesRequest(document, responsibility);
            }
        }
    }
    
}