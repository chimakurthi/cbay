using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Cbay.Model;

namespace Cbay.Service.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts(int categoryId);
    }
}