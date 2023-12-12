namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetAllBlogsWithAuthorQueryResult
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public int AuthorID { get; set; }   
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}
