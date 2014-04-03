using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

    public class RentableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public string ObjectType { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int SizeSqm { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int Price { get; set; }
        public bool Available { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public DateTime SeasonStart { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public DateTime SeasonEnd { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int Beds { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int NumberOfRooms { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public string PostTown { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Fyll i fält")]
        public int Floors { get; set; }
        
        public bool Elevator { get; set; }
        
        public bool DisabledAdaptation { get; set; }
        
        public string DisabledAdaptationDescription { get; set; }
        public List<Picture> Picture { get; set; }
    }
}