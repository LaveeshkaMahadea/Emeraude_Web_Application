namespace Hoteru.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            Rooms = new HashSet<Room>();
        }

        public string id { get; set; }

        [Required]
        [StringLength(100)]
        public string hotelName { get; set; }

        [Required]
        [StringLength(500)]
        public string hotelDescription { get; set; }

        [Required]
        [StringLength(250)]
        public string hotelAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
