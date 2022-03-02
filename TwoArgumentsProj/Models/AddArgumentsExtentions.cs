namespace TwoArgumentsProj.Models;

public static class AddArgumentsExtentions
{
    public static dynamic ConcatArgs(this AddArguments addArguments, dynamic arg1, dynamic arg2)
    {
        addArguments.AssertIsArgumentInValid(arg1, arg2);

        var result = arg1 + arg2;

        return result;
    }
}
