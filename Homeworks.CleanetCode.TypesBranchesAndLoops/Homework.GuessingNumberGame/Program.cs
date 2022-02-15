using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Добро пожаловать в игру 'Угадай число'");

int minValue = 0;
int maxValue = 1000;
int answerCount = 0;
bool isValidUserName = false;
string? userName = null;
Random random = new Random();
int secretNumber = random.Next(minValue, maxValue);
bool isContinue = true;

do
{
	Console.WriteLine("Как вас зовут?");
	userName = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(userName))
	{
		Console.WriteLine("Некоректный ввод. Попробуйте еще.");
		isValidUserName = false;
	}
	else
	{
		isValidUserName = true;
	}
} while (!isValidUserName);

Console.WriteLine(
	$"Привет {userName}. " +
	$"Я загадал тебе число от {minValue} до {maxValue - 1}. " +
	$"Попробуй отгадать");

while (isContinue)
{
	int userNumber = -1;
	bool isIntNumber = false;
	bool isValidNumber = false;
	bool isValidUserAnswer = false;

	do
	{
		Console.WriteLine($"Введи число от {minValue} до {maxValue - 1} {secretNumber}");
		string? userInput = Console.ReadLine();
		isIntNumber = int.TryParse(userInput, out userNumber);
		isValidNumber = isIntNumber && userNumber >= minValue && userNumber <= maxValue;

		if (!isValidNumber)
		{
			Console.WriteLine($"Вы ввели {userInput}. Нужно ввести число от {minValue} до {maxValue - 1}");
		}
	} while (!isValidNumber);

	answerCount++;

	if (userNumber > secretNumber)
	{
		Console.WriteLine($"Ваше число ({userNumber}) больше, чем загаданное");
	}
	else if (userNumber < secretNumber)
	{
		Console.WriteLine($"Ваше число ({userNumber}) меньше, чем загаданное");
	}
	else
	{
		string? userInputContinue = null;

		Console.WriteLine($"Вы победили! На это у вас ушло {answerCount} попыток.");
		do
		{
			Console.WriteLine("Продолжаем играть? Введите y/n");
			userInputContinue = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrWhiteSpace(userInputContinue))
            {
                Console.WriteLine("Неверный ввод. Введите y/n.");
            }
            if (userInputContinue == "y")
			{
				isContinue = true;
				random = new Random();
				secretNumber = random.Next(minValue, maxValue);
				answerCount = 0;
				isValidUserAnswer = true;
			}
			if (userInputContinue == "n")
			{
				isContinue = false;
				isValidUserAnswer = true;
			}
		} while (!isValidUserAnswer);
	}
}




