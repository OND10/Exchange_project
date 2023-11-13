namespace Exchange_project.Models

{
    using System.ComponentModel.DataAnnotations;

    public class Users
    {


        public Users()
        {
            var erxchange = new HashSet<Exchange>();

        }
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public string Confirm_Password { get; set; }=string.Empty;

        public ICollection<Exchange> Exchange { get; set; } 

    }
}
