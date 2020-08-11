using IG.Sample.Model;

namespace IG.Sample.ChainOfResponsibility.Validators
{
    public class RequiredAuthorisationRuleValidator
        : BaseRuleValidator
    {
        public override OrderEnums.OrderStatus Validate(Order request)
        {
            return
                request.IsRushOrder.HasValue && request.IsRushOrder.Value
                    && request.IsNewCustomer.HasValue && request.IsNewCustomer.Value
                || request.IsLargeOrder.HasValue && request.IsLargeOrder.Value
                    ? OrderEnums.OrderStatus.AuthorisationRequired
                    : base.Validate(request);
        }
    }
}