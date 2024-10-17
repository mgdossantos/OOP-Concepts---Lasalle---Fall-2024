using System;


namespace Simulation_Question5MVC
{
    public class ProductController
    {
        private Product product;
        private ProductView productView;

        public ProductController(ProductView view)
        {
            this.productView = view;
            this.productView.SubmitButtonClicked += OnSubmitButtonClicked;
            this.productView.DiscountButtonClicked += OnDiscountButtonClicked;

        }
        public double applyDiscount(double price, double discount)
        {
            return (price - (price * discount / 100));
        }
        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            //Get data from the view
            int id = this.productView.getProductID();
            string name = this.productView.getProductName();
            double price = this.productView.getProductPrice();

            
            //update the model
            this.product = new Product(id,name,price);
            //Update the view with the model data
            this.productView.setProductDetails(this.product.ProductID, this.product.Name, this.product.Price);
        }

        private void OnDiscountButtonClicked(object sender, EventArgs e)
        {
            //Get data from the view
            int id = this.productView.getProductID();
            string name = this.productView.getProductName();
            double price = this.productView.getProductPrice();
            double discount = this.productView.getDiscount();
            price = this.applyDiscount(price, discount);

            //update the model
            this.product = new Product(id, name, price);
            //Update the view with the model data
            this.productView.setProductDetails(this.product.ProductID, this.product.Name, this.product.Price);
        }


    }
}
