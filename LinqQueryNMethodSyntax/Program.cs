namespace LinqQueryNMethodSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 10, 8, 3, 6, 12, 24, 43, 87 };

            //Query syntax
            IEnumerable<int> numQuery1 =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

            //Method syntax
            IEnumerable<int> numQuery2 = 
                numbers.Where(num => num % 2 == 0).OrderBy(n => n);

            numbers.Add(54);

            numbers.Clear();

            Console.WriteLine("Query Syntax");
            foreach (int num in numQuery1)
                Console.WriteLine(num);

            Console.WriteLine("Method Syntax");
            foreach (int num in numQuery2)
                Console.WriteLine(num);
        }
    }
}
