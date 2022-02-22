namespace CleanetCode.TodoList.CLI
{
    public class ColorMessage
    {
        public static void SetGreenColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetRedColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
