USE ShopAdo;
GO
IF (OBJECT_ID('[User]', 'U') IS NOT NULL)
   DROP TABLE [User];
GO
CREATE TABLE [User]
(
   UserId INT IDENTITY  PRIMARY KEY,
   UserName NVARCHAR(128) NOT NULL,
   UserPassword NVARCHAR(128) NOT NULL,
   FirstName NVARCHAR(128) NOT NULL,
   LastName NVARCHAR(128) NOT NULL,
   Birthday Date NOT NULL
)

GO

SET IDENTITY_INSERT  [User] ON;
INSERT INTO [User](UserId, UserName,
   UserPassword ,
   FirstName ,
   LastName ,
   Birthday)
VALUES 

(1, 'pasha@gmail.com', '123', 'Pasha', 'Ivanov', '22.04.1990'),
(3, 'masha@gmail.com', '123', 'Masha', 'Petrova', '31.12.1997'),
(5, 'dasha@gmail.com', '123', 'Dasha', 'Ivanova', '11.08.1998');
SET IDENTITY_INSERT  [User] OFF;
GO
IF (OBJECT_ID('Role', 'U') IS NOT NULL)
   DROP TABLE Role;
GO

CREATE TABLE Role
(
  RoleId INT IDENTITY PRIMARY KEY,
  RoleName NVARCHAR(32)
)
GO
SET IDENTITY_INSERT  Role ON;
INSERT INTO Role (RoleId, RoleName)
VALUES (1, 'Admin'), (2,'Moderator'),(3, 'Manager');
SET IDENTITY_INSERT  Role OFF;


IF (OBJECT_ID('UserInRole', 'U') IS NOT NULL)
   DROP TABLE UserInRole;
Create table UserInRole
(
  UserId INT NOT NULL,
  RoleId INT NOT NULL
)

GO
ALTER TABLE UserInRole ADD constraint pk_UserInRole PRIMARY KEY(UserId, RoleId)
INSERT INTO UserInRole(UserId, RoleId)
VALUES
 (1,1), (2,3),
 (3,2), (5,3);
