using System;
using System.ComponentModel;
using System.Text;
using WX.ASPNETCORE31.Framework;

namespace WX.ASPNETCORE31.Model
{
    /// <summary>
    /// 新房
    /// <author>
    ///		<name>WANGYUQI</name>
    ///		<date>2016</date>
    /// </author>
    /// </summary>
    [Description("新房")]
    [Tabale("Products")]
    public class Products : BaseModel
    {        
        /// <summary>
        /// 分类
        /// </summary>
        /// <returns></returns>
        [Description("分类")]
        public int? ParentId { get; set; }
        /// <summary>
        /// 开发商ID
        /// </summary>
        /// <returns></returns>
        [Description("开发商ID")]
        public int? BrandId { get; set; }
        /// <summary>
        /// 状态0审核中1已审核2未通过
        /// </summary>
        /// <returns></returns>
        [Description("状态")]
        public int? Status { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        [Description("名称")]
        public string PdtTitle { get; set; }
        /// <summary>
        /// 物业类型
        /// </summary>
        /// <returns></returns>
        [Description("物业类型")]
        public string PdtId { get; set; }
        /// <summary>
        /// 楼盘面积
        /// </summary>
        /// <returns></returns>
        [Description("楼盘面积")]
        public string PdtCode { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        /// <returns></returns>
        [Description("简介")]
        public string PdtModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public string PdtTags { get; set; }
        /// <summary>
        /// 车位信息
        /// </summary>
        /// <returns></returns>
        [Description("车位信息")]
        public string PdtChewei { get; set; }
        /// <summary>
        /// 装修状况
        /// </summary>
        /// <returns></returns>
        [Description("装修状况")]
        public string PdtZhuangxiu { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        /// <returns></returns>
        [Description("市场价")]
        public decimal? TouristPrice { get; set; }
        /// <summary>
        /// 会员价
        /// </summary>
        /// <returns></returns>
        [Description("会员价")]
        public decimal? MemberPrice { get; set; }
        /// <summary>
        /// 代理价
        /// </summary>
        /// <returns></returns>
        [Description("代理价")]
        public decimal? AgentPrice { get; set; }
        /// <summary>
        /// 批发价
        /// </summary>
        /// <returns></returns>
        [Description("批发价")]
        public decimal? BulkPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? IsTourist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? IsMember { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? IsAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? IsBulk { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        /// <returns></returns>
        [Description("积分")]
        public int? PdtIntegral { get; set; }
        /// <summary>
        /// 浏览数
        /// </summary>
        /// <returns></returns>
        [Description("浏览数")]
        public int? AccessNumber { get; set; }
        /// <summary>
        /// 产权说明
        /// </summary>
        /// <returns></returns>
        [Description("产权说明")]
        public string PdtChanquan { get; set; }
        /// <summary>
        /// 预计年回报率
        /// </summary>
        /// <returns></returns>
        [Description("预计年回报率")]
        public string PdtHbl { get; set; }
        /// <summary>
        /// 预计租金收入
        /// </summary>
        /// <returns></returns>
        [Description("预计租金收入")]
        public string PdtRelated { get; set; }
        /// <summary>
        /// 项目优势
        /// </summary>
        /// <returns></returns>
        [Description("项目优势")]
        public string PdtDetail { get; set; }
        /// <summary>
        /// 周边环境
        /// </summary>
        /// <returns></returns>
        [Description("周边环境")]
        public string PdtDocs { get; set; }
        /// <summary>
        /// 实景图
        /// </summary>
        /// <returns></returns>
        [Description("实景图")]
        public string PdtSjt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public string PdtFxt { get; set; }
        /// <summary>
        /// 交通路线
        /// </summary>
        /// <returns></returns>
        [Description("交通路线")]
        public string PdtLuxian { get; set; }
        /// <summary>
        /// 坐标经度
        /// </summary>
        /// <returns></returns>
        [Description("坐标经度")]
        public string PdtLuxian1 { get; set; }
        /// <summary>
        /// 坐标纬度
        /// </summary>
        /// <returns></returns>
        [Description("坐标纬度")]
        public string PdtLuxian2 { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        /// <returns></returns>
        [Description("是否推荐")]
        public bool? PdtRom { get; set; }
        /// <summary>
        /// 图片1
        /// </summary>
        /// <returns></returns>
        [Description("图片1")]
        public string PdtPicture1 { get; set; }
        /// <summary>
        /// 图片2
        /// </summary>
        /// <returns></returns>
        [Description("图片2")]
        public string PdtPicture2 { get; set; }
        /// <summary>
        /// 图片3
        /// </summary>
        /// <returns></returns>
        [Description("图片3")]
        public string PdtPicture3 { get; set; }
        /// <summary>
        /// 图片4
        /// </summary>
        /// <returns></returns>
        [Description("图片4")]
        public string PdtPicture4 { get; set; }
        /// <summary>
        /// 图片5
        /// </summary>
        /// <returns></returns>
        [Description("图片5")]
        public string PdtPicture5 { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        /// <returns></returns>
        [Description("排序")]
        public int? OrderNumber { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        /// <returns></returns>
        [Description("添加时间")]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// TITLE
        /// </summary>
        /// <returns></returns>
        [Description("TITLE")]
        public string PageTitle { get; set; }
        /// <summary>
        /// 关键词
        /// </summary>
        /// <returns></returns>
        [Description("关键词")]
        public string WebKeywords { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <returns></returns>
        [Description("描述")]
        public string WebDescription { get; set; }
        /// <summary>
        /// 是否最热
        /// </summary>
        /// <returns></returns>
        [Description("是否最热")]
        public bool? PdtHot { get; set; }
        /// <summary>
        /// 是否最新
        /// </summary>
        /// <returns></returns>
        [Description("是否最新")]
        public bool? PdtNew { get; set; }
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        [Description("首页显示")]
        public bool? IsHome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? Specials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? PdtDown { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? YyflID { get; set; }
        /// <summary>
        /// 地区ID
        /// </summary>
        /// <returns></returns>
        [Description("地区ID")]
        public int? AreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? PeijianID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public int? CommentNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Description("")]
        public bool? IsYunfei { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        [Description("地址")]
        public string Address { get; set; }
        /// <summary>
        /// 房屋编号
        /// </summary>
        /// <returns></returns>
        [Description("房屋编号")]
        public string Bianhao { get; set; }
        /// <summary>
        /// 图片6
        /// </summary>
        /// <returns></returns>
        [Description("图片6")]
        public string PdtPicture6 { get; set; }
        /// <summary>
        /// 图片7
        /// </summary>
        /// <returns></returns>
        [Description("图片7")]
        public string PdtPicture7 { get; set; }
        /// <summary>
        /// 图片2描述
        /// </summary>
        /// <returns></returns>
        [Description("图片2描述")]
        public string PicText2 { get; set; }
        /// <summary>
        /// 图片3描述
        /// </summary>
        /// <returns></returns>
        [Description("图片3描述")]
        public string PicText3 { get; set; }
        /// <summary>
        /// 图片4描述
        /// </summary>
        /// <returns></returns>
        [Description("图片4描述")]
        public string PicText4 { get; set; }
        /// <summary>
        /// 图片5描述
        /// </summary>
        /// <returns></returns>
        [Description("图片5描述")]
        public string PicText5 { get; set; }
        /// <summary>
        /// 图片6描述
        /// </summary>
        /// <returns></returns>
        [Description("图片6描述")]
        public string PicText6 { get; set; }
        /// <summary>
        /// 图片7描述
        /// </summary>
        /// <returns></returns>
        [Description("图片7描述")]
        public string PicText7 { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [Description("来源")]
        public string Source { get; set; }
        /// <summary>
        /// 房型
        /// </summary>
        [Description("房型")]
        public string Fx { get; set; }
        /// <summary>
        /// 图片8描述
        /// </summary>
        /// <returns></returns>
        [Description("图片8描述")]
        public string PicText8 { get; set; }
        /// <summary>
        /// 图片8
        /// </summary>
        /// <returns></returns>
        [Description("图片8")]
        public string PdtPicture8 { get; set; }

        /// <summary>
        /// 社区人口
        /// </summary>
        /// <returns></returns>
        [Description("社区人口")]
        public string Sqrk { get; set; }
        /// <summary>
        /// 社区安全
        /// </summary>
        /// <returns></returns>
        [Description("社区安全")]
        public string Sqaq { get; set; }
        /// <summary>
        /// 本地收入
        /// </summary>
        /// <returns></returns>
        [Description("本地收入")]
        public string Sqsr1 { get; set; }
        /// <summary>
        /// 本州收入
        /// </summary>
        /// <returns></returns>
        [Description("本州收入")]
        public string Sqsr2 { get; set; }
        /// <summary>
        /// 全美收入
        /// </summary>
        /// <returns></returns>
        [Description("全美收入")]
        public string Sqsr3 { get; set; }
        /// <summary>
        /// 本地教育
        /// </summary>
        /// <returns></returns>
        [Description("本地教育")]
        public string Sqjy1 { get; set; }
        /// <summary>
        /// 本州教育
        /// </summary>
        /// <returns></returns>
        [Description("本州教育")]
        public string Sqjy2 { get; set; }
        /// <summary>
        /// 全美教育
        /// </summary>
        /// <returns></returns>
        [Description("全美教育")]
        public string Sqjy3 { get; set; }
        /// <summary>
        /// 本地失业
        /// </summary>
        /// <returns></returns>
        [Description("本地失业")]
        public string Sqsy1 { get; set; }
        /// <summary>
        /// 本州失业
        /// </summary>
        /// <returns></returns>
        [Description("本州失业")]
        public string Sqsy2 { get; set; }
        /// <summary>
        /// 全美失业
        /// </summary>
        /// <returns></returns>
        [Description("全美失业")]
        public string Sqsy3 { get; set; }
        /// <summary>
        /// 蓝领比例
        /// </summary>
        /// <returns></returns>
        [Description("蓝领比例")]
        public string Sqll { get; set; }
        /// <summary>
        /// 白领比例
        /// </summary>
        /// <returns></returns>
        [Description("白领比例")]
        public string Sqbl { get; set; }
        /// <summary>
        /// 白人
        /// </summary>
        /// <returns></returns>
        [Description("白人")]
        public string Sqbr { get; set; }
        /// <summary>
        /// 西裔
        /// </summary>
        /// <returns></returns>
        [Description("西裔")]
        public string Sqxy { get; set; }
        /// <summary>
        /// 黑人
        /// </summary>
        /// <returns></returns>
        [Description("黑人")]
        public string Sqhr { get; set; }
        /// <summary>
        /// 亚裔
        /// </summary>
        /// <returns></returns>
        [Description("亚裔")]
        public string Sqyy { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        /// <returns></returns>
        [Description("其他")]
        public string Sqqt { get; set; }
        /// <summary>
        /// 服务
        /// </summary>
        /// <returns></returns>
        [Description("服务")]
        public string Sqfw { get; set; }
        /// <summary>
        /// 教育
        /// </summary>
        /// <returns></returns>
        [Description("教育")]
        public string Sqjy { get; set; }
        /// <summary>
        /// 娱乐
        /// </summary>
        /// <returns></returns>
        [Description("娱乐")]
        public string Sqyl { get; set; }
        /// <summary>
        /// 饮食
        /// </summary>
        /// <returns></returns>
        [Description("饮食")]
        public string Sqys { get; set; }
        /// <summary>
        /// 医疗
        /// </summary>
        /// <returns></returns>
        [Description("医疗")]
        public string Sqyiliao { get; set; }
        /// <summary>
        /// 住房
        /// </summary>
        /// <returns></returns>
        [Description("住房")]
        public string Sqzf { get; set; }
        /// <summary>
        /// Sqzt
        /// </summary>
        /// <returns></returns>
        [Description("Sqzt")]
        public string Sqzt { get; set; }
        /// <summary>
        /// 交通
        /// </summary>
        /// <returns></returns>
        [Description("交通")]
        public string Sqjt { get; set; }
        /// <summary>
        /// 公共事业
        /// </summary>
        /// <returns></returns>
        [Description("公共事业")]
        public string Sqgg { get; set; }
        /// <summary>
        /// 经纪人ID
        /// </summary>
        /// <returns></returns>
        [Description("经纪人ID")]
        public int? UserId { get; set; }
        /// <summary>
        /// 添加人
        /// </summary>
        /// <returns></returns>
        [Description("添加人")]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 后台0前台1
        /// </summary>
        /// <returns></returns>
        [Description("后台0前台1")]
        public int? CreateSource { get; set; }
        /// <summary>
        /// 是否百度主动推荐
        /// </summary>
        /// <returns></returns>
        [Description("是否百度主动推荐")]
        public bool? Baiduzdtj { get; set; }
        ///// <summary>
        ///// 暂存子表
        ///// </summary>      
        //public string bodyChanges { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        /// <returns></returns>
        [Description("标签")]
        public string Tag { get; set; }
        /// <summary>
        /// 地图列表
        /// </summary>
        /// <returns></returns>
        [Description("地图列表")]
        public bool? Ditu { get; set; }
        ///// <summary>
        ///// 用户账号
        ///// </summary>
        //public string UserName { get; set; }
        /// <summary>
        /// 百度坐标经度
        /// </summary>
        /// <returns></returns>
        [Description("百度坐标经度")]
        public string BdLuxian1 { get; set; }
        /// <summary>
        /// 百度坐标纬度
        /// </summary>
        /// <returns></returns>
        [Description("百度坐标纬度")]
        public string BdLuxian2 { get; set; }
        ///// <summary>
        ///// 图片服务器地址1
        ///// </summary>
        //[Description("图片服务器地址1")]
        //public string ImgServer1 { get; set; }
        ///// <summary>
        ///// 图片服务器地址2
        ///// </summary>
        //[Description("图片服务器地址2")]
        //public string ImgServer2 { get; set; }
        ///// <summary>
        ///// 图片服务器地址3
        ///// </summary>
        //[Description("图片服务器地址3")]
        //public string ImgServer3 { get; set; }
        ///// <summary>
        ///// 图片服务器地址4
        ///// </summary>
        //[Description("图片服务器地址4")]
        //public string ImgServer4 { get; set; }
        ///// <summary>
        ///// 图片服务器地址5
        ///// </summary>
        //[Description("图片服务器地址5")]
        //public string ImgServer5 { get; set; }
        ///// <summary>
        ///// 图片服务器地址6
        ///// </summary>
        //[Description("图片服务器地址6")]
        //public string ImgServer6 { get; set; }
        ///// <summary>
        ///// 图片服务器地址7
        ///// </summary>
        //[Description("图片服务器地址7")]
        //public string ImgServer7 { get; set; }
        ///// <summary>
        ///// 图片服务器地址8
        ///// </summary>
        //[Description("图片服务器地址8")]
        //public string ImgServer8 { get; set; }
    }
}