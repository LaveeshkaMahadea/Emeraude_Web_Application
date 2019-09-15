namespace Hoteru.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public string id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="First name cannot be more than 100 characters long.")]
        public string customer_fname { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Last name cannot be more than 100 characters long.")]
        public string customer_lname { get; set; }

        [Required]
        [EmailAddress]
        public string customer_email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Username cannot be more than 100 characters long.")]
        public string customer_username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
