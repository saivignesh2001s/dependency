namespace Dependencies.Models
{
    public interface ITransientService
    {
        int GetOperationID();

    }

    public interface IScopedService
    {
        int GetOperationID();
    }
    public interface ISingletonService
    {
        int GetOperationID();

    }
}
