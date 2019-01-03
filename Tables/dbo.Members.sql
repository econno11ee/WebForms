CREATE TABLE [dbo].[Members]
(
[ID] [uniqueidentifier] NOT NULL,
[EmailAddress] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[FirstName] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[LastName] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Members] ADD CONSTRAINT [PK_dbo.Members] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO
