namespace Progect_1.Storage.Entity
{
    public class Reviews
    {
        public Guid Id { get; set; }
        public string Review { get; set; }
        public Reviews(Guid id, string review)
        {
            Id = id;
            Review = review;
        }
    }
}