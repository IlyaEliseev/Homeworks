namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateTaskOperation : IOperation
    {
        public string Name => "Update task";

        public void Execute()
        {
            IOperation[] _operations = new IOperation[]
            {
                new UpdateNameTaskOperation(),
                new UpdateDescriptionTaskOperation(),
                new UncompliteTaskStatusOperation()
            };

            List<string> operationNames = new List<string>();

            for (int i = 0; i < _operations.Length; i++)
            {
                operationNames.Add($"{i} - {_operations[i].Name}");
            }

            Console.WriteLine(string.Join("\n", operationNames));
            Console.Write("Input operaiton number: ");

            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int operationNumber);
            if (isNumber)
            {
                _operations[operationNumber].Execute();
            }
        }
    }
}
