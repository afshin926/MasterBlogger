namespace MB.Domin.Services
{
    public interface IArticleCategoryValidationService
    {
        void CheckThatThisRecordAlreadyExcits(string title);
    }

}
