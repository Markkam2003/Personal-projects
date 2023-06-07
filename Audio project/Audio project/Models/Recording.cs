using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audio_project.Models
{
    public class Recording
    {
        public int Id { get; set; }
        public string RecordingName { get; set; }
        public string RecordingUrl { get; set; }
        public DateTime RecordingDate { get; set; }
        public string UserId { get; set; }
        public string GuestId { get; set; }
        public string ContractText { get; set; }
        public bool IsContractSigned { get; set; }
    }
}
