using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TicketManagement_Web.Models.Enums;

namespace TicketManagement_Web.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(400)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        public TicketsState State { get; set; }
        public TicketPriority PriorityLevel { get; set; }
    }
}
