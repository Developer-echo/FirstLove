using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstLove.Repository
{
    [Table("users")]
    public class Users
    {
        /// <summary>
        /// 主键自增长
        /// </summary>
        /// <value></value>
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        /// <value></value>
        [StringLength(18)]
        public string NickName { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        /// <value></value>
        [StringLength(30)]
        public string Mail { get; set; }
        /// <summary>
        /// 个人简介
        /// </summary>
        /// <value></value>
        [StringLength(288)]
        public string BriefIntroduction { get; set; }
        /// <summary>
        /// 头像路径
        /// </summary>
        /// <value></value>
        [StringLength(100)]
        public string HeadImg { get; set; }

    }
}