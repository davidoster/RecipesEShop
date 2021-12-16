using Xunit;
using WebApplication1.Controllers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers.API;

namespace WebApplication1.Controllers.API.Tests
{
    public class CategoriesControllerTests
    {
        [Fact()]
        public void PutCategoryTest()
        {
            Assert.True(true, "This test needs an implementation");
        }

        [Fact()]
        public void SumTest()
        {
            CategoriesController categoriesController = new CategoriesController();
            Assert.Equal(2, categoriesController.Sum(1, 1));
            Assert.Equal(4, categoriesController.Sum(1, 3));
            Assert.Equal(7, categoriesController.Sum(3, 2));
            //return categoriesController.Sum(1, 1);
        }
    }
}