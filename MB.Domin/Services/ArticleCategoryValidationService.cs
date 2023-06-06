using MB.Domin.ArticleCategoryAgg;

namespace MB.Domin.Services
{
    public class ArticleCategoryValidationService : IArticleCategoryValidationService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidationService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatThisRecordAlreadyExcits(string title)
        {
            if (_articleCategoryRepository.Exists(title))
                throw new DataMisalignedException(message:"This Record Already Exist in database");
        }
    }

}
