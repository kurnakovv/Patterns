using Decorator.Components.Abstract;

namespace Decorator.Decorator.Abstract
{
    public interface ILibraryDecorator : ILibrary
    {
        ILibrary Library { get; }
    }
}
