USE [master]
GO
/****** Object:  Database [ExamenesUniversidad]    Script Date: 14/06/2019 21:36:38 ******/
CREATE DATABASE [ExamenesUniversidad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamenesUniversidad', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ExamenesUniversidad.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExamenesUniversidad_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ExamenesUniversidad_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ExamenesUniversidad] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamenesUniversidad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamenesUniversidad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ExamenesUniversidad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamenesUniversidad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamenesUniversidad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ExamenesUniversidad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamenesUniversidad] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ExamenesUniversidad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ExamenesUniversidad] SET  MULTI_USER 
GO
ALTER DATABASE [ExamenesUniversidad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamenesUniversidad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamenesUniversidad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamenesUniversidad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExamenesUniversidad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExamenesUniversidad] SET QUERY_STORE = OFF
GO
USE [ExamenesUniversidad]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Cursos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudianteRespuestas]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudianteRespuestas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Respuesta] [int] NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[ExamenPreguntaId] [int] NOT NULL,
	[Correcta] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.EstudianteRespuestas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroCarnet] [int] NOT NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[NombreUsuario] [nvarchar](max) NULL,
	[Clave] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Estudiantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Abierto] [bit] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[CursoId] [int] NOT NULL,
	[ProfesorId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Examenes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenPreguntas]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenPreguntas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroPregunta] [int] NOT NULL,
	[PreguntaId] [int] NOT NULL,
	[ExamenId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ExamenPreguntas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Consecutivo] [nvarchar](max) NULL,
	[Enunciado] [nvarchar](max) NULL,
	[Respuesta1] [nvarchar](max) NULL,
	[Respuesta2] [nvarchar](max) NULL,
	[Respuesta3] [nvarchar](max) NULL,
	[Respuesta4] [nvarchar](max) NULL,
	[Respuesta5] [nvarchar](max) NULL,
	[RespuestaCorrecta] [int] NOT NULL,
	[CursoId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Preguntas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 14/06/2019 21:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[NombreUsuario] [nvarchar](max) NULL,
	[Clave] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Profesores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201906060200431_AutomaticMigration', N'ExamenesUniversidad.Datos.Migrations.Configuration', 0x1F8B0800000000000400ED5DDB6EE4B8117D0F907F10F494045EB72F33406274EF62B66D07C6AEED81DB5EE4CD604B745B88447544CAB011E4CBF2904FCA2F84BA4BBC89D4ADDB8E312F6E912CB28A87C5629155F3DF7FFF67FED36BE05B2F30C25E8816F6F1E1916D41E484AE87360B3B264F3FFCD9FEE9C7DFFF6E7EE106AFD66F45BDD3A41E6D89F0C27E26647B369B61E71906001F069E1385387C22874E18CC801BCE4E8E8EFE323B3E9E414AC2A6B42C6B7E1723E20530FD417F2E43E4C02D89817F1DBAD0C7F9775AB24AA95A372080780B1CB8B02F5EE9DF08E207E4A5C376817B780E48880FCFD7940E81AF04DBD637DF03746C2BE83FD91640282480D0919F3D60B822518836AB2DFD00FCFBB72DA4F59E808F61CED159555D97B9A39384B959D5B020E5C498848121C1E3D35C5A33B6792799DBA534A93C2FA8DCC95BC2752AD385BD8C231CDA16DBD3D9D28F925A2A7927B4E82F880F53220796B4EA41891C0AB0E4DF81B58C7D12477081604C22E01F58DFE3B5EF39BFC0B7FBF0EF102D50ECFBF591D3B1D3B2C607FAE97B146E6144DEEEE053CECF956B5BB366BB19DBB06C566B93317B85C8E9896DDDD0CEC1DA8725306A82599130827FA56C468040F73B20044628A10153D172BD337D2DE9D2DA84457F148B74A1D9D63578FD15A20D795ED8F44FDBBAF45EA15B7CC9C740A54AD7256D44A218B675731306EB080EDFCD0D78F136A920980E8BB9B7AD3BE8A715F0B3B7CD5660868FC7AACA65140677A15FC0AF2C795C8571E424C30E85C5F720DA40A23FA8EF11DC504D0354A3AAD56187551649C655958B06369F558B4DB90433F6FAAEC1ACCEE722DCA345F86DEDD15F653F3F87143B0009386B59CB7100A3B08653B598D4C42EA1F30CAE28175E392E8A0E784F77E36EB42E3DD49B50BA9CDA01A026427F3E411C46C674A4EA23DF1BFB28B4423148145AA157CCB4AC5AAD65751EB9AAD518C535382527A966AE84B379110EB62814CA922BE4C4C9D71049D4501317AC0EA3910B6A9F9A59473337755D5F859051E9AB58B2791B4EAD5C6012BB1EA047953B7AA8892196AE64BEE2230BD1DAAA6EADCD2D1F8D26DD34D4B08A891BB65A7F995A8712C5940B40315C591D819A9254ECA7ADF8D9EBADB278929F7A4B476FD566A097AA29E53F8CD2EAAC023594578BCA7A14AB3991BE125655282B71FD7EB6D4340A9833B1F475764F15319C66F85408FA86CC124428C5708F959CB972F0F8A7D52DF47DCF0DC7EF29E3E801C720F2C63F852F7DF032A927CCDCBCEBAD2BE57A45AD5B3B2995A1CE479F2723339F15C2D08989F732FE92B94031723CE08EDF5389C9E3E9BA3A99AEABD3E9BAFA325D575FA7EB6A19461174FA9AD5DDFC8B9DFD825A570A62CF60F7D3AC8E6BB0D7A196DD635A4FBF1D3797C25BD87773C9E87C6E2E5A9B0B7463BFE722FBB453DF999DAABAB135F4CBF3BA41E6B9D7510ADF300EA9F9910C89B3A9C5A67293E50BE45A86767326F4A6554EA54FD581B7A50A800E72611F73B2D5EFA8D4F6A28E6ACEA3668F7FE27AA42A0546C99A067E62105225E521C2EB1F8F9A6F5BE09B498121A3A9C892692C3B644BCEE116A2440799894967244D57193FA6B26B46EDB649703EABC14F179552F7503B5EDA7D453D2163D4A908A78CC38B5D14ACE46FD139F42181D637277BF2B404D8A17B32BF03D2910D8AEE36AE260578DBBC6A619C73E2EE04E752B35106B4761BB282971C587220B75FBCE8C277200DDBC6F004C86B9389CE10768E34C915A154A1B53C64605160B4A3B7DC454E8C3035AB536836A53CF4B5D90EB5186BD2CAD58BD4BEADEBADE2A06AA2B7A40F5ADAA03A98A292B03689869270AFA79AAAD75D3B810FF3E44B36C5B207ADD5FCE6DE237DD4C89E944D0419314713E045CCB74EC7A5BF6F874869DFBDA48F8C7B6345B95D8DBC5149B89A0C2F9DB6A6290193F93C925015DA02468C37A6E6A5CCA359049ED0070C736728CEBD3E2C1E922E5690D4D9C3B655B95B9AF8E2E0D46C5EF980380285E6D1A250F3374B0855D86C2328BC30E5A98A0ECCDAA4D5145B09A9D8D566B4D8F78483A96C10864A0D7A22C624F7CDB5569A57D4EC6A31F7BC95FC3282E716A2B9AF4D48BACE2FEB8F684ACD48A2F2F7412AA1EAB98DBA3A8E0CF9EFEA2AAA77C32EF3DE1296DF58F172D5735398392A6ACC49D932734D8C2A2ED9135B0108354EDA26676D8EADB645AC3E5E8F0C2AEE72438426E57151F3C0D8C04FA5C99500929D113544DC41186C280B2F09D5C947E7EC531B77618828F8979C76C6645EB95094D6BC963DDF857FE58AE8B2168ABBB6D2EE2CCBE6B32CC83AFF309F49A2B1E7D760BBF5D0A6169D9D7FB1565968F6F2879579847290D198390DD1B25672D9130923B0814C691AD1072FBD08937340C01A24D7A24B37E0AA29AC6C89195674DC30A4F9D92B0CB3A27AF2B7D4B0E7E2D5733B9C3FA9E4E42E29CF4172D049AFF9593CF1EDAC24701EF820123C2958867E1C20F9814BDEBA889AAC5328BEE953292293EB548A6F3C95F98C1101773EE364CF5D323567526B9E15CAAEE74CE70726F3A99635DCE7B92E0360EB64CA8F06986123601BE0610BF5E9368261EB341B0586F4D280588E58FAD540FE8543A23101322F859C4EDD6D5A27A572A7EE78D5A9B6DA41169FEC94A5BD08E504C6598C6C50A41CFD66D0A82EFB9AD0905F02CAA955973B755AF22B9FDD814CCF8FD1176902C75307B8E950190773357F599D88D48DA6C446E3A94E031FCA473C6D689321B8FDD9C41EA06F54D0F5C2DAB46AAD0891E2955A51626A5BB2F641F1D1C06EA99E98362C97EAB3E998CA47A4FCC8CA2203EB207B2ADAB00DB24F7B03F41177F11EFBF7D43B772368A7694BD70A0CF45E1598D35078D5E70E1AFE58A2E2B97B462D6A27126A279DA89D4AA89D76A2F64542ED4B276A5F25D4BE76A25645BA088956C5E31D2276A62A4AC7E808BA22BF21EBA22B644D47D215790C4663B2F26F9F5BE0DE6E819C6395AD52F65E3A581947EA3C776AB6E7BEE4BC9C5915DBA2C279F1DCC4C3B97AC30406C9420087AB7FF84BDFA3FC5615AE01F228AA4916CE649F1C1D9F30C932F72771E50C63D7173885B9EC95CDC99A2020CB4B44DA1A72651AA4D8484A875E40E43C83E80F0178FD639D9679F6470352A6390B3F252FF37866B4D61E192ADD5FCA79FF647F2E15191922D95F67424C306ECA17F7C2E90AB9F07561FF336D73665DFDED316F7660DD46548F9D5947D6BF064811A8DB7BD5D260005DF3CE7D8C55254EE5D605C67C1623FD692B5AF6C20D9B014EB7FBA2DD289869F30DBE5BE070B9B4BA604694494B7BDA6A6D07C04D77F8B2EDC7C5D107818F28F352170431F1ECFDCC0236667D00F38E894BEF45B1117B3E86BDF8C1F63641329E5EF2E712EEF4A2C627D51986DCC9B0E44E8725F76558725F8725C726B2E9A29126B39CCDB3B57C9065DD4883F2B9694CBB698C91F663D0D41E9C61BAB33C1E3B4A65F0FF90988309DFD84D228CBD445FDBE3A9FD41E03B4F9BD13B3F4667100F9C0E63BABC04463DEE1C199DD25C0C92CF627798903E7CDE0744BCBBD414BD535168636AE0C413D301E0E3A595E8971A60EA1997C5B4EC72BADF5162887E936D644ABCB7093752EDBB4FEDC0C7A6B1B326C8D6204FD690BDF958D8EE3AC14876C816C7154AD23028D23888684BC32DC5D42B90497AA92AC87B934738729D8ACE3F7CCFA25AC2EE751205C8C7D0923042DD637B470AD9AAA5AA2FCFCA961074511489BB908537EF55360A495A046548AE0263D2308DFEB1C9BB482E215CC1A2C8A7FD13D74499228481D86A717415EA3EE67F100C7F6F981F2DAD83308D8306DB1AC2DA83840D7C82821DB336643A0643E68C56F930D916F8C7BFD400A5DD7941763942AD5FEC6D2A12734A1341A7617A9675AED0535898C0CC888A2ACC25CE3524C0A576E9B788784FC021B4D88118A7C9E77F037E9CCC78B086EE15BA8DC93626946518ACFDC6FF289058D2AAFED39412CD31CF6FB769C6F92158A0C3F492D788B7E8E7D8F3DD72DC97828B4D0989C444CFEF1193B924C97DE2E6ADA47413224D42B9F8CA93C53D0CB63E25866FD12ABD2D331FDB0386BFC20D70DE8A37DC7222ED13D114FBFCDC039B080438A751B5A73F2986DDE0F5C7FF016D4CA25225820000, N'6.2.0-61023')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201906090338489_AutomaticMigration', N'ExamenesUniversidad.Datos.Migrations.Configuration', 0x1F8B0800000000000400ED5DDB6EE4B8117D0F907F10F494045EB72F33406274EF62B66D07C6AEED81DB5EE4CD604B745B88447544CAB011E4CBF2904FCA2F84BA4BBC89D4ADDB8E312F6E91AC228B87C5629155F3DF7FFF67FED36BE05B2F30C25E8816F6F1E1916D41E484AE87360B3B264F3FFCD9FEE9C7DFFF6E7EE106AFD66F45BDD3A41E6D89F0C27E26647B369B61E71906001F069E1385387C22874E18CC801BCE4E8E8EFE323B3E9E414AC2A6B42C6B7E1723E20530FD417F2E43E4C02D89817F1DBAD0C7F9775AB24AA95A372080780B1CB8B02F5EE9DF08E207E4A5DD76817B780E48880FCFD7940E81AF04DBD637DF03B46F2BE83FD91640282480D09E9F3D60B822518836AB2DFD00FCFBB72DA4F59E808F613EA2B3AABAEEE08E4E92C1CDAA86052927C6240C0C091E9FE6D29AB1CD3BC9DC2EA549E57941E54EDE9251A7325DD8CB38C2A16DB19CCE967E94D452C93BA1457F417C981239B0A4550F4AE4508025FF0EAC65EC9338820B04631201FFC0FA1EAF7DCFF905BEDD877F87688162DFAFF79CF69D96353ED04FDFA3700B23F276079FF2F15CB9B6356BB69BB10DCB66B536D960AF10393DB1AD1BCA1CAC7D5802A32698150923F8573ACC0810E87E0784C0082534602A5A8E3BC36B4997D6262CF8512CD285665BD7E0F5578836E47961D33F6DEBD27B856EF125EF03952A5D97B4118962D8C6E6260CD6111C9ECD0D78F136A9201886C5DCDBD61DF4D30AF8D9DB662B30C3C76355E5320A83BBD02FE057963CAEC23872926E87C2E27B106D20D1EFD4F7086EA8A601AA5ED5EAB0DD2A8B24FDAACA451D9BCFAAC5A65C82D9F0FAAEC1ACCEE722DCA345F86DEDD15F259F9F438A1D8004235393B984CE33B8A28CBD92149D50784F37D06EB42E3DD49B50BA02DAE74C4D84FE7C82388C8CE948577CBE9DF5D141C55A96E8A04215982946B526CAEA3C7255AB3E8A6B707A4952CD5C6F66F322EC6C5128942557C88993AF2192A8A1F22C863A8C122DA87D2A531D657A1307300AAB19E8A710322A7D154B366FC3A9950B4C62D703F4747147CF2131C4D295CC577C64215A5BD5ADB5B9E5A3D1A49B861A563171DD56EB2F53834EA298720128BA2BAB235053928AFDB4153F7BBD55164FF2536FE9E8ADDA0CF45235A5FC87515A9D55A086F26A51598F623527D257C2AA0A6525AEDFCF969A4601732696BECEEEA92286D30C9F0A41DF90598208A518EEB19233EF0B1EFF80B985BEEFB9E1F89CB2113DE01844DEF807E7A50F5E26755E999B77BD75A55CAFA8756B27A532D4F9E8F36464E66642183A31F15EC65F321728468E07DCF13995983C9E8ED5C974AC4EA763F5653A565FA763B50CA3083A7DCDEA6EFEC5CE7E41AD5B00B167B0FB6956C735D8EB50CBEE31ADA7DF8E9B4BE12DECBBB964743E3717ADCD05BAB1DF73917DDAA9EFCC4E555DB21AFAE579DD20F3DCEB28856F1887D4FC48BAC4D9D46253B939E40BE45A86767326F4A6554EA54FD581B7A50A807672611F73B2D567546A7B11A39AF3A8C9F14F1C47AA526094AC69E027062155521E22BCFEF1A8F9B605BE991418329A8A2C99C692215B720EB710253AC84C4C3A3D69BACAF83E95AC19B5DB26C1F9AC063F5D544ADD43ED7869F715F5848C1153114E198717BB2858C9DFA273E84302AD6F4EF64A6909B043F7647E07A43D1B14DD6DA39A14E06DF3AA8571CE89BB139C4BCD4619D0DA6DC80A5E7260C981DC7EF1A20BDF81346CDB8027405E9B4C74BAB073A449AE08A50AADE521038B02A31DBDE52E726284A9873A856653CA435F9BED508BB126AD5CBD48EDDBBADE2A0EAA267A4BFAA0A50DAA83292AC9D026D15092D1EBA9A6EA75D74EE0C33CF9924DB1EC0D6A35BFB9F7481F35B227651341463CA209F0221EB70EE3D2DFB743A4B4EF5ED277C1BDB1A2DCAE46DEA824A39A0C2F9DB6A6290193F93C92E812DA02468C37A6E6A5CC0350049ED0070C736728CEBD3E2C1E12162B48EAC3C3B655B95B9AF8E2E0D46C5EF980380285E6D1A250F3374B0855D86C2328BC30E5A98A0ECCDAA4D5145B09A986AB3DD062DF1376A6B241182A35E8890626B96FAEB5D2BCA266578BB9E7AD1C2F23786E219AFBDA84A4EBE365FD114DA9194954FE3E4825543DB75157C791E1F8BBBA8AEA6CD865DE5BC2F21B2B5EAE7A6E0A3347456D70D26199B926461597EC89AD00841A276D93B33637ACB645AC3E5E8F0C2AEE72438426E57151F3C0D8C04FA5C99500929D113544DC41186C280B2F09D5C947E7EC53EB77618828C62F39ED8C3978E542515AF35AF67C97F12B574497B550DCB595766759369F6571D1F987F94C12403DBF06DBAD8736B580EAFC8BB5CAA2A9973FACCC838A838CC6CC698896B5924B4E248CC00632A569101EBCF4224CCE01016B905C8B2EDD80ABA6B0B2256658C1B86148F3B357186645F5E46FA961CF8598E776387F52C9C95DD23107C94127BDE667F1C4B7B3925877E08348F0A46019FA7180E4072E79EB22D0B14EA1F8A64FA50826AE5329BEF154E6334604DCF98C933D77C9D49C49AD795628BB9E339D1F98CCA75AD6709FE7BA8C59AD93293FEAD36904ADD669350A0CE9A581AB1CB1F4AB819C0AC7414350326F829C4EDDBD5927A5727BEE7875A8B6C4411689EC34A4BD58E404C659346CF06243C5316526D0A82EE59AD0905FD6C9A9559730755AF2AB99DD814CCFDFD0176902075107B8E95019077335BF569D88D4DDA5C446E3494D031FCAC7366D689321B8FD79C31EA06F54D0F5C2DAB46AAD0865E2955A51626A0362911128381CC9E9D49E82362C8CEAB3699FCAC79E7CCFCA2203EB207BD2D9B00DB24F7B03F41177F11EFBF7D43B7723B8A669F3D60A0CF45E1540D35078D5E70E1AFE58A2E2B9FB402D6A27126A279DA89D4AA89D76A2F64542ED4B276A5F25D4BE76A25645A4088956C5E31D2276A62A4A07E608BA22BFC9EAA22B644D47D21579AC4463B2F26F9F5BE0DE6E819C0394AD52722F1DA18CC3739E3B1FDBD34A72DEC8AC8A6D51E1BC786EE2895CBD610283642180C3D53FFCA5EFD1F15615AE01F228AA491676649F1C1D9F307928F72727E40C63D717386FB9C490CDC99A2070CA4B44DA1A1A651A4CD8C8F7865E40E43C83E80F0178FD639D967962450352A6E9003F252FF34C66B4D61E1922939E4BC74986C8A4D7991013E99A4E03F77CE80AB9F07561FF336D73665DFDED316F7660DD4654F99C5947D6BF06C8BFA7CBBD6A69D081AE49DD3EC65210E7494B59F5CE92A63F6D45CB5EB861D3ABE9B22FDA8D82993687DEBB050E97A8AA0B664469AAB4A7ADD67600DC74872FDB7E5C1C7D10F888D21A754110132CDE6F2F6703C207B0C998A0EF5E141B81DD6318791F6C6F1364BAE9257F2E9B4D2F6A7CC69A61C89D0C4BEE7458725F8625F77558726C96982E1A6932CBD93C15CA0759D68D1C239F9BC6B49BC618393506CD9BC119A63B4B92B1A33C01FF0F592F98D888DD6499D84BF4B5BD78DA1F04BEF39C14BD934F7406F1C0B926A60BFA37E2B8736474CA213148B288DD6142FAAA781F10F1EEF23EF4CEF3A08DA981B33A4C07808F97B3A15FDCFDD4332E0B18D9E574BFA3AC0BFD26DBC894786F136EA4DA779F37810FFC62674D900A419E09217BA8B1B0DD758291EC902D0EDA93E43850E44810D196C6328AA957209370A92AC8B9C9C30739A6A2F30FCF59544BC85E270A5FDE87966C0C6A8EED8C14B2554B555F9E952D216051148959C86287F72AD58324E78032DE558131696C45FFC0DF5D646E10AE6051B8D2FE896BA2340CC22867B538BA0A751F932B08BABF37831F2D6782304782C6B03584B507D910F8E8FF1D0F6DC85C078683335AE5C3A432E05FEC520394B22BFEBB786AFD626F539148FEF378049D86E959D6B9424F616102333D2AAA309738D7900097DAA5DF22E23D0187D06207629C6676FF0DF87132E3C11ABA57E83626DB98D021C360ED37D2F52796B48A7F9AAFA1D9E7F9ED364DE73EC4106837BDE435E22DFA39F67CB7ECF7A5E06253422231D1F37BC4642E49729FB8792B29DD844893502EBEF264710F83AD4F89E15BB44A6FCBCCFBF680E1AF70039CB7E2E1B59C48FB4434C53E3FF7C0260201CE6954EDE94F8A613778FDF17F5598F50335810000, N'6.2.0-61023')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201906142357256_AutomaticMigration', N'ExamenesUniversidad.Datos.Migrations.Configuration', 0x1F8B0800000000000400ED1DCB6EE4B8F11E20FF20E894045EB71F33406274EF62B66D07C6AEED81DB5EE466B025BA2D44A23A2265D808F26539E493F20BA1DE125F22F5EAB663CCC52D9255AC6255B15864D5FCF7DFFF99FFF41AF8D60B8CB017A2857D7C78645B1039A1EBA1CDC28EC9D30F7FB67FFAF1F7BF9B5FB8C1ABF55BD1EF34E9474722BCB09F09D99ECD66D8798601C08781E744210E9FC8A1130633E086B393A3A3BFCC8E8F679082B0292CCB9ADFC58878014C7FD09FCB1039704B62E05F872EF471FE9DB6AC52A8D60D0820DE02072EEC8B57FA3782F80179E9B45DE01E9E0312E2C3F3358543E02BC1B6F5CDF7009DDB0AFA4FB605100A092074E6670F18AE4814A2CD6A4B3F00FFFE6D0B69BF27E0639853745675D725EEE824216E560D2C40393126616008F0F834E7D68C1DDE89E776C94DCACF0BCA77F296509DF274612FE30887B6C5623A5BFA51D24BC5EF0416FD05F1610AE4C092763D2825870A58F2EFC05AC63E8923B840302611F00FACEFF1DAF79C5FE0DB7DF877881628F6FDFACCE9DC695BE303FDF43D0AB730226F77F029A7E7CAB5AD5973DC8C1D580EAB8DC988BD42E4F4C4B66E2872B0F661291835C6AC4818C1BF52322340A0FB1D10022394C080296B39EC0CAE2555AD4D58E0A3B24815CDB6AEC1EBAF106DC8F3C2A67FDAD6A5F70ADDE24B3E07CA55AA9774108962D886E6260CD6111C1ECD0D78F13629231884C5DADBD61DF4D30EF8D9DB661A98C9C763D5E5320A83BBD02FC4AF6C795C8571E424D30E85CDF720DA40A23FA9EF11DC504B0354B3AAF561A7553649E655B58B26369F55CAA654C18CBCBE3A98F5F954C23D52C26F6B8FFE2AF1FC1C52D9014840991ACC25749EC11545EC95A0E882C27BBA81768375E9A1DE80520D685F333510FAF309E230328623D5F87C3BEB63830A5D96D8A0C214981946B525CAFA3C725DAB398A7B707649D2CDDC6E66EB229C6CD128E425D7C8B193EF21E2A8A1F12C481DC68816D03E8DA98E31BD89031885D50AF433081994BE86255BB7E1CCCA0526B1EB017ABAB8A3E7901862A926F31D1F5911AD69756B6F4E7D348674B350C31A266EDA6AFB65EAD0490C53CE00C574657D04664AD2B19FB5E257AFB7C9E2417EDA2D1DBB555B813EA666194611742A285DBDBC6A1D87317E9D4DA986116C317D8F627329B27BC2AE0AA327EEDFCF279BC69073AE9ABEEDEF696A86B3309F8645DF215A8208A532DC4393B3280E1EFFA0BA85BEEFB9E1F898328A1E700C226FFC03F8D2072F9306C1CCDDC4DEB6526E57D4B6B5935119EA9CF579C2320B57210C9D98782FE3ABCC058A91E301777C4CA54C1E4F87EA643A54A7D3A1FA321DAAAFD3A1621DEB8EEE79A73865E7F8A2D66D8238C2D8FD54AC1362EC753866F798D65374C7CDA5883AF6DD5C32389F9B8BD6E602DDD8EFA9649F7EEA3BF3535597B586F17DDE36C86E00748CC2378C43EA7E2453E27C6AB1ABDC24F902B996A1DF9C31BDE99553EE5373E06DA901A0935CD8C71C6FF51195D65E84A816846A62FC1387919A1418253A0DFCC421A446CA4384B73F1E75DFB6C037E3020346D39025CB5822645BCEE116A2C40699B1496726CD50193FA712356376DB38389FD5C44F572AA5E1A17679698F15F5141923A4223965025EAC52B09CBF45E7D087045ADF9CECB5D3126087EEC9FC0E486736A874B75135A980B7ADAB968C7341DC9DC8B9D46D94095ABB0F5989975CB0E482DC7E81A32BBE0359D836822790BC369EE84C61E79226B96A941AB4960711AC1418EDE82D779A134B989AD4292C9B921FFAD66C87568C7569E5E645EADFD6ED56715035B15BD287316DA23A98A192903689859250AF679AAA57623B111FE6E9986C89656F59ABF5CDA347FA52237B9A3691C888299A405EC474EB202EE37D3B9494F6DD4BFABEB8B7AC28B7AB91372A095593C94BA7AD694A81C9621E49960A1D0123261A538B52E6892C8248E80386793014E7511F561E12142B48EAE461DBAAC22D4DF9E2C4A939BC8A0171000ACBA305A1166F9600AA64B30DA0F0C294872A3A306B8356436C05A422579BD062DF134EA6F241182835D1131126B96FAE8DD2BCA266B5C53CF256D2CB309E5344F3589B10749D5E361ED1E49A1147E5EF83544CD50B1B750D1C19D2DF35545447C3AA796F0ECB6FAC78BEEA8529CC021535E2A464998526466597ECA9AE4008354EDA26676D8EAC3625561FAF47162AEE7243244DCAE3A2E681B1213F9525570A90EC8CA8C1E20ECC605362784EA84E3E3A679FDABC0B474441BFE4B43326F14A45517AF35AFE7C17FA951AD145178ABBB6D2EF2CDBE6B32CBF3AFF309F4912B1E7D760BBF5D0A696989D7FB1565956F6F2879579727290C198390DD6B25E7289898411D840A6354DE683975E84C93920600D926BD1A51B70DD145EB6C40D2B10371C697EF50AC7ACE89EFC2D75ECB954F5DC0FE74F2A39B84B4A73901C74D26B7E569EF8715692330F7C10099E142C433F0E90FCC0251F5D244CD62114DFF4A11449C97528C5371ECA7CC6B0803B9F71BCE72E999A2BA9B5CE0A63D773A5F30393F952CB06EEF35A97B9AF7530E5477D388DE4D73AAC468321BC34019603967E35E053113868304A164D90C3A98737EBA05461CF1D6B876A4B1C444964A7216D659103184769D824C8868963DA4C44A3BA946B8A86FCB24E0EADBA84A9C3925FCDEC4EC8F4E20D7D254D1020EA206E3A50C691B95A5CAB0E441AEE52C1AA1EDB36CD7EF1D540CA1A8F731A92A67CB6A380C83D85E0E557AD113B97E351C5B797D44E6B208BA428DE3C162DA6DE2416B9938263961C4EED5169C357A93E9BCEA97C36CACFAC6C3250CDEC7168432FB34F7B23E823FA033D3C81A97D80469A4ED38CD61A0CEC5E958AD33078D5E70E7BC5B164B3E06E16B5A09D48A09D7482762A8176DA09DA1709B42F9DA07D9540FBDA099A78BB15348F771CD999A92843A123D88AFC4EAC8BAD900D1DC956E459178DC5CABF7D6E817BBB0572A154B64B89BD0CA932A1D3791EC66C2F74C9C535B32EB64599F3E2B9494C73F586090C12450087AB7FF84BDFA3F4561DAE01F2A854932C81C93E393A3E612A63EE4F95CA19C6AE2F080373A52A9B8B35410A9697B0B435C9CAB86A48BD021D7A0191F30CA23F04E0F58F7558E6A51E0D40991628FCE4BC2CC699C15A7B6488DA7E2EA5930C51DBAF33202667365D06EE21D21572E1EBC2FE673AE6CCBAFADB633EECC0BA8DA8F139B38EAC7F0D501150177B35D260025DCBCC7D0C5510576E4B51F5AEDBA6BF6CC5C85E72C3167CD3455F8C1B4566DA4283EF5670B8D2595D6486CDEFEF623E4545B3B497BE367600D9EBAE02ECF87165F18388A0A8C85217296452D7FBF9036C7AFA007E1D9382DE0B6223CD7C0C47F183ED8F82BA3BBDF8CFD5D6E9058DAF9F330CB89361C19D0E0BEECBB0E0BE0E0B8EDDD33AED8B5379DFE685593E885A372A9E7C6E1AD36E1A6354F818B48A07E7DCEEAC64C78EAA16FC3FD4E06032357653F3622FA5AFEDFDD5FE48E03BAF90D1BB144667211EB8F2C57425088C30EE5C323A55B418A474C5EE6442FAC6791F24E2DD55A1E85D75425BA606AE31319D007CBC0A12FDAA004CBDE2B2F4955D2EF73BAA01D16FB18D5C89F7B6E046A67DF7551CF8343476D5048519E47519B2C71E0BDB5D2732921DB2C52984928A0B8A8A0D22D8D2CC4A31F44AC82458AA0E726CF264460EA9E8FCC36316F512A2D7A909209F434B6D0835C676440ADEAAB9AACFCFCA9710A0289AC4286499CC7B557842520141997DAB903169A647FF34E45DD491106AB028796AFFD83551510861CEB59A1D5D99BA8FA51E04D3DF1BE247ABE020ACD8A041B606B3F6A036035F8B60C7A40D5979C19038232D1FA6B002FFEA973AA0149D17649723D4FBC5DEA60231A73011741AAE67D9E70A3D85850BCCCCA8E8C25CE25C43025CEA977E8B88F7041C429B1D88715A67FE37E0C7C98A076BE85EA1DB986C63424986C1DA6FFCE7018927ADC29F568F68CE797EBB4D8BCB0F41029DA697BC68BC453FC79EEF96F3BE145C6C4A40242E7A7E8F98AC2549EE13376F25A49B106902CAD9579E2CEE61B0F529307C8B56E96D99F9DC1E30FC156E80F3563CDE9603695F8826DBE7E71ED84420C0398C6A3CFD4965D80D5E7FFC1F8D936F8A0B820000, N'6.2.0-61023')
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([Id], [Codigo], [Nombre]) VALUES (2, N'03v3s', N'Medicina')
INSERT [dbo].[Cursos] ([Id], [Codigo], [Nombre]) VALUES (6, N'y6a1m', N'Matemáticas')
SET IDENTITY_INSERT [dbo].[Cursos] OFF
SET IDENTITY_INSERT [dbo].[EstudianteRespuestas] ON 

INSERT [dbo].[EstudianteRespuestas] ([Id], [Respuesta], [EstudianteId], [ExamenPreguntaId], [Correcta]) VALUES (1, 4, 2, 11, 1)
SET IDENTITY_INSERT [dbo].[EstudianteRespuestas] OFF
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 

INSERT [dbo].[Estudiantes] ([Id], [NumeroCarnet], [Nombres], [Apellidos], [NombreUsuario], [Clave]) VALUES (2, 123456, N'Johana', N'Cely', N'estudiante', N'e4e4564027d73a4325024d948d167e93')
INSERT [dbo].[Estudiantes] ([Id], [NumeroCarnet], [Nombres], [Apellidos], [NombreUsuario], [Clave]) VALUES (3, 1111, N'Prueba', N'Prueba', N'prueba1', N'3f1b7ccad63d40a7b4c27dda225bf941')
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([Id], [Codigo], [Abierto], [FechaInicio], [FechaFin], [CursoId], [ProfesorId]) VALUES (1, N'f4tg5', 1, CAST(N'2019-06-09T20:27:41.007' AS DateTime), CAST(N'2019-07-09T20:27:41.007' AS DateTime), 2, 1)
INSERT [dbo].[Examenes] ([Id], [Codigo], [Abierto], [FechaInicio], [FechaFin], [CursoId], [ProfesorId]) VALUES (3, N'12s5r', 1, CAST(N'2019-06-12T19:28:07.307' AS DateTime), CAST(N'2019-06-13T19:28:07.000' AS DateTime), 2, 1)
INSERT [dbo].[Examenes] ([Id], [Codigo], [Abierto], [FechaInicio], [FechaFin], [CursoId], [ProfesorId]) VALUES (4, N'cn0bs', 1, CAST(N'2019-06-12T19:30:28.787' AS DateTime), CAST(N'2019-06-14T19:30:28.000' AS DateTime), 2, 1)
INSERT [dbo].[Examenes] ([Id], [Codigo], [Abierto], [FechaInicio], [FechaFin], [CursoId], [ProfesorId]) VALUES (5, N'm4ncl', 1, CAST(N'2019-06-12T19:46:37.300' AS DateTime), CAST(N'2019-06-13T03:46:37.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[Examenes] OFF
SET IDENTITY_INSERT [dbo].[ExamenPreguntas] ON 

INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (1, 1, 2, 1)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (2, 2, 5, 1)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (3, 3, 3, 1)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (4, 1, 4, 3)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (5, 2, 2, 3)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (6, 3, 5, 3)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (7, 4, 1, 3)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (8, 1, 3, 4)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (9, 2, 2, 4)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (10, 3, 4, 4)
INSERT [dbo].[ExamenPreguntas] ([Id], [NumeroPregunta], [PreguntaId], [ExamenId]) VALUES (11, 1, 1, 5)
SET IDENTITY_INSERT [dbo].[ExamenPreguntas] OFF
SET IDENTITY_INSERT [dbo].[Preguntas] ON 

INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (1, N'2oer2', N'¿Cuál es la parte del cuerpo que transporta sangre por todo el cuerpo?', N'Cerebro', N'Estómago', N'Pies', N'Corazón', N'Nariz', 4, 2)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (2, N'zbu6w', N'¿De qué color es la sangre humana?', N'Roja', N'Verde', N'Blanca', N'Amarilla', N'Transparente', 1, 2)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (3, N'plmv9', N'¿Cuántos huesos tiene un ser humano adulto?', N'196', N'217', N'206', N'200', N'203', 3, 2)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (4, N'x0wpb', N'¿Cuantos dientes tiene un ser humano adulto?', N'16', N'34', N'20', N'23', N'32', 5, 2)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (5, N'roto2', N'¿Cuanto debe dormir una persona al día?', N'2', N'8', N'3', N'6', N'13', 2, 2)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (6, N'xx1zp', N'gjdfjgfd', N'khgvfhjf', N'hkgkhgkh', N'hjgkhgk', N'khgkh', N'jghkhg', 1, 6)
INSERT [dbo].[Preguntas] ([Id], [Consecutivo], [Enunciado], [Respuesta1], [Respuesta2], [Respuesta3], [Respuesta4], [Respuesta5], [RespuestaCorrecta], [CursoId]) VALUES (7, N'asrkd', N'aaaaaa', N'aaa1', N'aaa2', N'aaa3', N'aaa4', N'aaa5', 2, 2)
SET IDENTITY_INSERT [dbo].[Preguntas] OFF
SET IDENTITY_INSERT [dbo].[Profesores] ON 

INSERT [dbo].[Profesores] ([Id], [Cedula], [Nombres], [Apellidos], [NombreUsuario], [Clave]) VALUES (1, 123, N'Cristian', N'Barreto', N'profesor', N'793741d54b00253006453742ad4ed534')
SET IDENTITY_INSERT [dbo].[Profesores] OFF
/****** Object:  Index [IX_EstudianteId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_EstudianteId] ON [dbo].[EstudianteRespuestas]
(
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamenPreguntaId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_ExamenPreguntaId] ON [dbo].[EstudianteRespuestas]
(
	[ExamenPreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CursoId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_CursoId] ON [dbo].[Examenes]
(
	[CursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfesorId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_ProfesorId] ON [dbo].[Examenes]
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExamenId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_ExamenId] ON [dbo].[ExamenPreguntas]
(
	[ExamenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PreguntaId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_PreguntaId] ON [dbo].[ExamenPreguntas]
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CursoId]    Script Date: 14/06/2019 21:36:38 ******/
CREATE NONCLUSTERED INDEX [IX_CursoId] ON [dbo].[Preguntas]
(
	[CursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EstudianteRespuestas] ADD  DEFAULT ((0)) FOR [Correcta]
GO
ALTER TABLE [dbo].[EstudianteRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EstudianteRespuestas_dbo.Estudiantes_EstudianteId] FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiantes] ([Id])
GO
ALTER TABLE [dbo].[EstudianteRespuestas] CHECK CONSTRAINT [FK_dbo.EstudianteRespuestas_dbo.Estudiantes_EstudianteId]
GO
ALTER TABLE [dbo].[EstudianteRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EstudianteRespuestas_dbo.ExamenPreguntas_ExamenPreguntaId] FOREIGN KEY([ExamenPreguntaId])
REFERENCES [dbo].[ExamenPreguntas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EstudianteRespuestas] CHECK CONSTRAINT [FK_dbo.EstudianteRespuestas_dbo.ExamenPreguntas_ExamenPreguntaId]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Examenes_dbo.Cursos_CursoId] FOREIGN KEY([CursoId])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_dbo.Examenes_dbo.Cursos_CursoId]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Examenes_dbo.Profesores_ProfesorId] FOREIGN KEY([ProfesorId])
REFERENCES [dbo].[Profesores] ([Id])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_dbo.Examenes_dbo.Profesores_ProfesorId]
GO
ALTER TABLE [dbo].[ExamenPreguntas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamenPreguntas_dbo.Examenes_ExamenId] FOREIGN KEY([ExamenId])
REFERENCES [dbo].[Examenes] ([Id])
GO
ALTER TABLE [dbo].[ExamenPreguntas] CHECK CONSTRAINT [FK_dbo.ExamenPreguntas_dbo.Examenes_ExamenId]
GO
ALTER TABLE [dbo].[ExamenPreguntas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExamenPreguntas_dbo.Preguntas_PreguntaId] FOREIGN KEY([PreguntaId])
REFERENCES [dbo].[Preguntas] ([Id])
GO
ALTER TABLE [dbo].[ExamenPreguntas] CHECK CONSTRAINT [FK_dbo.ExamenPreguntas_dbo.Preguntas_PreguntaId]
GO
ALTER TABLE [dbo].[Preguntas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Preguntas_dbo.Cursos_CursoId] FOREIGN KEY([CursoId])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Preguntas] CHECK CONSTRAINT [FK_dbo.Preguntas_dbo.Cursos_CursoId]
GO
USE [master]
GO
ALTER DATABASE [ExamenesUniversidad] SET  READ_WRITE 
GO
