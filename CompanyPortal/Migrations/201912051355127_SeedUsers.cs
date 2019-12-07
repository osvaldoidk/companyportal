namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'05dbee10-76b9-41b1-a64c-f0547c5e47c8', N'engineeringadmin@company.com', 0, N'AHseU9mXFrQWjnbYnPOeUTvwOFFv8hZCn6OV6Kw9nXdBZq+2o38RVWytSlgm3llvyg==', N'e1032567-0694-4861-b5cd-cf2cc3686926', NULL, 0, 0, NULL, 1, 0, N'engineeringadmin@company.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0607d7ee-3807-4e0c-806e-5302e185caab', N'generaladmin@company.com', 0, N'ABo+ziAGgImxQj46TC10nafPA3izC4beARXchvWSAe4tbXTffpoAmbwvb28pOtL50w==', N'65124979-b388-4097-a8cf-9dae6920dcce', NULL, 0, 0, NULL, 1, 0, N'generaladmin@company.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1cd651d0-1cd6-4614-9c72-f608edcd03d7', N'salesadmin@company.com', 0, N'AIHYTBulbXRYEq+xpEk5R1ZlxX0QzYXJ/Nn4gN0iamzKPmUK1QMihzCpWLDl1HGk5A==', N'34afebbd-c5c9-4a36-9035-a928df22d6c9', NULL, 0, 0, NULL, 1, 0, N'salesadmin@company.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6a54e8ec-b2b0-4d76-9c5e-b56911447e29', N'financeadmin@company.com', 0, N'ALIyjUjUItKOJw2D20jkZR6FjMtW2zS5V464C/f8Hp1oUgymKx9BUB+kH6+UuYCMEw==', N'c221d72d-7a83-4348-83bc-4a1795995561', NULL, 0, 0, NULL, 1, 0, N'financeadmin@company.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7026b8b3-6283-4afd-a25e-6a930d44b702', N'superadmin@company.com', 0, N'AAF74dDKQcgZP78s/78a0S8Z3M28dmxErX4SxFkjAS10w8RMEHPQVY5QcEPE0VQO6A==', N'0bc3dead-0130-4eb9-8ae4-018437f80591', NULL, 0, 0, NULL, 1, 0, N'superadmin@company.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9ee9efeb-35e9-4480-aea0-9192a0a70e93', N'hradmin@company.com', 0, N'ABV0U6uV4v+vVQ9ydRDzgF1ZYylqGm6ztWQ1lYjp/psHyX3biuRzo64k0FC2UeWTtg==', N'309863f8-4641-432d-905f-802221b093a4', NULL, 0, 0, NULL, 1, 0, N'hradmin@company.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'68ae4bbc-e132-4861-9004-2807d9c2acb5', N'CanManageLink')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35017588-be00-44b6-95c3-b55b4ba17bec', N'CanViewGlobalEngLink')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cd2d947f-5901-4a46-90ab-6ad2eb62b084', N'CanViewGlobalFinanceLink')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9dde354-7064-42ea-b7a0-a81dba1c733e', N'CanViewGlobalHRLink')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6f028ec3-971a-4c80-86bd-460ae1541945', N'CanViewGlobalLink')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ae4c0110-f869-4789-843d-afef8d31c238', N'CanViewGlobalSalesLink')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'05dbee10-76b9-41b1-a64c-f0547c5e47c8', N'35017588-be00-44b6-95c3-b55b4ba17bec')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7026b8b3-6283-4afd-a25e-6a930d44b702', N'68ae4bbc-e132-4861-9004-2807d9c2acb5')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0607d7ee-3807-4e0c-806e-5302e185caab', N'6f028ec3-971a-4c80-86bd-460ae1541945')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1cd651d0-1cd6-4614-9c72-f608edcd03d7', N'ae4c0110-f869-4789-843d-afef8d31c238')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6a54e8ec-b2b0-4d76-9c5e-b56911447e29', N'cd2d947f-5901-4a46-90ab-6ad2eb62b084')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ee9efeb-35e9-4480-aea0-9192a0a70e93', N'd9dde354-7064-42ea-b7a0-a81dba1c733e')

");
        }
        
        public override void Down()
        {
        }
    }
}
