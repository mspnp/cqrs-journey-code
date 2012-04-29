/****** Object:  Schema [ConferenceManagement]    Script Date: 04/27/2012 15:34:52 ******/
CREATE SCHEMA [ConferenceManagement] AUTHORIZATION [dbo]
GO
/****** Object:  Schema [ConferencePayments]    Script Date: 04/27/2012 15:34:52 ******/
CREATE SCHEMA [ConferencePayments] AUTHORIZATION [dbo]
GO
/****** Object:  Schema [ConferenceRegistration]    Script Date: 04/27/2012 15:34:52 ******/
CREATE SCHEMA [ConferenceRegistration] AUTHORIZATION [dbo]
GO
/****** Object:  Schema [ConferenceRegistrationProcesses]    Script Date: 04/27/2012 15:34:52 ******/
CREATE SCHEMA [ConferenceRegistrationProcesses] AUTHORIZATION [dbo]
GO
/****** Object:  Schema [Events]    Script Date: 04/27/2012 15:34:52 ******/
CREATE SCHEMA [Events] AUTHORIZATION [dbo]
GO
/****** Object:  Table [Events].[Events]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Events].[Events](
	[AggregateId] [uniqueidentifier] NOT NULL,
	[Version] [int] NOT NULL,
	[Payload] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[AggregateId] ASC,
	[Version] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceRegistration].[ConferencesView]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceRegistration].[ConferencesView](
	[Id] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[StartDate] [datetimeoffset](7) NOT NULL,
	[IsPublished] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceRegistrationProcesses].[RegistrationProcess]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceRegistrationProcesses].[RegistrationProcess](
	[Id] [uniqueidentifier] NOT NULL,
	[Completed] [bit] NOT NULL,
	[ConferenceId] [uniqueidentifier] NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[ReservationId] [uniqueidentifier] NOT NULL,
	[ReservationAutoExpiration] [datetime] NULL,
	[ExpirationCommandId] [uniqueidentifier] NOT NULL,
	[StateValue] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceRegistration].[OrdersView]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceRegistration].[OrdersView](
	[OrderId] [uniqueidentifier] NOT NULL,
	[ReservationExpirationDate] [datetime] NULL,
	[StateValue] [int] NOT NULL,
	[RegistrantEmail] [nvarchar](max) NULL,
	[AccessCode] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceManagement].[Conferences]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceManagement].[Conferences](
	[Id] [uniqueidentifier] NOT NULL,
	[AccessCode] [nvarchar](6) NULL,
	[OwnerName] [nvarchar](max) NOT NULL,
	[OwnerEmail] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Slug] [nvarchar](max) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[WasEverPublished] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferencePayments].[ThirdPartyProcessorPayments]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferencePayments].[ThirdPartyProcessorPayments](
	[Id] [uniqueidentifier] NOT NULL,
	[StateValue] [int] NOT NULL,
	[PaymentSourceId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  View [ConferencePayments].[ThirdPartyProcessorPaymentDetailsView]    Script Date: 04/27/2012 15:34:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [ConferencePayments].[ThirdPartyProcessorPaymentDetailsView]
AS
SELECT     
    Id AS Id, 
    StateValue as StateValue,
    PaymentSourceId as PaymentSourceId,
    Description as Description,
    TotalAmount as TotalAmount
FROM ConferencePayments.ThirdPartyProcessorPayments
GO
/****** Object:  Table [ConferencePayments].[ThidPartyProcessorPaymentItems]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferencePayments].[ThidPartyProcessorPaymentItems](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[ThirdPartyProcessorPayment_Id] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceManagement].[SeatTypes]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceManagement].[SeatTypes](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ConferenceInfo_Id] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceRegistration].[OrderItemsView]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceRegistration].[OrderItemsView](
	[Id] [uniqueidentifier] NOT NULL,
	[SeatType] [uniqueidentifier] NOT NULL,
	[SeatTypeDescription] [nvarchar](max) NULL,
	[RequestedSeats] [int] NOT NULL,
	[ReservedSeats] [int] NOT NULL,
	[OrderDTO_OrderId] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [ConferenceRegistration].[ConferenceSeatsView]    Script Date: 04/27/2012 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ConferenceRegistration].[ConferenceSeatsView](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ConferencesView_Id] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  ForeignKey [ConferenceInfo_Seats]    Script Date: 04/27/2012 15:34:51 ******/
ALTER TABLE [ConferenceManagement].[SeatTypes]  WITH CHECK ADD  CONSTRAINT [ConferenceInfo_Seats] FOREIGN KEY([ConferenceInfo_Id])
REFERENCES [ConferenceManagement].[Conferences] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [ConferenceManagement].[SeatTypes] CHECK CONSTRAINT [ConferenceInfo_Seats]
GO
/****** Object:  ForeignKey [ThirdPartyProcessorPayment_Items]    Script Date: 04/27/2012 15:34:51 ******/
ALTER TABLE [ConferencePayments].[ThidPartyProcessorPaymentItems]  WITH CHECK ADD  CONSTRAINT [ThirdPartyProcessorPayment_Items] FOREIGN KEY([ThirdPartyProcessorPayment_Id])
REFERENCES [ConferencePayments].[ThirdPartyProcessorPayments] ([Id])
GO
ALTER TABLE [ConferencePayments].[ThidPartyProcessorPaymentItems] CHECK CONSTRAINT [ThirdPartyProcessorPayment_Items]
GO
/****** Object:  ForeignKey [ConferenceDTO_Seats]    Script Date: 04/27/2012 15:34:51 ******/
ALTER TABLE [ConferenceRegistration].[ConferenceSeatsView]  WITH CHECK ADD  CONSTRAINT [ConferenceDTO_Seats] FOREIGN KEY([ConferencesView_Id])
REFERENCES [ConferenceRegistration].[ConferencesView] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [ConferenceRegistration].[ConferenceSeatsView] CHECK CONSTRAINT [ConferenceDTO_Seats]
GO
/****** Object:  ForeignKey [OrderDTO_Lines]    Script Date: 04/27/2012 15:34:51 ******/
ALTER TABLE [ConferenceRegistration].[OrderItemsView]  WITH CHECK ADD  CONSTRAINT [OrderDTO_Lines] FOREIGN KEY([OrderDTO_OrderId])
REFERENCES [ConferenceRegistration].[OrdersView] ([OrderId])
GO
ALTER TABLE [ConferenceRegistration].[OrderItemsView] CHECK CONSTRAINT [OrderDTO_Lines]
GO
