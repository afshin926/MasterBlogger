namespace MB.Domin.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        void Add(ArticleCategory Entity);
        ArticleCategory Get(long id);
        void save();
        bool Exists(string title);
    }
}
