using State.Context;
using State.State.Abstract;

namespace State.State
{
    class GrammaticalState : IArticleState
    {
        // Logic for check grammatic article.

        public string Publish(Article article)
        {
            article.ArticleState = new ContentState();
            return "The article is checked for grammatical errors, move to check content.";
        }

        public string Render(Article article)
        {
            article.ArticleState = new DraftState();
            return "There are mistakes in the text, back to draft";
        }
    }
}
