namespace CQRS.Common.Entities.Commands
{
    public interface ICommandHandler<in T> where T : class
    {
        void Handle(T command);
    }
}