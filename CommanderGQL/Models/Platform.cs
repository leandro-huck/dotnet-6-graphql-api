using System.ComponentModel.DataAnnotations;

namespace CommanderGQL.Models
{
    public class Platform
    {
        public Platform()
        {
            Name = "";
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? LicenseKey { get; set; } // Hidden in GraphQL schema (PlatformType)
        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}