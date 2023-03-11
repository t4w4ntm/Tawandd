class Program {
    static void Main(string[] args) {
        
        Console.Write("ขอบล่าง : ");
        float x =float.Parse(Console.ReadLine());

        Console.Write("ขอบบน : ");
        float y =float.Parse(Console.ReadLine());

        Console.Write("จำนวนที่ต้องการตรวจสอบ : ");
        float z =float.Parse(Console.ReadLine());


        if(x < y && z <= y && z >= x){
            Console.Write("True");
        }
        else{
            Console.Write("False");
        }


    }}