using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    [Table("vwResident")]
    public class ResidentItem
    {
        [Key]
        public int ResidentId { get; set; }

        [Display(Name = "Patient Id")]
        public int? PatientId { get; set; }

        [Display(Name = "Last Name")]
        public string ResidentLastName { get; set; }

        [Display(Name = "First Name")]
        public string ResidentFirstName { get; set; }

        [Display(Name = "Patronymic Name")]
        public string ResidentPatronymicName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Age")]
        public int? Age { get; set; }

        [Display(Name = "Passport Number")]
        public string PassportNumber { get; set; }

        [Display(Name = "Children Count")]
        public int? ChildrenCount { get; set; }

        [Display(Name = "Country")]
        public int? CountryId { get; set; }

        [Display(Name = "Country")]
        public string CountryName { get; set; }

        [Display(Name = "Region")]
        public int? RegionId { get; set; }

        [Display(Name = "Region")]
        public string RegionName { get; set; }

        [Display(Name = "Community")]
        public int? CommunityId { get; set; }

        [Display(Name = "Community")]
        public string CommunityName { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Profession")]
        public int? ProfessionId { get; set; }

        [Display(Name = "Profession")]
        public string ProfessionName { get; set; }

        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        [Display(Name = "Relative Name")]
        public string RelativeName { get; set; }

        [Display(Name = "Relative Status")]
        public int? RelativeStatusId { get; set; }

        [Display(Name = "Relative Status")]
        public string RelativeStatusName { get; set; }

        [Display(Name = "Relative Phone")]
        public string RelativePhone { get; set; }

        [Display(Name = "Referral Physician")]
        public int? ReferralPhysicianId { get; set; }

        [Display(Name = "Referral Physician")]
        public string ReferralPhysicianName { get; set; }

        [Display(Name = "Referral Organization")]
        public int? ReferralOrganizationId { get; set; }

        [Display(Name = "Referral Organization")]
        public string ReferralOrganizationName { get; set; }

        [Display(Name = "Gender")]
        public int? GenderId { get; set; }

        [Display(Name = "Gender")]
        public string GenderName { get; set; }

        [Display(Name = "Resident Name")]
        public string ResidentName { get; set; }

    }
}