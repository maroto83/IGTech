using IG.Sample.Model;

namespace IG.Sample.ChainOfResponsibility.Validators
{
    public class ConfirmedRuleValidator
        : BaseRuleValidator
    {
        public override OrderEnums.OrderStatus Validate(Order request)
        {
            return OrderEnums.OrderStatus.Confirmed;
        }
    }
}