USE [waifangdata]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2020/4/2 星期四 下午 10:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NULL,
	[BrandId] [int] NULL,
	[Status] [int] NULL,
	[PdtTitle] [nvarchar](200) NULL,
	[PdtId] [varchar](250) NULL,
	[PdtCode] [varchar](250) NULL,
	[PdtModel] [nvarchar](max) NULL,
	[PdtTags] [nvarchar](200) NULL,
	[PdtChewei] [nvarchar](250) NULL,
	[PdtZhuangxiu] [nvarchar](250) NULL,
	[TouristPrice] [decimal](10, 2) NULL,
	[MemberPrice] [decimal](10, 2) NULL,
	[AgentPrice] [decimal](10, 2) NULL,
	[BulkPrice] [decimal](10, 2) NULL,
	[IsTourist] [bit] NULL,
	[IsMember] [bit] NULL,
	[IsAgent] [bit] NULL,
	[IsBulk] [bit] NULL,
	[PdtIntegral] [int] NULL,
	[AccessNumber] [int] NULL,
	[PdtChanquan] [nvarchar](250) NULL,
	[PdtHbl] [nvarchar](max) NULL,
	[PdtRelated] [varchar](500) NULL,
	[PdtDetail] [varchar](max) NULL,
	[PdtDocs] [varchar](max) NULL,
	[PdtSjt] [varchar](max) NULL,
	[PdtFxt] [nvarchar](max) NULL,
	[PdtLuxian] [nvarchar](max) NULL,
	[PdtLuxian1] [nvarchar](250) NULL,
	[PdtLuxian2] [nvarchar](50) NULL,
	[PdtRom] [bit] NULL,
	[PdtPicture1] [varchar](255) NULL,
	[PdtPicture2] [varchar](255) NULL,
	[PdtPicture3] [varchar](255) NULL,
	[PdtPicture4] [varchar](255) NULL,
	[PdtPicture5] [varchar](255) NULL,
	[OrderNumber] [int] NULL,
	[CreateDate] [datetime] NULL,
	[PageTitle] [varchar](200) NULL,
	[WebKeywords] [nvarchar](1000) NULL,
	[WebDescription] [nvarchar](1000) NULL,
	[PdtHot] [bit] NULL,
	[PdtNew] [bit] NULL,
	[IsHome] [bit] NULL,
	[Specials] [bit] NULL,
	[PdtDown] [bit] NULL,
	[YyflID] [int] NULL,
	[AreaID] [int] NULL,
	[PeijianID] [int] NULL,
	[CommentNumber] [int] NULL,
	[IsYunfei] [bit] NULL,
	[Address] [nvarchar](250) NULL,
	[Bianhao] [nvarchar](250) NULL,
	[PdtPicture6] [varchar](255) NULL,
	[PdtPicture7] [varchar](255) NULL,
	[PicText1] [nvarchar](250) NULL,
	[PicText2] [nvarchar](250) NULL,
	[PicText3] [nvarchar](250) NULL,
	[PicText4] [nvarchar](250) NULL,
	[PicText5] [nvarchar](250) NULL,
	[PicText6] [nvarchar](250) NULL,
	[PicText7] [nvarchar](250) NULL,
	[Source] [nvarchar](250) NULL,
	[PdtPicture8] [nvarchar](250) NULL,
	[PicText8] [nvarchar](250) NULL,
	[Fx] [nvarchar](250) NULL,
	[Sqrk] [nvarchar](50) NULL,
	[Sqaq] [nvarchar](50) NULL,
	[Sqsr1] [nvarchar](50) NULL,
	[Sqsr2] [nvarchar](50) NULL,
	[Sqsr3] [nvarchar](50) NULL,
	[Sqjy1] [nvarchar](50) NULL,
	[Sqjy2] [nvarchar](50) NULL,
	[Sqjy3] [nvarchar](50) NULL,
	[Sqsy1] [nvarchar](50) NULL,
	[Sqsy2] [nvarchar](50) NULL,
	[Sqsy3] [nvarchar](50) NULL,
	[Sqll] [nvarchar](50) NULL,
	[Sqbl] [nvarchar](50) NULL,
	[Sqbr] [nvarchar](50) NULL,
	[Sqxy] [nvarchar](50) NULL,
	[Sqhr] [nvarchar](50) NULL,
	[Sqyy] [nvarchar](50) NULL,
	[Sqqt] [nvarchar](50) NULL,
	[Sqfw] [nvarchar](50) NULL,
	[Sqjy] [nvarchar](50) NULL,
	[Sqyl] [nvarchar](50) NULL,
	[Sqys] [nvarchar](50) NULL,
	[Sqyiliao] [nvarchar](50) NULL,
	[Sqzf] [nvarchar](50) NULL,
	[Sqzt] [nvarchar](50) NULL,
	[Sqjt] [nvarchar](50) NULL,
	[Sqgg] [nvarchar](50) NULL,
	[UserId] [int] NULL,
	[CreateUserName] [nvarchar](50) NULL,
	[CreateSource] [int] NULL,
	[Baiduzdtj] [bit] NULL,
	[UpTop] [int] NULL,
	[Tag] [nvarchar](250) NULL,
	[Ditu] [bit] NULL,
	[BdLuxian1] [nvarchar](50) NULL,
	[BdLuxian2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020/4/2 星期四 下午 10:56:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[LevelId] [int] NULL,
	[ParentId] [int] NULL,
	[Status] [bit] NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[TrueName] [nvarchar](20) NULL,
	[Question] [varchar](100) NULL,
	[Answer] [varchar](100) NULL,
	[Sex] [nvarchar](4) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](15) NULL,
	[Fax] [varchar](20) NULL,
	[Telephone] [varchar](20) NULL,
	[Address] [nvarchar](100) NULL,
	[Postcode] [varchar](12) NULL,
	[CreateDate] [datetime] NULL,
	[Jifen] [int] NULL,
	[IsUse] [int] NULL,
	[YuPrice] [decimal](10, 2) NULL,
	[UsedPrice] [decimal](10, 2) NULL,
	[Orders] [int] NULL,
	[Logined] [int] NULL,
	[LastLoginDate] [datetime] NULL,
	[LastLoginIP] [varchar](20) NULL,
	[Leixing] [int] NULL,
	[IsAgent] [bit] NULL,
	[EnName] [nvarchar](250) NULL,
	[Yuyan] [nvarchar](250) NULL,
	[Diqu] [nvarchar](250) NULL,
	[Jinyan] [nvarchar](250) NULL,
	[Zhizh] [nvarchar](250) NULL,
	[Jianjie] [nvarchar](max) NULL,
	[Weixinopenid] [nvarchar](250) NULL,
	[Qqopenid] [nvarchar](250) NULL,
	[QQ] [nvarchar](50) NULL,
	[Weixin] [nvarchar](50) NULL,
	[Isqq] [bit] NULL,
	[Iswx] [bit] NULL,
	[Picture] [nvarchar](50) NULL,
	[ShopTitle] [nvarchar](250) NULL,
	[AccessNumber] [int] NULL,
	[CommentNumber] [int] NULL,
	[Xingji] [int] NULL,
	[IsRom] [bit] NULL,
	[IsLx] [bit] NULL,
	[IsYm] [bit] NULL,
	[IsTz] [bit] NULL,
	[Fwgj] [nvarchar](250) NULL,
	[IsNewHouse] [bit] NULL,
	[Chengjiao] [nvarchar](50) NULL,
	[Baiduzdtj] [bit] NULL,
	[OrderNumber] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_ParentId]  DEFAULT ((0)) FOR [ParentId]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_BrandId]  DEFAULT ((0)) FOR [BrandId]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PdtMinQuantity]  DEFAULT ((1)) FOR [PdtChewei]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PdtSales]  DEFAULT ((0)) FOR [PdtZhuangxiu]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PdtPrice]  DEFAULT ((0)) FOR [TouristPrice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PdtIntegral]  DEFAULT ((0)) FOR [PdtIntegral]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_AccessNumber]  DEFAULT ((0)) FOR [AccessNumber]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PdtRom]  DEFAULT ((0)) FOR [PdtRom]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_OrderNumber]  DEFAULT ((0)) FOR [OrderNumber]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_YyflID]  DEFAULT ((0)) FOR [YyflID]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_AreaID]  DEFAULT ((0)) FOR [AreaID]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_PeijianID]  DEFAULT ((0)) FOR [PeijianID]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_CommentNumber]  DEFAULT ((0)) FOR [CommentNumber]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_IsYunfei_1]  DEFAULT ((1)) FOR [IsYunfei]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_CreateSource]  DEFAULT ((0)) FOR [CreateSource]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UpTop]  DEFAULT ((999)) FOR [UpTop]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Jifen]  DEFAULT ((0)) FOR [Jifen]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsUse]  DEFAULT ((0)) FOR [IsUse]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_YuPrice]  DEFAULT ((0)) FOR [YuPrice]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UsedPrice]  DEFAULT ((0)) FOR [UsedPrice]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Logined]  DEFAULT ((0)) FOR [Logined]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Picture]  DEFAULT (N'tx.jpg') FOR [Picture]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_AccessNumber]  DEFAULT ((0)) FOR [AccessNumber]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CommentNumber]  DEFAULT ((0)) FOR [CommentNumber]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Xingji]  DEFAULT ((2)) FOR [Xingji]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_OrderNumber]  DEFAULT ((0)) FOR [OrderNumber]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开发商ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'BrandId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物业类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'楼盘面积' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车位信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtChewei'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'装修状况' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtZhuangxiu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市场价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'TouristPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'MemberPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'代理价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'AgentPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'批发价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'BulkPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'积分' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtIntegral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'浏览数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'AccessNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'产权说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtChanquan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预计年回报率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtHbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预计租金收入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtRelated'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目优势' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'周边环境' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtDocs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实景图' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtSjt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交通路线' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtLuxian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'坐标经度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtLuxian1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'坐标维度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtLuxian2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否推荐' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtRom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'OrderNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TITLE' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PageTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关键词' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'WebKeywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'WebDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否最热' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtHot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否最新' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtNew'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'首页显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'IsHome'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地区ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'AreaID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'房屋编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Bianhao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture6'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'PdtPicture7'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'房型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Fx'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'社区人口' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqrk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'社区安全' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqaq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本地收入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsr1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本州收入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsr2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'全美收入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsr3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本地教育' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqjy1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本州教育' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqjy2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'全美教育' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqjy3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本地失业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsy1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本州失业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsy2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'全美失业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqsy3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'蓝领比例' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqll'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'白领比例' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqbl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'白人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqbr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'西裔' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqxy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'黑人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqhr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'亚裔' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqyy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqqt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'服务' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqfw'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教育' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqjy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'娱乐' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqyl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'饮食' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqys'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医疗' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqyiliao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'住房' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqzf'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sqzt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqzt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交通' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqjt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公共事业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Sqgg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经纪人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'CreateUserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'后台0前台1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'CreateSource'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'百度主动推荐' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Baiduzdtj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'刷新排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'UpTop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标签' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Tag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地图列表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Ditu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'百度地图坐标经度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'BdLuxian1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'百度地图坐标维度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'BdLuxian2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新房' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'LevelId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地区ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态1启用0停用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名或手机号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真是姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'TrueName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'问题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Question'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'答案' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Answer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'积分' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Jifen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预存款' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'YuPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已用款' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'UsedPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'启用经纪人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsAgent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'英文名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'EnName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'语言' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Yuyan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地区范围' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Diqu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'从业经验' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Jinyan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'执照号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Zhizh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自我简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Jianjie'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信OpenID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Weixinopenid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQopenid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Qqopenid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'QQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Weixin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ绑定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Isqq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信绑定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Iswx'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Picture'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商铺Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'ShopTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'浏览数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'AccessNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'评论数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'CommentNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'评论星级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Xingji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否留学专家' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsLx'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否移民专家' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsYm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否投资专家' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsTz'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'服务国家' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Fwgj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发布新房权限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'IsNewHouse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'近期成交' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Chengjiao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'百度主动推荐' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Baiduzdtj'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'OrderNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users'
GO
