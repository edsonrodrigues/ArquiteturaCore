CREATE TABLE users (
	[id] INT NOT NULL IDENTITY,
	[user_name] VARCHAR(50) NOT NULL DEFAULT '0',
	[password] VARCHAR(130) NOT NULL DEFAULT '0',
	[full_name] VARCHAR(120) NOT NULL,
	[refresh_token] VARCHAR(500) NULL DEFAULT '0',
	[refresh_token_expiry_time] DATETIME2(0) NULL DEFAULT NULL,
	PRIMARY KEY ([id])
	
)

INSERT INTO users 
([user_name], [password], [full_name], [refresh_token], [refresh_token_expiry_time])
 VALUES
('leandro', '24-0B-E5-18-FA-BD-27-24-DD-B6-F0-4E-EB-1D-A5-96-74-48-D7-E8-31-C0-8C-8F-A8-22-80-9F-74-C7-20-A9', 
'LEANDRO DA COSTA GONCALVES', 'h9lzVOoLlBoTbcQrh/e16/aIj+4p6C67lLdDbBRMsjE=', '2020-09-27 17:30:49');