using System.ComponentModel.DataAnnotations;
namespace VogCodeChallenge.API.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "First Name")]
        public string FisrtName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Display(Name = "Mailing address")]
        public string MailingAddress { get; set; }

    }
}
