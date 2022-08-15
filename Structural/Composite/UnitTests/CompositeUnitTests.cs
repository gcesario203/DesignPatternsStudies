using Implementation.Products;
using Implementation.Validation;

namespace UnitTests
{
    public class CompositeUnitTests
    {
        [Fact]
        public void ShouldCalculateTheChildrenValues()
        {
            var productList = new ProductComposer();
            var rice = new ProductLeaf("Arroz", 10.00M);
            var beans = new ProductLeaf("Feijão", 5.00M);

            productList.Add(rice, beans);

            Assert.Equal(productList.GetPrice(), 15.00M);
        }

        [Fact]
        public void ShouldCalculateFromRemovedItem()
        {
            var productList = new ProductComposer();
            var rice = new ProductLeaf("Arroz", 10.00M);
            var beans = new ProductLeaf("Feijão", 5.00M);

            productList.Add(rice, beans);

            productList.Remove(beans);

            Assert.Equal(productList.GetPrice(), 10.00M);
        }

        [Fact]
        public void ShouldValitadeValidEmail()
        {
            var email = "teste@outlook.com";

            var validate = new ValidateComposer();

            Assert.Equal(validate.Validate(email), true);
        }

        [Fact]
        public void ShouldValitadeInValidEmail()
        {
            var email = "teste";

            var validate = new ValidateComposer();

            Assert.Equal(validate.Validate(email), false);
        }
    }
}