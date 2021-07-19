using FluentValidation;
using FluentValidation.Results;
using SupplyChain.StockIn.Application.Contracts.Commands;
using SupplyChain.StockIn.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application.Contracts.Validations
{
    public class CreateStockInOrderCommandValidator : AbstractValidator<CreateStockInOrderCommand>
    {
        public CreateStockInOrderCommandValidator()
        {
            RuleFor(x => x.OddNum)
                .NotEmpty().WithMessage("入库单号为空");

            RuleFor(x => x.InType)
                .IsInEnum().WithMessage("入库单类型错误");

            RuleFor(x => x.ProductItems)
                .Must(ContainProductItems)
                .Must(x => LimitProductItems(x, 150))
                .WithMessage("入库商品为空");

            RuleFor(x => x.Append.PreDictDate)
                .NotEmpty().WithMessage("到货时间不能为空")
                .Must(IsDateTime)
                .WithMessage("格式:yyyy-MM-dd HH:mm:ss");

        }

        protected override bool PreValidate(ValidationContext<CreateStockInOrderCommand> context, ValidationResult result)
        {
            var dto = context.InstanceToValidate;
            if (dto.InType == Domain.Shared.StockInOrderType.ReturnGoods
                && string.IsNullOrWhiteSpace(dto.Append?.RetundOrder))
            {
                result.Errors.Add(new ValidationFailure("", "退货入库时,退货单号必须填写"));
                return false;
            }

            if (dto.InType == Domain.Shared.StockInOrderType.Purchase)
            {
                if (string.IsNullOrWhiteSpace(dto.Append?.SupplyName)
                    || string.IsNullOrWhiteSpace(dto.Append?.SupplyId))
                {
                    result.Errors.Add(new ValidationFailure("", "采购单入库时供货商信息必须填写"));
                    return false;
                }
                if (string.IsNullOrWhiteSpace(dto.Append?.PurchaseIds))
                {
                    result.Errors.Add(new ValidationFailure("", "采购单入库时采购单id必须填写"));
                    return false;
                }
            }
            if (dto.InType == Domain.Shared.StockInOrderType.Transfer)
            {
                if (string.IsNullOrWhiteSpace(dto.Append.InterNalNo))
                {
                    result.Errors.Add(new ValidationFailure("", "库存调拨(库存转存)时,供应链内部订单号必填"));
                    return false;
                }
            }

            return true;
        }

        private bool ContainProductItems(IEnumerable<CreateInOrderProductItem> productItems)
        {
            return productItems.Any();
        }

        private bool LimitProductItems(IEnumerable<CreateInOrderProductItem> productItems, int maxLength)
        {
            return productItems.Any() && productItems.Count() <= maxLength;
        }

        private bool IsDateTime(DateTime date)
        {
            return date.Equals(default(DateTime));
        }

    }
}
