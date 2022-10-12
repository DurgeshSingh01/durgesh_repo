namespace ServiceLifeTime.Models
{
    public class OperationServices : ISingletonService, ITransientService, IScopedService
    {
        Guid id;

        public OperationServices()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            //throw new NotImplementedException();
            return id;
        }
    }
}
