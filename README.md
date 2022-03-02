# AddTwoArguments
This project is a simple console application created in .NET 6.0. 
This application also use Sql Server, Ef Core 6, Migrations for managing database operations.
NUnit has been used for unit testing the Extension method as requested. Positive scenarios with one exception scenario has been covered. 

# Instruction on how to run the project:
1. Download or clone the project from this repo.
2. Allow it to restore the dependencies.
3. Go to the .Data Project -> DbContexts -> DesignFactory class. Change the Configuration to your SQL Server Address.
4. Open Package Manager Console -> Choose .Data Project as target and also set the same project as startup project.
5. Run Update-Database command to apply all the migrations and create a new db id needed on your own SQL Server.
6. Then set the actual TwoArgumentsAdd Project as start up. 
7. To pass in the project arguments go to the project properties -> Debug -> Commandline arguments on the above project.
8. Any issues reach out to me.
## Note: This project only allows you to only work with two arguments atmost of type int, double, float and string.  
