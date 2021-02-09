using State.Context;
using State.State.Abstract;

namespace State.State
{
    class AppraisalState : IArticleState
    {
        // Logic for check article.

        public string Publish(Article article)
        {
            return "Very good article, publish it!";
        }

        public string Render(Article article)
        {
            article.ArticleState = new ContentState();
            return "Bad article, back to content review";
        }
    }
}
