using MB.Domin.Services;

namespace MB.Domin.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDelted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public ArticleCategory(string title,IArticleCategoryValidationService validationService)
        {
            GradDgnistEmptyTitle(title);
            validationService.CheckThatThisRecordAlreadyExcits(Title);

            Title = title;
            IsDelted = false;
            CreationDate = DateTime.Now;
        }

        public void GradDgnistEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
        } 

    public void Edit(string title)
    {
            GradDgnistEmptyTitle(title);
            Title = title;
    }
        public void Remove()
        {
            IsDelted = true;
        }
        public void Activate()
        {
            IsDelted=false;
        }
    }
}
