using IG.Sample.Model;

namespace IG.Sample.ChainOfResponsibility.Contracts
{
    public interface IRuleValidator
    {
        IRuleValidator SetNextRuleValidator(IRuleValidator ruleValidator);

        OrderEnums.OrderStatus Validate(Order request);
    }
}
