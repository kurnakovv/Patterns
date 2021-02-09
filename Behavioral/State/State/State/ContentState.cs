using State.Context;
using State.State.Abstract;

namespace State.State
{
    class ContentState : IArticleState
    {
        // Logic for check content article.

        public string Publish(Article article)
        {
            article.ArticleState = new AppraisalState();
            return "The content of the article is very good, you can show it to critics";
        }

        public string Render(Article article)
        {
            article.ArticleState = new DraftState();
            return "The article content very bad, rewrite please it.";
        }
    }
}
