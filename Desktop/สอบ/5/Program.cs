class Program {
    static void Main(string[] args) {
        Console.Write("input : ");
        int x = int.Parse(Console.ReadLine());
        int n = 1;
        int y = 1;
        while(x == 8  && n <= 4) { 
                Console.WriteLine("{0}",x=y,++n); }

        while(x < 8 && n <= 4 ) { 
            Console.WriteLine("{0}",++x,++n);
             while(x > 7 && n <= 4) { 
                Console.WriteLine("{0}",x=y,++n);}
        }
    }
}
