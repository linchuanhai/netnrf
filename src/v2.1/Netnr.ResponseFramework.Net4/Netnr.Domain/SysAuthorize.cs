namespace Netnr.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SysAuthorize")]
    public partial class SysAuthorize
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string SysUserId { get; set; }

        [StringLength(50)]
        public string OpenId1 { get; set; }

        [StringLength(50)]
        public string OpenId2 { get; set; }

        [StringLength(50)]
        public string OpenId4 { get; set; }

        [StringLength(50)]
        public string OpenId3 { get; set; }

        [StringLength(50)]
        public string OpenId5 { get; set; }

        [StringLength(50)]
        public string OpenId6 { get; set; }

        [StringLength(50)]
        public string OpenId7 { get; set; }

        [StringLength(50)]
        public string OpenId8 { get; set; }

        [StringLength(50)]
        public string OpenId9 { get; set; }
    }
}
