using IG.Sample.ChainOfResponsibility.Contracts;
using IG.Sample.Model;

namespace IG.Sample.ChainOfResponsibility.Validators
{
    public abstract class BaseRuleValidator
        : IRuleValidator
    {
        private IRuleValidator _nextRuleValidator;
        public IRuleValidator SetNextRuleValidator(IRuleValidator ruleValidator)
        {
            _nextRuleValidator = ruleValidator;

            return ruleValidator;
        }

        public virtual OrderEnums.OrderStatus Validate(Order request)
        {
            return _nextRuleValidator.Validate(request);
        }
    }
}