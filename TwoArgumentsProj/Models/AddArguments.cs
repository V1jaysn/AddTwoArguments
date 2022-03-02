using System.Runtime.Remoting;

namespace TwoArgumentsProj.Models;

public class AddArguments
{
    public void AssertIsArrayHasReqArguments<T>(T[] inputArray, int numOfArgumentsReq)
    {
        if (inputArray == null || inputArray.Length == 0)
            throw new ArgumentNullException("Inputs Cannot be Null");
        if (inputArray.Length < numOfArgumentsReq)
            throw new ArgumentException($"Should have atmost two arguments");
        if (inputArray.Length > numOfArgumentsReq)
            throw new ArgumentOutOfRangeException($"Should have atmost two arguments");
    }
    public void AssertIsArgumentInValid(dynamic input1, dynamic input2)
    {
        if (
            !((input1 is string) || (input1 is int) || (input1 is double) || (input1 is float))
            || !((input2 is string) || (input2 is int) || (input2 is double) || (input2 is float))
            )
            throw new ArgumentException("Invalid Input Type");
    }
  
}

