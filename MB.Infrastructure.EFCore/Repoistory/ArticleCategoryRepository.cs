using MB.Domin.ArticleCategoryAgg;

namespace MB.Infrastructure.EFCore.Repoistory
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context)
        {
            this._context = context;
        }

        public void Add(ArticleCategory Entity)
        {
            _context.ArticleCategories.Add(Entity);
            save();
        }

        public bool Exists(string title)
        {
            return _context.ArticleCategories.Any(c => c.Title == title);    
        }

        public ArticleCategory Get(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.OrderByDescending(x=>x.Id).ToList();
        }

        public void save()
        {
            _context.SaveChanges();
        }

       
    }
}
