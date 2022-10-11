namespace Dependencies.Models
{
   
        public class OperationServices : ISingletonService, ITransientService, IScopedService
        {
        int no;

            public OperationServices()
            {
            Random r = new Random();
                no = r.Next(100);
            }

            public int GetOperationID()
            {
                //throw new NotImplementedException();
                return no;
            }
        }
    
}
