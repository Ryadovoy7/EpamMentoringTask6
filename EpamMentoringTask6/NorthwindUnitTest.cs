using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamMentoringTask6.Models;
using System.Linq;

namespace EpamMentoringTask6.Tests
{
    [TestClass]
    public class NorthwindUnitTest
    {
        [TestMethod]
        public void NorthwindContext_SelectOrdersWithProductsFromCategory_SelectionNotEmpty()
        {
            const int searchCategoryId1 = 1;
            using (var db = new NorthwindContext())
            {
                var ordersWithProductsFromCategory = db.Orders
                    .Where(o => o.OrderDetails.Any(od => od.Product.Category.CategoryId == searchCategoryId1))
                    .Select(o => new
                    {
                        OrderId = o.OrderId,
                        Details = o.OrderDetails,
                        CustomerName = o.Customer.ContactName,
                        ProductNames = o.OrderDetails.Select(od => od.Product.ProductName)
                    });

                Assert.IsTrue(ordersWithProductsFromCategory.Count() > 0);
            }

        }
    }
}
