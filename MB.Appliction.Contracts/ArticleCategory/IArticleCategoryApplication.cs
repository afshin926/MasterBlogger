namespace MB.Appliction.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> list();
        void create(CreateAtricleCategory command); 
        void Edit(EditArticleCategory command);
        EditArticleCategory Get(long id);
        void delete(long id);
        void Activate(long id);

    }
}
