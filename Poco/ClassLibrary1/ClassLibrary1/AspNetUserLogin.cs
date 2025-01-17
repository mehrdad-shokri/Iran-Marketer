// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
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

    [Table("AspNetUserLogins", Schema = "dbo")]
    public class AspNetUserLogin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LoginProvider", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK_dbo.AspNetUserLogins", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(128)]
        [StringLength(128)]
        [Key]
        [Display(Name = "Login provider")]
        public string LoginProvider { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProviderKey", Order = 2, TypeName = "nvarchar")]
        [Index(@"PK_dbo.AspNetUserLogins", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(128)]
        [StringLength(128)]
        [Key]
        [Display(Name = "Provider key")]
        public string ProviderKey { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"UserId", Order = 3, TypeName = "nvarchar")]
        [Index(@"IX_UserId", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_dbo.AspNetUserLogins", 3, IsUnique = true, IsClustered = true)]
        [Required]
        [MaxLength(128)]
        [StringLength(128)]
        [Key]
        [Display(Name = "User ID")]
        public string UserId { get; set; }


        [ForeignKey("UserId")] public AspNetUser AspNetUser { get; set; }
    }

}
// </auto-generated>
