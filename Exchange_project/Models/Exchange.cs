using System.ComponentModel.DataAnnotations;

namespace Exchange_project.Models
{
    public class Exchange
    {


        public Exchange()
        {
                this.Users=new Users();
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Phone Number is Required")]
        [Phone]
        public string Receiver_Phone_Number { get; set; }=string.Empty;

        [Required(ErrorMessage ="This field is required")]
        public decimal Amount {  get; set; }



        public virtual Users Users { get; set; }
        
        public int User_Id => Users.Id;

    }
}
