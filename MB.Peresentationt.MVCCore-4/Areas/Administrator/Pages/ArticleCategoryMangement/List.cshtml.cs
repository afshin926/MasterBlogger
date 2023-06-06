using MB.Appliction.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Peresentationt.MVCCore_4.Areas.Administrator.Pages.ArticleCategoryMangement
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> articleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            
            articleCategories = _articleCategoryApplication.list();
        }

        public RedirectToPageResult OnPostDelet(long id)
        {
            _articleCategoryApplication.delete(id);
            return RedirectToPage("./List");
        }
        public RedirectToPageResult OnPostActivate(long id)
        {
            _articleCategoryApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
