--CREATE AND RUN A CLE SQL SERVER STORED PROCEDURE


--SP CONFIGURE AND CLR ENABLED
sp_configure 'clr enabled', 1;

GO
	RECONFIGURE;
GO 
	ALTER DATABASE CodingPlayground
		SET TRUSTWORTHY ON;
GO