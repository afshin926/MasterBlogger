using MB.Appliction.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Peresentationt.MVCCore_4.Areas.Administrator.Pages.ArticleCategoryMangement
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategory)
        {
            _articleCategoryApplication = articleCategory;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateAtricleCategory command)
        {
            _articleCategoryApplication.create(command);
            return RedirectToPage("./list");
        }
    }
}
