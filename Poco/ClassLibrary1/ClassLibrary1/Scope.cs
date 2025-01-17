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

namespace IranMarketer.Domain.Entity
{

    [Table("Scopes", Schema = "sec")]
    public class Scope
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_dbo.Scopes", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"Enabled", Order = 2, TypeName = "bit")]
        [Required]
        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }

        [Column(@"Name", Order = 3, TypeName = "nvarchar")]
        [Required]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column(@"DisplayName", Order = 4, TypeName = "nvarchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Display name")]
        public string DisplayName { get; set; }

        [Column(@"Description", Order = 5, TypeName = "nvarchar")]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Column(@"Required", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Required")]
        public bool Required { get; set; }

        [Column(@"Emphasize", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Emphasize")]
        public bool Emphasize { get; set; }

        [Column(@"Type", Order = 8, TypeName = "int")]
        [Required]
        [Display(Name = "Type")]
        public int Type { get; set; }

        [Column(@"IncludeAllClaimsForUser", Order = 9, TypeName = "bit")]
        [Required]
        [Display(Name = "Include all claims for user")]
        public bool IncludeAllClaimsForUser { get; set; }

        [Column(@"ClaimsRule", Order = 10, TypeName = "nvarchar")]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Claims rule")]
        public string ClaimsRule { get; set; }

        [Column(@"ShowInDiscoveryDocument", Order = 11, TypeName = "bit")]
        [Required]
        [Display(Name = "Show in discovery document")]
        public bool ShowInDiscoveryDocument { get; set; }

        [Column(@"AllowUnrestrictedIntrospection", Order = 12, TypeName = "bit")]
        [Required]
        [Display(Name = "Allow unrestricted introspection")]
        public bool AllowUnrestrictedIntrospection { get; set; }

        public virtual System.Collections.Generic.ICollection<ScopeClaim> ScopeClaims { get; set; }
        public virtual System.Collections.Generic.ICollection<ScopeSecret> ScopeSecrets { get; set; }

        public Scope()
        {
            ScopeClaims = new System.Collections.Generic.List<ScopeClaim>();
            ScopeSecrets = new System.Collections.Generic.List<ScopeSecret>();
        }
    }

}
// </auto-generated>
