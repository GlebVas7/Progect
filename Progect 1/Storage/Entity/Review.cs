namespace Progect_1.Storage.Entity
{
    public class Review
    {
        public Guid Id { get; set; }
        public string Reviews { get; set; }
        public Review(Guid id, string reviews)
        {
            Id = id;
            Reviews = reviews;
        }
    }
}