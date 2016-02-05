namespace WebAdressBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdressBook")]
    public partial class AdressBook
    {
        public int Id { get; set; }

        [Display(Name = "���")]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]

        [Display(Name = "�������")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "��. �����")]
        [StringLength(255)]
        public string EMail { get; set; }

        [Required]
        [Display(Name = "�������������")]
        [StringLength(255)]
        public string Subdivision { get; set; }

        [Required]
        [Display(Name = "���������")]
        [StringLength(255)]
        public string StatePosition { get; set; }
    }
}
