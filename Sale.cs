using System;
namespace Sales
{
    public class Sale
    {
        public Product product;
        public Seller seller;
        public String Comments;
        public float valorTotalVenta;

        Product[] products = new Product[5];
        int productsCount = 0;

        Sale[] sales = new Sale[2];
        int salesCount = 0;

        Seller[] Sellers= new Sellers[5*2];
        int sellersCount = 0;




          public void AddProduct(Product newproduct)
        {
            products[productsCount] = newProduct;
            productsCount++;
        }

     

        public static TotalPriceProducts()
        {
          double valorTotal = 0;

            for (int i=0; i < productsCount; i++)
            {
                valorTotal = products[i].Price + valorTotal;
                
            
            }
            valorTotalVenta= ValorTotal;

           

    }

 
     
       
}
