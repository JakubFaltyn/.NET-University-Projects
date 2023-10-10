namespace Lab2.Models
{
    public class Birth
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }


        public bool IsValid()
        {
            return Name != null && BirthDate < DateTime.Now;
        }

        public int Age()
        {
            return DateTime.Today.Year - BirthDate.Year;
        }
    }
}
