USE 酒店管理系统
GO
CREATE TABLE 管理员(
[编号][CHAR](20) NOT NULL PRIMARY KEY,
[姓名][CHAR](20) NULL,
[密码][CHAR](20) NULL,
[部门][CHAR](20) NULL,
[职位][CHAR](20) NULL,
[等级][CHAR](20) NULL,
[权限][CHAR](20) NULL
)
GO