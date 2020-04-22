using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CardioSence.Models
{
    [Table("vwCardiologicalCaseInvasion")]
    public class CardiologicalCaseInvasionItem
    {
        [Key]
        [Display(Name = "CardiologicalCaseInvasionId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int CardiologicalCaseInvasionId { get; set; }

        [Display(Name = "CardiologicalCaseId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? CardiologicalCaseId { get; set; }

        [Display(Name = "InvasionId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? InvasionId { get; set; }

        [Display(Name = "InvasionName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string InvasionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "InvasionDate", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public DateTime? InvasionDate { get; set; }

        [Display(Name = "OrganizationId", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public int? OrganizationId { get; set; }

        [Display(Name = "OrganizationName", ResourceType = typeof(Resources.rsCardiologicalCase))]
        public string OrganizationName { get; set; }
    }
}