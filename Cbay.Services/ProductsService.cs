using System;
using System.Collections.Generic;
using System.Linq;
using Cbay.Model;
using Cbay.Repository;
using Cbay.Service.Interfaces;

namespace Cbay.Service
{
    public class ProductsService: IProductService
    {
        private readonly IRepositoryFactory _repositoryFactory;
        
        public ProductsService(IRepositoryFactory repositoryFactory)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException(nameof(repositoryFactory));
            }

            _repositoryFactory = repositoryFactory;
        }

        public IEnumerable<Product> GetProducts(int categoryId)
        {
            using (var repository = _repositoryFactory.CreateRepository())
            {
                return repository.GetAll<Product>().Where(p => p.CategoryId == categoryId).ToList();
            }
        }
    }
}
