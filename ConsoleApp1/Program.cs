using IG.Sample.ChainOfResponsibility.Manager;
using IG.Sample.ChainOfResponsibility.Validators;
using IG.Sample.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderList = BuildOrderFakes();

            var closedStatusRuleValidator = new ClosedStatusRuleValidator();
            var requiredAuthorisationRuleValidator = new RequiredAuthorisationRuleValidator();
            var confirmedRuleValidator = new ConfirmedRuleValidator();

            closedStatusRuleValidator
                .SetNextRuleValidator(requiredAuthorisationRuleValidator)
                .SetNextRuleValidator(confirmedRuleValidator);

            foreach (var order in orderList)
            {
                RuleValidatorManager.CheckParams(closedStatusRuleValidator, order);
            }

            Console.ReadLine();
        }

        private static List<Order> BuildOrderFakes()
        {
            var orderList =
                new List<Order>
                {
                    new Order
                    {
                        IsLargeOrder = true,
                        IsRushOrder = true,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Hire
                    },
                    new Order
                    {
                        IsLargeOrder = true,
                        IsRushOrder = true,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Repair
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = true,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Hire
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = false,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Hire
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = false,
                        IsNewCustomer = false,
                        OrderType = OrderEnums.OrderType.Hire
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = true,
                        IsNewCustomer = false,
                        OrderType = OrderEnums.OrderType.Hire
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = true,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Repair
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = false,
                        IsNewCustomer = true,
                        OrderType = OrderEnums.OrderType.Repair
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = false,
                        IsNewCustomer = false,
                        OrderType = OrderEnums.OrderType.Repair
                    },
                    new Order
                    {
                        IsLargeOrder = false,
                        IsRushOrder = true,
                        IsNewCustomer = false,
                        OrderType = OrderEnums.OrderType.Repair
                    }
                };

            return orderList;
        }
    }
}