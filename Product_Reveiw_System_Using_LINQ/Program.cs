// See https://aka.ms/new-console-template for more information

using Product_Reveiw_System_Using_LINQ;

class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Welcome to Project");

        // UC1

        List<Product_Review> Product_Reviews = new List<Product_Review>()
        {
            new Product_Review(){ ProdID=1,UserID=1, Rating=5,review="Good" },
            new Product_Review(){ ProdID=2,UserID=2, Rating=6,review="Good"},
            new Product_Review(){ ProdID=3,UserID=3, Rating=5,review="Bad"},
            new Product_Review(){ ProdID=4,UserID=4, Rating=7,review="Good" },
            new Product_Review(){ ProdID=5,UserID=2, Rating=5,review="Good"},
            new Product_Review(){ ProdID=6,UserID=3, Rating=10,review="Bad"},
            new Product_Review(){ ProdID=7,UserID=4,Rating=9,review="Good"},
            new Product_Review(){ ProdID=8,UserID=2, Rating=10,review="Good"},
            new Product_Review(){ ProdID=9,UserID=5,Rating=9,review="Bad"}

        };
        //foreach(var i in Product_Reviews)
        //{
        //    Console.WriteLine("Prod ID:"+i.ProdID+ "  " +"UserID:"+i.UserID+ "  " +"Rating:"+i.Rating+ " " +"Review:"+i.review);
        //}

        Management management = new Management();
        //management.TopRecord(Product_Reviews);
        //management.Select_Record(Product_Reviews);
        //management.CountRecords(Product_Reviews);
        management.SpecificData(Product_Reviews);
    }
}

