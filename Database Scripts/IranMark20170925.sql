USE [IranMarketer]
GO
/****** Object:  Table [dbo].[AcademicFields]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcademicFields](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleEn] [nvarchar](1000) NULL,
	[TitleFa] [nvarchar](1000) NULL,
 CONSTRAINT [PK_AcademicFields] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Industries]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Industries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleFa] [nvarchar](max) NULL,
	[TitleEn] [nvarchar](max) NULL,
 CONSTRAINT [PK_Industries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobCategories]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleFa] [nvarchar](1000) NULL,
	[TitleEn] [nvarchar](1000) NULL,
 CONSTRAINT [PK_JobCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobPrefer]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobPrefer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobCategoryId] [nvarchar](max) NULL,
	[IndustryId] [nvarchar](max) NULL,
	[ExpectedSalary] [int] NULL,
	[BusinessTrips] [int] NULL,
	[Relocate] [int] NULL,
	[PartyId] [int] NOT NULL,
	[LastModificationDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartySkills]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartySkills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartyId] [int] NOT NULL,
	[SkillId] [int] NULL,
	[SkillLevel] [int] NULL,
 CONSTRAINT [PK_PartySkills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartyUniversities]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyUniversities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DegreeLevel] [int] NULL,
	[AcademicField] [int] NOT NULL,
	[University] [nvarchar](300) NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[FromDate] [int] NULL,
	[ToDate] [int] NULL,
	[Average] [decimal](2, 2) NULL,
	[PartyId] [int] NOT NULL,
 CONSTRAINT [PK_PartyUniversities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Regions]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[EnTitle] [nvarchar](250) NULL,
	[CodeId] [nvarchar](20) NULL,
	[RegionType] [int] NULL,
	[ZipCode] [nvarchar](20) NULL,
	[ValidFrom] [date] NULL,
	[ValidUntil] [date] NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RetailParty]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RetailParty](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[EnName] [nvarchar](100) NULL,
	[FirstName] [nvarchar](100) NULL,
	[EnFirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[EnLastName] [nvarchar](100) NULL,
	[FatherName] [nvarchar](100) NULL,
	[EnFatherName] [nvarchar](100) NULL,
	[NationalId] [nvarchar](50) NULL,
	[NationalityPlaceId] [int] NULL,
	[CityId] [int] NULL,
	[FullName] [nvarchar](220) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[BirthPlace] [nvarchar](100) NULL,
	[Gender] [int] NULL,
	[MilitaryServiceStatus] [int] NULL,
	[MaritalStatus] [int] NULL,
	[UserId] [nvarchar](128) NULL,
	[UserName] [nvarchar](100) NULL,
	[ValidFrom] [date] NULL,
	[ValidUntil] [date] NULL,
	[Modified] [datetime] NULL,
	[Created] [datetime] NULL,
	[ModifiedBy] [nvarchar](128) NULL,
	[CreatedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skills]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleFa] [nvarchar](500) NULL,
	[TitleEn] [nvarchar](500) NULL,
	[SkillType] [int] NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkExperience]    Script Date: 9/25/2017 4:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkExperience](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartyId] [int] NOT NULL,
	[JobTitle] [nvarchar](500) NULL,
	[JobCategory] [int] NULL,
	[CompanyName] [nvarchar](500) NULL,
	[IndustryId] [int] NULL,
	[CountryId] [int] NULL,
	[CityId] [int] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Achievements] [nvarchar](max) NULL,
 CONSTRAINT [PK_WorkExperience] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[JobPrefer]  WITH CHECK ADD  CONSTRAINT [FK_JobPrefer_RetailParty] FOREIGN KEY([PartyId])
REFERENCES [dbo].[RetailParty] ([Id])
GO
ALTER TABLE [dbo].[JobPrefer] CHECK CONSTRAINT [FK_JobPrefer_RetailParty]
GO
ALTER TABLE [dbo].[PartySkills]  WITH CHECK ADD  CONSTRAINT [FK_PartySkills_RetailParty] FOREIGN KEY([PartyId])
REFERENCES [dbo].[RetailParty] ([Id])
GO
ALTER TABLE [dbo].[PartySkills] CHECK CONSTRAINT [FK_PartySkills_RetailParty]
GO
ALTER TABLE [dbo].[PartySkills]  WITH CHECK ADD  CONSTRAINT [FK_PartySkills_Skills] FOREIGN KEY([SkillId])
REFERENCES [dbo].[Skills] ([Id])
GO
ALTER TABLE [dbo].[PartySkills] CHECK CONSTRAINT [FK_PartySkills_Skills]
GO
ALTER TABLE [dbo].[PartyUniversities]  WITH CHECK ADD  CONSTRAINT [FK_PartyUniversities_AcademicFields] FOREIGN KEY([AcademicField])
REFERENCES [dbo].[AcademicFields] ([Id])
GO
ALTER TABLE [dbo].[PartyUniversities] CHECK CONSTRAINT [FK_PartyUniversities_AcademicFields]
GO
ALTER TABLE [dbo].[PartyUniversities]  WITH CHECK ADD  CONSTRAINT [FK_PartyUniversities_Regions] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[PartyUniversities] CHECK CONSTRAINT [FK_PartyUniversities_Regions]
GO
ALTER TABLE [dbo].[PartyUniversities]  WITH CHECK ADD  CONSTRAINT [FK_PartyUniversities_Regions1] FOREIGN KEY([CityId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[PartyUniversities] CHECK CONSTRAINT [FK_PartyUniversities_Regions1]
GO
ALTER TABLE [dbo].[PartyUniversities]  WITH CHECK ADD  CONSTRAINT [FK_PartyUniversities_RetailParty] FOREIGN KEY([PartyId])
REFERENCES [dbo].[RetailParty] ([Id])
GO
ALTER TABLE [dbo].[PartyUniversities] CHECK CONSTRAINT [FK_PartyUniversities_RetailParty]
GO
ALTER TABLE [dbo].[RetailParty]  WITH CHECK ADD  CONSTRAINT [FK_RetailParty_Regions] FOREIGN KEY([NationalityPlaceId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[RetailParty] CHECK CONSTRAINT [FK_RetailParty_Regions]
GO
ALTER TABLE [dbo].[RetailParty]  WITH CHECK ADD  CONSTRAINT [FK_RetailParty_Regions1] FOREIGN KEY([CityId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[RetailParty] CHECK CONSTRAINT [FK_RetailParty_Regions1]
GO
ALTER TABLE [dbo].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_Industries] FOREIGN KEY([IndustryId])
REFERENCES [dbo].[Industries] ([Id])
GO
ALTER TABLE [dbo].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_Industries]
GO
ALTER TABLE [dbo].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_JobCategories] FOREIGN KEY([JobCategory])
REFERENCES [dbo].[JobCategories] ([Id])
GO
ALTER TABLE [dbo].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_JobCategories]
GO
ALTER TABLE [dbo].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_Regions] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_Regions]
GO
ALTER TABLE [dbo].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_Regions1] FOREIGN KEY([CityId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_Regions1]
GO
ALTER TABLE [dbo].[WorkExperience]  WITH CHECK ADD  CONSTRAINT [FK_WorkExperience_RetailParty] FOREIGN KEY([PartyId])
REFERENCES [dbo].[RetailParty] ([Id])
GO
ALTER TABLE [dbo].[WorkExperience] CHECK CONSTRAINT [FK_WorkExperience_RetailParty]
GO
