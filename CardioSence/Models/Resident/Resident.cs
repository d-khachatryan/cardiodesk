using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    public class Resident
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Display(Name = "ResidentId", ResourceType = typeof(Resources.rsResident ))]
        public int ResidentId { get; set; }

        //[Display(Name = "PatientId", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public int? PatientId { get; set; }

        //[Display(Name = "ResidentLastName", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public string ResidentLastName { get; set; }

        //[Display(Name = "ResidentFirstName", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public string ResidentFirstName { get; set; }

        //[Display(Name = "ResidentPatronymicName", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public string ResidentPatronymicName { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Поле должна быть дата")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "BirthDate", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public DateTime? BirthDate { get; set; }

        //[Display(Name = "GenderId", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public int? GenderId { get; set; }

        //[Display(Name = "Age", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public int? Age { get; set; }

        //[Display(Name = "PassportNumber", ResourceType = typeof(Resources.rsResident))]
        public string PassportNumber { get; set; }


        //[Display(Name = "CountryId", ResourceType = typeof(Resources.rsResident))]
        public int? CountryId { get; set; }

        //[Display(Name = "RegionId", ResourceType = typeof(Resources.rsResident))]
        [Required(ErrorMessage = "The field is required")]
        public int? RegionId { get; set; }

        //[Display(Name = "CommunityId", ResourceType = typeof(Resources.rsResident))]
        public int? CommunityId { get; set; }

        //[Display(Name = "Location", ResourceType = typeof(Resources.rsResident))]
        public string Location { get; set; }

        //[Display(Name = "HomePhone", ResourceType = typeof(Resources.rsResident))]
        public string HomePhone { get; set; }

        //[Display(Name = "WorkPhone", ResourceType = typeof(Resources.rsResident))]
        public string WorkPhone { get; set; }

        //[Display(Name = "RelativeName", ResourceType = typeof(Resources.rsResident))]
        public string RelativeName { get; set; }

        //[Display(Name = "RelativeStatusId", ResourceType = typeof(Resources.rsResident))]
        public int? RelativeStatusId { get; set; }

        //[Display(Name = "RelativePhone", ResourceType = typeof(Resources.rsResident))]
        public string RelativePhone { get; set; }

        //[Display(Name = "ProfessionId", ResourceType = typeof(Resources.rsResident))]
        public int? ProfessionId { get; set; }

        //[Display(Name = "ChildrenCount", ResourceType = typeof(Resources.rsResident))]
        public int? ChildrenCount { get; set; }

        //[Display(Name = "ReferralPhysicianId", ResourceType = typeof(Resources.rsResident))]
        public int? ReferralPhysicianId { get; set; }

        //[Display(Name = "ReferralOrganizationId", ResourceType = typeof(Resources.rsResident))]
        public int? ReferralOrganizationId { get; set; }
    }
}