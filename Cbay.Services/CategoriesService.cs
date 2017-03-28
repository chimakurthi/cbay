using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cbay.Model;
using Cbay.Repository;
using Cbay.Service.Interfaces;

namespace Cbay.Service
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public CategoriesService(IRepositoryFactory repositoryFactory)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException(nameof(repositoryFactory));
            }

            _repositoryFactory = repositoryFactory;
        }

        public CategoriesService()
        {
            _repositoryFactory = new RepositoryFactory();
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var repository = _repositoryFactory.CreateRepository())
            {
                var result =  repository.GetAll<Category>().Include(r => r.Products).ToList();
                return result;
            }
        }
    }
}
