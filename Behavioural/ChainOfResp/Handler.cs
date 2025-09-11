namespace designPattern.Behavioural.ChainOfResp
{
    public abstract class Handler
    {
        protected Handler NextHandler;

        public void SetNextHandler(Handler next)
        {
            NextHandler = next;
        }
        public abstract void HandlesRequest(string document, ResponsibilityEnum responsibility);
    }
    
}