namespace ASPEvidence.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Adress { get; set; } = "";
        public string City { get; set; } = "";  
        public string Zip { get; set; } = "";

        public List<Insurance> Myinsurance { get; set; }


        public Users()
        {
            Myinsurance = new List<Insurance>();
        }

    }

    
}
