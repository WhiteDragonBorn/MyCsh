using System ;

class Inches {
    static void Main(){
        long inches ;
        long miles ;
        miles = 93000000 ;
        inches = miles * 5280 * 12 ;

        Console.WriteLine("Расстояние до солнца: " + inches ) ;
        
    }
}
