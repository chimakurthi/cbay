using System.Collections.Generic;
using Cbay.Model;

namespace Cbay.Service.Interfaces
{
    public interface ICategoriesService
    {
        IEnumerable<Category> GetCategories();
    }
}