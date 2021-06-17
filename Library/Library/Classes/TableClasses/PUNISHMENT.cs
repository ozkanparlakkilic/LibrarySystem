namespace Library.Classes.TableClasses
{
    class PUNISHMENT
    {
        public int ID { get; set; }
        public int LOAN_ID { get; set; }
        public float KDV_TUTARI { get; set; }
        public float PENALTY_AMOUNT { get; set; }
        public int DELAYED_DAY { get; set; }
        public string TODAY { get; set; }
        public float TOTAL_AMOUNT { get; set; }
        public bool INVOICE { get; set; }
    }
}
