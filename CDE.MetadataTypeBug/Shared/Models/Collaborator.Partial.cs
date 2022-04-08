using System.ComponentModel.DataAnnotations;

namespace CDE.MetadataTypeBug.Shared.Models
{
    // https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.metadatatypeattribute?view=net-6.0
    // "The MetadataTypeAttribute attribute enables you to associate a class with a data-model partial class.
    // In this associated class you provide additional metadata information that is not in the data model.
    // For example, in the associated class you can apply the RequiredAttribute attribute to a data field."

    [MetadataType(typeof(CollaboratorMetadata))]
    public partial class Collaborator
    {
    }

    public class CollaboratorMetadata
    {
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = null!;       
    }
}
