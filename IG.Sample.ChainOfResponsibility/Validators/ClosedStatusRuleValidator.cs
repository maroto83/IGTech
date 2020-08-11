using IG.Sample.Model;

namespace IG.Sample.ChainOfResponsibility.Validators
{
    public class ClosedStatusRuleValidator
        : BaseRuleValidator
    {
        public override OrderEnums.OrderStatus Validate(Order request)
        {
            return
                request.IsLargeOrder.HasValue && request.IsLargeOrder.Value
                && request.IsNewCustomer.HasValue && request.IsNewCustomer.Value
                    ? OrderEnums.OrderStatus.Closed
                    : base.Validate(request);
        }
    }
}