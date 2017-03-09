CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Type] TINYINT NOT NULL, 
    [NormalHp] INT NOT NULL, 
    [NormalAtk] INT NOT NULL, 
    [NormalDef] INT NOT NULL, 
    [AwakeHp] INT NOT NULL, 
    [AwakeAtk] INT NOT NULL, 
    [AwakeDef] INT NOT NULL, 
    [Steps] SMALLINT NOT NULL, 
    [BloomAvailable] BIT NOT NULL
)
