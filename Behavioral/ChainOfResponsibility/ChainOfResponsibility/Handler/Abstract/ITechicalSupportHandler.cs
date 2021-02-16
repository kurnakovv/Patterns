using ChainOfResponsibility.DTO;

namespace ChainOfResponsibility.Handler.Abstract
{
    public interface ITechicalSupportHandler
    {
        ITechicalSupportHandler Successor { get; set; }
        string HandleRequest(User user);
    }
}
