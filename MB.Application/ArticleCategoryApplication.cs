using MB.Appliction.Contracts.ArticleCategory;
using MB.Domin.ArticleCategoryAgg;
using MB.Domin.Services;
using System.Globalization;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidationService articleCategoryServices;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,
            IArticleCategoryValidationService validationService)
        {
            _articleCategoryRepository = articleCategoryRepository;
            this._articleCategoryRepository = articleCategoryRepository;
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.save();
        }
        public void delete(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.save();
        }

        public void create(CreateAtricleCategory command)
        {
            var ArticleCategory = new ArticleCategory(command.Title,articleCategoryServices);
            _articleCategoryRepository.Add(ArticleCategory);
        }


        public void Edit(EditArticleCategory command)
        {
            var articleCategory=_articleCategoryRepository.Get(command.Id);
            articleCategory.Edit(command.Title);
            _articleCategoryRepository.save();
        }

        public EditArticleCategory Get(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            return new EditArticleCategory
            { 
                Id = articleCategory.Id,
               Title = articleCategory.Title,
               IsDeleted=articleCategory.IsDelted
            };
        }

        public List<ArticleCategoryViewModel> list()
        {
            var ArticleCategories = _articleCategoryRepository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach (var item in ArticleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    IsDeleted = item.IsDelted,
                    CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture)
                });
            }
            return result;
        }
    }
}
