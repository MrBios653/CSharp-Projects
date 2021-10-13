public class Operatorler
{
    public static void Main(string[] args){
        
        Console.WriteLine("*****atama ve işlemli atama operatörleri*****");
        int x = 3;
        int y = 4;
        y = y + 2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        y *= 2;

        Console.WriteLine("*****ilişkisel operatorler*****");
        bool isSuccess = true;
        bool isTrue = false;
        if(isSuccess && isTrue)
            Console.WriteLine("Perfect!!!");
        if(isSuccess || isTrue)
            Console.WriteLine("Great");
        if(isSuccess &&! isTrue)
            Console.WriteLine("Fine");


        a = 3;
        b = 4;
        bool sonuc = a < b ;
        Console.WriteLine(sonuc);
        sonuc = a > b ;
        Console.WriteLine(sonuc);
        sonuc = a>=b ;
        Console.WriteLine(sonuc);
        sonuc = a<=b ;
        Console.WriteLine(sonuc);
        sonuc = a == b ;
        Console.WriteLine(sonuc);



        Console.WriteLine("******aritmetik operatorler*****");
        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sayi1 += 1;
        Console.WriteLine(sayi1);

        int sonuc3 = 20%3;
        Console.WriteLine(sonuc3);



        
    }
}