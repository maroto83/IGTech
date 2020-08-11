using IG.Sample.ChainOfResponsibility.Validators;
using IG.Sample.Model;
using Newtonsoft.Json;
using System;

namespace IG.Sample.ChainOfResponsibility.Manager
{
    public class RuleValidatorManager
    {
        public static void CheckParams(BaseRuleValidator ruleValidator, Order request)
        {
            Console.Write($"\n\nThe order info is: {JsonConvert.SerializeObject(request)}");

            var result = ruleValidator.Validate(request);

            Console.Write($"\nYour order status is: {result}");
        }
    }
}