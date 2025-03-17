using Evaluator.Logic;

try
{
    var resut2 = ("4*5/(4+6)");
    var resut1 = ("4*(5+6-(8/2^3)-7)-1");
    var resut3 = ("9^(1/2)");
    Console.WriteLine($"{resut1} = {FunctionEvaluator.Evalute(resut1)}");
    Console.WriteLine($"{resut2} = {FunctionEvaluator.Evalute(resut2)}");
    Console.WriteLine($"{resut3} = {FunctionEvaluator.Evalute(resut3)}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}