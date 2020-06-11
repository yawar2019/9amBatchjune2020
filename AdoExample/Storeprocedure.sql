USE [Employee]
GO
/****** Object:  StoredProcedure [dbo].[spr_deleteEmployeeDetails]    Script Date: 6/11/2020 9:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER PROCEDURE [dbo].[spr_deleteEmployeeDetails]
  @empid int
  AS
  BEGIN
  Delete employeeDetails  where empid=@empid
  END



  USE [Employee]
GO
/****** Object:  StoredProcedure [dbo].[spr_getEmployeeDetails]    Script Date: 6/11/2020 10:00:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER PROCEDURE [dbo].[spr_getEmployeeDetails]
  AS
  BEGIN
  SELECT  * FROM employeeDetails order by 1 desc 
  END

  --Delete  from employeeDetails  where empsalary is null


  USE [Employee]
GO
/****** Object:  StoredProcedure [dbo].[sp_employee]    Script Date: 6/11/2020 10:00:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_employee]
As
BEGIN

select * from Employee.dbo.employeeDetails
END


USE [Employee]
GO
/****** Object:  StoredProcedure [dbo].[spr_updateEmployeeDetails]    Script Date: 6/11/2020 10:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER PROCEDURE [dbo].[spr_updateEmployeeDetails]
  @empid int,
  @empname nvarchar(50),
  @empsalary int
  AS
  BEGIN
  update employeeDetails set empname=@empname,empsalary=@empsalary where empid=@empid
  END