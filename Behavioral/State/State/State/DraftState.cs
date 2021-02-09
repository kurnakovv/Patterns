using State.Context;
using State.State.Abstract;

namespace State.State
{
    class DraftState : IArticleState
    {
        public string Publish(Article article)
        {
            article.ArticleState = new GrammaticalState();
            return "The article is written, move on to grammar.";
        }

        public string Render(Article article)
        {
            return "This article is bad, write more!";
        }
    }
}
