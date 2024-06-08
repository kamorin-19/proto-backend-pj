using System.ComponentModel.DataAnnotations;

namespace proto_backend.Models
{
    public class PartMaster
    {
        [Key]
        public int PartId { get; set; }
        public string PartName { get; set; }
    }
}
