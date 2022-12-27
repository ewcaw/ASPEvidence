namespace ASPEvidence.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Amount { get; set; }
        public string Type { get; set; }

        public DateTime ValidSince { get; set; }
        public DateTime ValidTill { get; set; }

    }
}
