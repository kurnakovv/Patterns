namespace Mediator.Colleague.Abstract
{
    public interface ILeader : IUser
    {
        string KickUser(IUser user, ILeader leader);
        string AddUser(IUser user);
    }
}
