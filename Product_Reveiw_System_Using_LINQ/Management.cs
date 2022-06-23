using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Reveiw_System_Using_LINQ
{
    public class Management
    {
        //public readonly DataTable datatable = new DataTable();


        public void TopRecord(List<Product_Review> reviews)
        {
            var RecordData =(from Product_Review in reviews orderby Product_Review.Rating descending select Product_Review).Take(3);
                
            foreach(var i in RecordData)
              Console.WriteLine("Prod ID:" + i.ProdID + "  " + "UserID:" + i.UserID + "  " + "Rating:" + i.Rating + " " + "Review:" + i.review);
        }

        public void Select_Record(List<Product_Review>Reviews)
        {
            var Data = from Product_Review in Reviews where (Product_Review.ProdID == 1 && Product_Review.Rating > 3) || (Product_Review.ProdID == 4 && Product_Review.Rating > 3) || (Product_Review.ProdID == 9 && Product_Review.Rating > 3) select Product_Review;
            // var Data = from Product_Review in Reviews where (Product_Review.ProdID == 1 || Product_Review.ProdID == 4 || Product_Review.ProdID == 9) && (Product_Review.Rating > 3) select Product_Review; 

            foreach (var i in Data)
                Console.WriteLine("Prod ID:" + i.ProdID + "  " + "UserID:" + i.UserID + "  " + "Rating:" + i.Rating + " " + "Review:" + i.review);
        }


        public void CountRecords(List<Product_Review>Reviews)
        {
            var Data = Reviews.GroupBy(x => x.ProdID).Select(x => new { ProdID = x.Key, Count = x.Count() }); 
            foreach(var i in Data)
            {
                Console.WriteLine(i.ProdID + " " + i.Count);
            }
        }


        public void SpecificData(List<Product_Review> reviews)
        {
            var Data = from Product_Review in reviews select Product_Review.ProdID;
            foreach(var i in Data)
            {
                Console.WriteLine(i);
            }
        }
    }

   
}
