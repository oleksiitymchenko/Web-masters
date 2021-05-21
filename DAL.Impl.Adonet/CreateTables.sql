CREATE TABLE [dbo].[Article](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[SKU] [float] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[ArticleInOrder](
	[Id] [uniqueidentifier] NOT NULL,
	[ArticleId] [uniqueidentifier] NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ArticleInOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[ArticleInOrder]  WITH CHECK ADD  CONSTRAINT [FK_ArticleInOrder_Article_ArticleId] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[ArticleInOrder] CHECK CONSTRAINT [FK_ArticleInOrder_Article_ArticleId]

ALTER TABLE [dbo].[ArticleInOrder]  WITH CHECK ADD  CONSTRAINT [FK_ArticleInOrder_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[ArticleInOrder] CHECK CONSTRAINT [FK_ArticleInOrder_Order_OrderId]

CREATE TABLE [dbo].[Customer](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[DefaultAddress] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[Description](
	[Id] [uniqueidentifier] NOT NULL,
	[DescriptionTextSmall] [nvarchar](max) NULL,
	[DescriptionTextFull] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Description] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[DescriptionInArticle](
	[Id] [uniqueidentifier] NOT NULL,
	[DescriptionId] [uniqueidentifier] NOT NULL,
	[ArticleId] [uniqueidentifier] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DescriptionInArticle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[DescriptionInArticle]  WITH CHECK ADD  CONSTRAINT [FK_DescriptionInArticle_Article_ArticleId] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[DescriptionInArticle] CHECK CONSTRAINT [FK_DescriptionInArticle_Article_ArticleId]

ALTER TABLE [dbo].[DescriptionInArticle]  WITH CHECK ADD  CONSTRAINT [FK_DescriptionInArticle_Description_DescriptionId] FOREIGN KEY([DescriptionId])
REFERENCES [dbo].[Description] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[DescriptionInArticle] CHECK CONSTRAINT [FK_DescriptionInArticle_Description_DescriptionId]

CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[TaxAmount] [float] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[DeliveryAddress] [nvarchar](max) NULL,
	[BillingAddress] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer_CustomerId]