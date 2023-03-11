class Program {
    static void Main(string[] args) {
        
         Console.Write("เลขชี้กำลัง: ");
        int x = int.Parse(Console.ReadLine());
        
        double y = Math.Pow(2, x);
        
        Console.WriteLine("{0}",y);
    }
}