namespace PFMBackend.Data.Entities
{
    public class TransactionSplitsEntity
    {
        public string categoryId { get; set; }
        public CategoryEntity category { get; set; }
        public string transactionId { get; set; }
        public TransactionEntity transaction { get; set; }
    }
}
