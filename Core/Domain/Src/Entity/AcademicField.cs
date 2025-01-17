// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Pikad.Framework.Repository;

namespace IranMarketer.Domain.Entity
{

    // AcademicFields
    [Table("AcademicFields", Schema = "dbo")]
    public class AcademicField : Entity<int>
    {

        [Column(@"TitleEn", Order = 2, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Title en")]
        public string TitleEn { get; set; }

        [Column(@"TitleFa", Order = 3, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Title fa")]
        public string TitleFa { get; set; }


        [JsonIgnore]

        public virtual System.Collections.Generic.ICollection<PartyUniversity> PartyUniversities { get; set; }

        public AcademicField()
        {
            PartyUniversities = new System.Collections.Generic.List<PartyUniversity>();
        }
    }

}
// </auto-generated>
