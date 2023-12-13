namespace CarBook.Dto.BlogDTOs
{
    public class ResultAllBlogsWithAuthorDto
    {
        public int blogId { get; set; }
        public string title { get; set; }
        public string authorName { get; set; }
        public object categoryName { get; set; }
        public int authorID { get; set; }
        public string coverImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public int categoryId { get; set; }

    }
}
