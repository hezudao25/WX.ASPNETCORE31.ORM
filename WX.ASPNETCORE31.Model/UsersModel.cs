//=====================================================================================
// All Rights Reserved , Copyright © HS.COM 2016
//=====================================================================================

using System;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WX.ASPNETCORE31.Framework;

namespace WX.ASPNETCORE31.Model
{
    /// <summary>
    /// 会员
    /// <author>
    ///		<name>wangyuqi</name>
    ///		<date>2016</date>
    /// </author>
    /// </summary>
    [Description("会员")]
    public class Users : BaseModel
    {
    
        /// <summary>
        /// 类型ID
        /// </summary>
        /// <returns></returns>
        [Description("类型ID")]
        public int? LevelId { get; set; }
        /// <summary>
        /// 地区ID
        /// </summary>
        /// <returns></returns>
        [Description("地区ID")]
        [Column("ParentId")]
        public int? ParentId { get; set; }
        /// <summary>
        /// 状态1启用0停用
        /// </summary>
        /// <returns></returns>
        [Description("状态1启用0停用")]
        public bool? Status { get; set; }
        /// <summary>
        /// 用户名或手机号码
        /// </summary>
        /// <returns></returns>
        [Description("用户名或手机号码")]
        public string Username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        /// <returns></returns>
        [Description("密码")]
        public string Password { get; set; }
        /// <summary>
        /// 真是姓名
        /// </summary>
        /// <returns></returns>
        [Description("真是姓名")]
        public string TrueName { get; set; }
        /// <summary>
        /// 问题
        /// </summary>
        /// <returns></returns>
        [Description("问题")]
        public string Question { get; set; }
        /// <summary>
        /// 答案
        /// </summary>
        /// <returns></returns>
        [Description("答案")]
        public string Answer { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        /// <returns></returns>
        [Description("性别")]
        public string Sex { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <returns></returns>
        [Description("Email")]
        public string Email { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        /// <returns></returns>
        [Description("手机")]
        public string Mobile { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        /// <returns></returns>
        [Description("传真")]
        public string Fax { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        /// <returns></returns>
        [Description("电话")]
        public string Telephone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        [Description("地址")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public string Postcode { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        /// <returns></returns>
        [Description("添加时间")]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        /// <returns></returns>
        [Description("积分")]
        public int? Jifen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? IsUse { get; set; }
        /// <summary>
        /// 预存款
        /// </summary>
        /// <returns></returns>
        [Description("预存款")]
        public decimal? YuPrice { get; set; }
        /// <summary>
        /// 已用款
        /// </summary>
        /// <returns></returns>
        [Description("已用款")]
        public decimal? UsedPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? Orders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? Logined { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public DateTime? LastLoginDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public string LastLoginIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? Leixing { get; set; }
        /// <summary>
        /// 启用经纪人
        /// </summary>
        /// <returns></returns>
        [Description("启用经纪人")]
        public bool? IsAgent { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        /// <returns></returns>
        [Description("英文名称")]
        public string EnName { get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        /// <returns></returns>
        [Description("语言")]
        public string Yuyan { get; set; }
        /// <summary>
        /// 地区范围
        /// </summary>
        /// <returns></returns>
        [Description("地区范围")]
        public string Diqu { get; set; }
        /// <summary>
        /// 从业经验
        /// </summary>
        /// <returns></returns>
        [Description("从业经验")]
        public string Jinyan { get; set; }
        /// <summary>
        /// 执照号
        /// </summary>
        /// <returns></returns>
        [Description("执照号")]
        public string Zhizh { get; set; }
        /// <summary>
        /// 自我简介
        /// </summary>
        /// <returns></returns>
        [Description("自我简介")]
        public string Jianjie { get; set; }
        /// <summary>
        /// 微信OpenID
        /// </summary>
        /// <returns></returns>
        [Description("微信OpenID")]
        public string Weixinopenid { get; set; }
        /// <summary>
        /// QQopenid
        /// </summary>
        /// <returns></returns>
        [Description("QQopenid")]
        public string Qqopenid { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        /// <returns></returns>
        [Description("QQ")]
        public string QQ { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        /// <returns></returns>
        [Description("微信")]
        public string Weixin { get; set; }
        /// <summary>
        /// QQ绑定
        /// </summary>
        /// <returns></returns>
        [Description("QQ绑定")]
        public bool? Isqq { get; set; }
        /// <summary>
        /// 微信绑定
        /// </summary>
        /// <returns></returns>
        [Description("微信绑定")]
        public bool? Iswx { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        /// <returns></returns>
        [Description("头像")]
        public string Picture { get; set; }
        /// <summary>
        /// 商铺Title
        /// </summary>
        [Description("商铺Title")]
        public string ShopTitle { get; set; }
        [Description("浏览数")]
        public int? AccessNumber { get; set; }
        [Description("评论数")]
        public int? CommentNumber { get; set; }
        [Description("星际")]
        public int? Xingji { get; set; }
        /// <summary>
        /// 是否留学专家
        /// </summary>
        /// <returns></returns>
        [Description("是否留学专家")]
        public bool? IsLx { get; set; }
        /// <summary>
        /// 是否投资专题
        /// </summary>
        /// <returns></returns>
        [Description("是否投资专家")]
        public bool? IsTz { get; set; }
        /// <summary>
        /// 是否移民专家
        /// </summary>
        /// <returns></returns>
        [Description("是否移民专家")]
        public bool? IsYm { get; set; }
        /// <summary>
        /// 服务国家（针对留学/投资/移民）
        /// </summary>
        [Description("服务国家")]
        public string Fwgj { get; set; }
        /// <summary>
        /// 推荐
        /// </summary>
        [Description("推荐")]
        public bool? IsRom { get; set; }
        /// <summary>
        /// 发布新房权限
        /// </summary>
        [Description("发布新房权限")]
        public bool? IsNewHouse { get; set; }
        /// <summary>
        /// 近期成交
        /// </summary>
        [Description("近期成交")]
        public string Chengjiao { get; set; }
        /// <summary>
        /// 是否百度主动推荐
        /// </summary>
        /// <returns></returns>
        [Description("是否百度主动推荐")]
        public bool? Baiduzdtj { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Description("排序")]
        public int? OrderNumber { get; set; }
        ///// <summary>
        ///// 真实名字
        ///// </summary>
        //public string RealName { get; set; }
   
    }
}