namespace CarBook.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutQueryResult
    {
        //CQRS'de queryler genellikler "get" ön ekiyle isimlendirilir.

        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
