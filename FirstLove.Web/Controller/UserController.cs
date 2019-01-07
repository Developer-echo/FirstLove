using System;
using System.Collections.Generic;
using System.Linq;
using FirstLove.Model;
using FirstLove.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstLove.Web.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _db;

        public UserController(DataContext dataContext)
        {
            _db = dataContext;
        }

        #region 对Users表数据操作的相关Api
        /// <summary>
        /// 获取用户信息列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public BaseResponse<List<api_GetUsers>> GetUsers()
        {
            BaseResponse<List<api_GetUsers>> response = new BaseResponse<List<api_GetUsers>>()
            {
                Message = "获取失败",
                ResStatus = false,
                Data = new List<api_GetUsers>()
            };
            try
            {
                //获取用户信息列表
                response.Message = "成功";
                response.ResStatus = true;
                var users = _db.Users.ToList();
                foreach (var user in users)
                {
                    api_GetUsers userInfo = new api_GetUsers()
                    {
                        UserId = user.UserId,
                        NickName = user.NickName,
                        Mail = user.Mail,
                        BriefIntroduction = user.BriefIntroduction,
                        HeadImg = user.HeadImg
                    };
                    response.Data.Add(userInfo);
                }
                return response;
            }
            catch (Exception e)
            {
                response = new BaseResponse<List<api_GetUsers>>()
                {
                    Message = "获取异常,异常信息:" + e.Message,
                    ResStatus = false,
                    Data = new List<api_GetUsers>()
                };
                return response;
            }
        }
        #endregion
    }
}