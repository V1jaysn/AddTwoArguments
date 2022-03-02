// See https://aka.ms/new-console-template for more information
using TwoArgumentsProj.Models;
try
{
    AddArguments addArguments = new();
    addArguments.AssertIsArrayHasReqArguments<string>(args, 2);
    var result = addArguments.ConcatArgs(args[0], args[1]);
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
