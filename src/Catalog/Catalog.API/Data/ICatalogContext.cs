using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        IFilteredMongoCollection<Product> Products { get; }
    }
}
