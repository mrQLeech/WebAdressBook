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

        [Display(Name = "ФИО")]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]

        [Display(Name = "Телефон")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Эл. почта")]
        [StringLength(255)]
        public string EMail { get; set; }

        [Required]
        [Display(Name = "Подразделение")]
        [StringLength(255)]
        public string Subdivision { get; set; }

        [Required]
        [Display(Name = "Должность")]
        [StringLength(255)]
        public string StatePosition { get; set; }
    }
}
