using State.State.Abstract;

namespace State.Context
{
    class Article
    {
        public Article(IArticleState articleState)
        {
            ArticleState = articleState;
        }

        public IArticleState ArticleState { get; set; }
        public string Text { get; set; }

        public string Render()
        {
            return ArticleState.Render(this);
        }

        public string Publish()
        {
            return ArticleState.Publish(this);
        }

        public string GetState()
        {
            return $"{ArticleState.GetType().Name}";
        }
    }
}
