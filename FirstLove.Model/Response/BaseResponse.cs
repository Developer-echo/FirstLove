using System;

namespace FirstLove.Model
{
    public class BaseResponse<T>
    {
        /// <summary>
        /// 响应返回信息
        /// </summary>
        /// <value></value>
        public string Message { get; set; }

        /// <summary>
        /// 响应状态
        /// </summary>
        /// <value></value>
        public bool ResStatus { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        /// <value></value>
        public T Data { get; set; }
    }

    /// <summary>
    /// api/User/GetUsers
    /// </summary>
    public class api_GetUsers
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        /// <value></value>
        public int UserId { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        /// <value></value>
        public string NickName { get; set; }
        /// <summary>
        /// 用户邮箱/账号
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }
        /// <summary>
        /// 个人简介
        /// </summary>
        /// <value></value>
        public string BriefIntroduction { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        /// <value></value>
        public string HeadImg { get; set; }
    }
}