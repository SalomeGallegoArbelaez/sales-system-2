using System;
namespace Seller
{
    public class Seller 
    {
        public String Name;
        public int Age;

        Sale[] sales = new Sale[10];
        int salesCount = 0;



        public double TotalSales()
        {
          double valorTotal = 0;

            for (int i=0; i < salesCount; i++)
            {
                valorTotal = sales[i].valorTotalVenta+ valorTtotal;
                
            
            }
            return valorTotal;
 

    }
      
    }

       
}
