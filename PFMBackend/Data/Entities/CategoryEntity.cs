namespace PFMBackend.Data.Entities
{
    public class CategoryEntity
    {
        public string code { get; set; }
        public string ParentCode { get; set; }
        public string name { get; set; }
        public IEnumerable<TransactionEntity> transactions { get; set; }
        public IEnumerable<TransactionSplitsEntity> splits { get; set; }
    }
}
