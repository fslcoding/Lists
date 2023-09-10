class Program {
    public static void Main(string[] args) {

        List<string> Names = new List<string>();

        Names.Add("Joshua");
        Names.Add("Matthew");
        Names.Add("Grace");

        foreach(string name in Names) {
            Console.WriteLine(name);
        }

    }
}