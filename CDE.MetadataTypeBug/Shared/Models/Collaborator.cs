using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDE.MetadataTypeBug.Shared.Models
{
    // In a real application, this class was auto-generated
    // (scaffolded using Entity Framework database-first).
    public partial class Collaborator
    {
        public Collaborator()
        {
        }

        // This "Required" attribute was added manually
        // and will be deleted when we need to scaffold it again.
        [Required(ErrorMessage = "First name is required.")] 
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
    }
}
