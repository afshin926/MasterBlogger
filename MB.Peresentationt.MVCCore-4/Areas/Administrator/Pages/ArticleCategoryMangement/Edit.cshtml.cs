using MB.Appliction.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.Xml;

namespace MB.Peresentationt.MVCCore_4.Areas.Administrator.Pages.ArticleCategoryMangement
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditArticleCategory ArticleCategory { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryAplication;

        public EditModel(IArticleCategoryApplication articleCategoryAplication)
        {
            _articleCategoryAplication = articleCategoryAplication;
        }
        public void OnGet(long id)
        {
            ArticleCategory = _articleCategoryAplication.Get(id);
        }
        public RedirectToPageResult OnPost()
        {
            _articleCategoryAplication.Edit(ArticleCategory);
            return RedirectToPage("./List");
        }
    }
}
