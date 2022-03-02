// See https://aka.ms/new-console-template for more information
using TwoArgumentsProj.Data.DbContexts;
using TwoArgumentsProj.Models;
try
{
    AddArguments addArguments = new();
    ArgumentDbContext argumentDbContext = new ArgumentDbContextFactory().CreateDbContext(args);
    
    addArguments.AssertIsArrayHasReqArguments<string>(args, 2);
    
    var result = addArguments.ConcatArgs(args[0], args[1]);
   
    argumentDbContext.ArgumentResults.Add(new TwoArgumentsProj.Data.Models.ArgumentResult
    {
        Arg1 = args[0],
        Arg2 = args[1],
        Result = result
    });
    argumentDbContext.SaveChanges();
    Console.WriteLine(Convert.ToString(result));
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.ToString());
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.ToString());
}
