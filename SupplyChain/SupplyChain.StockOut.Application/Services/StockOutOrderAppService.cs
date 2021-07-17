using SupplyChain.StockOut.Application.Contracts.Dto;
using SupplyChain.StockOut.Application.Contracts.IServices;
using SupplyChain.StockOut.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Application.Services
{
    public class StockOutOrderAppService : IStockOutOrderAppService
    {
        private readonly IStockOutOrderRepository stockOutOrderRepository;
        private readonly IStockOutOrderFlowRepository stockOutOrderFlowRepository;
        //private readonly IMapper

        public StockOutOrderAppService(IStockOutOrderRepository stockOutOrderRepository, IStockOutOrderFlowRepository stockOutOrderFlowRepository)
        {
            this.stockOutOrderRepository = stockOutOrderRepository;
            this.stockOutOrderFlowRepository = stockOutOrderFlowRepository;
        }

        public async Task<StockOutOrderDto> Get(int id)
        {
            var order = await stockOutOrderRepository.Get(id);
            var flows = await stockOutOrderFlowRepository.Get(id);

            //var result = 
            return new StockOutOrderDto();
        }
    }
}
