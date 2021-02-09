using State.Context;

namespace State.State.Abstract
{
    interface IArticleState
    {
        string Render(Article article);
        string Publish(Article article);
    }
}
