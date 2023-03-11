class Program {
    static void Main(string[] args) {
        
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int d = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(y, m, d);

        DateTime เมจิ1 = new DateTime(1868, 9, 8);
        DateTime เมจิ = new DateTime(1912, 7, 29);

        DateTime ไทโช1 = new DateTime(1912, 7, 30);
        DateTime ไทโช = new DateTime(1926, 12, 24);

        DateTime  โชวะ1 = new DateTime(1926, 1, 8);
        DateTime โชวะ = new DateTime(1989, 1, 7);

        DateTime เฮเซ1 = new DateTime(1989, 1, 8);
        DateTime เฮเซ = new DateTime(2019, 4, 30);

        DateTime เรวะ1= new DateTime(2019, 5, 1);
        DateTime เรวะ = DateTime.Today;

        if (date < เมจิ && date > เมจิ1) {
            Console.WriteLine("เมจิ");
        } 
        else if(date < ไทโช && date > ไทโช1) {
            Console.WriteLine("ไทโช");
        } 
        else if(date < โชวะ && date > โชวะ1) {
            Console.WriteLine("โชวะ");
        } 
        else if(date < เฮเซ && date > เฮเซ1) {
            Console.WriteLine("เฮเซ");
        } 
        else if(date <  เรวะ&& date > เรวะ1) {
            Console.WriteLine("เรวะ");
        }
    }
}