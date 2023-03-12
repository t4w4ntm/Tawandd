class Program {
    static void Main(string[] args) {
            Console.Write("ชั้น =  ");
            int n = int.Parse(Console.ReadLine());
        
        for (int row = 1; row <= n; row++) {
            for (int col = 1; col <= n - row; col++) {
                Console.Write(" ");}
            Console.Write("#");
            
            for (int col = 1; col < 2 * row - 2; col++) {
                if (row == n) {
                    Console.Write("#");}
                else {
                    Console.Write(" ");}
            }
            if (row != 1) {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
