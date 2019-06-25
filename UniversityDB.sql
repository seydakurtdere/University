USE [UniversityDB]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 10.05.2019 09:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[BranchId] [smallint] IDENTITY(1,1) NOT NULL,
	[BranchName] [nvarchar](50) NOT NULL,
	[FacultyId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[BranchId] [smallint] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyId] [tinyint] IDENTITY(1,1) NOT NULL,
	[FacultyName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InstructorCourses]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InstructorCourses](
	[InstructorCourseId] [int] IDENTITY(1,1) NOT NULL,
	[InstructorId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_InstructorCourses] PRIMARY KEY CLUSTERED 
(
	[InstructorCourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructors]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructors](
	[InstructorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[MobilePhone] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[RecordStatusId] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
 CONSTRAINT [PK_Instructors] PRIMARY KEY CLUSTERED 
(
	[InstructorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecordStatuses]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecordStatuses](
	[RecordStatusId] [tinyint] IDENTITY(1,1) NOT NULL,
	[RecordStatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RecordStatuses] PRIMARY KEY CLUSTERED 
(
	[RecordStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentCourses]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourses](
	[StudentCourseId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentCourses] PRIMARY KEY CLUSTERED 
(
	[StudentCourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[TcNumber] [nvarchar](11) NOT NULL,
	[MobilePhone] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[BranchId] [smallint] NOT NULL,
	[RecordStatusId] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.05.2019 09:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[RecordStatusId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Branches] ON 
GO
INSERT [dbo].[Branches] ([BranchId], [BranchName], [FacultyId]) VALUES (1, N'Bilgisayar Mühendisliği', 1)
GO
INSERT [dbo].[Branches] ([BranchId], [BranchName], [FacultyId]) VALUES (2, N'Endüstri Mühendisliği', 1)
GO
INSERT [dbo].[Branches] ([BranchId], [BranchName], [FacultyId]) VALUES (3, N'Mimarlık', 2)
GO
INSERT [dbo].[Branches] ([BranchId], [BranchName], [FacultyId]) VALUES (4, N'İç Mimarlık', 2)
GO
SET IDENTITY_INSERT [dbo].[Branches] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (1, N'Programlamaya Giriş', 1)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (2, N'Veritabanı Yönetim Sistemleri', 1)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (3, N'Maliyet Analizi', 2)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (4, N'Tesis Planlama', 2)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (5, N'Yapı ve Yapı Yöntemleri', 3)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (6, N'Mimari Tasarım', 3)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (7, N'Mekan Tasarımı', 4)
GO
INSERT [dbo].[Courses] ([CourseId], [CourseName], [BranchId]) VALUES (8, N'Perspektif', 4)
GO
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Faculties] ON 
GO
INSERT [dbo].[Faculties] ([FacultyId], [FacultyName]) VALUES (1, N'Mühendislik Fakültesi')
GO
INSERT [dbo].[Faculties] ([FacultyId], [FacultyName]) VALUES (2, N'Mimarlık Fakültesi')
GO
SET IDENTITY_INSERT [dbo].[Faculties] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [UserName], [Password], [RecordStatusId]) VALUES (1, N'Bülent', N'Başyurt', N'bulent.basyurt', N'123', 1)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Branches]  WITH CHECK ADD  CONSTRAINT [FK_Branches_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Branches] CHECK CONSTRAINT [FK_Branches_Faculties]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Branches]
GO
ALTER TABLE [dbo].[InstructorCourses]  WITH CHECK ADD  CONSTRAINT [FK_InstructorCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[InstructorCourses] CHECK CONSTRAINT [FK_InstructorCourses_Courses]
GO
ALTER TABLE [dbo].[InstructorCourses]  WITH CHECK ADD  CONSTRAINT [FK_InstructorCourses_Instructors] FOREIGN KEY([InstructorId])
REFERENCES [dbo].[Instructors] ([InstructorId])
GO
ALTER TABLE [dbo].[InstructorCourses] CHECK CONSTRAINT [FK_InstructorCourses_Instructors]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_RecordStatuses] FOREIGN KEY([RecordStatusId])
REFERENCES [dbo].[RecordStatuses] ([RecordStatusId])
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_RecordStatuses]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_Users] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_Users]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_Users1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_Users1]
GO
ALTER TABLE [dbo].[Instructors]  WITH CHECK ADD  CONSTRAINT [FK_Instructors_Users2] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Instructors] CHECK CONSTRAINT [FK_Instructors_Users2]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Courses]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Branches]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_RecordStatuses] FOREIGN KEY([RecordStatusId])
REFERENCES [dbo].[RecordStatuses] ([RecordStatusId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_RecordStatuses]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Users] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Users]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Users1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Users1]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Users2] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Users2]
GO
