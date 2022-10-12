namespace ServiceLifeTime.Models
{
    public interface ITransientService
    {
        Guid GetOperationID();

    }

    public interface IScopedService
    {
        Guid GetOperationID();
    }
    public interface ISingletonService
    {
        Guid GetOperationID();

    }
}
