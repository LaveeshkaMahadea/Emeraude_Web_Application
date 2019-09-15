namespace Hoteru.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        //private DateTime _currentDate = DateTime.Now;

        public string id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime startdate { get; set; }

        [StringLength(128)]
        public string Customer_id { get; set; }

        [StringLength(128)]
        public string Room_id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Room Room { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
          //  if (startdate < _currentDate)
            //{
              //  yield return new ValidationResult(
                //    $"The start date must not be earlier than {_currentDate}.",
                  //  new[] { "startdate" });
            //}
        //}
    }
}
