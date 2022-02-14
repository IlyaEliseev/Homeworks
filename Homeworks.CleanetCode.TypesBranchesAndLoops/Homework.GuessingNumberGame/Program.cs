using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Добро пожаловать в игру 'Угадай число'");

string nameValidationPattern = @"^[a-zA-Zа-яА-Я]+$";
string playerContinueAnswerPattern = @"^[y, n]+$";

int minValue = 0;
int maxValue = 1000;
int answerCount = 0;
bool verifiUserName = false;
string? userName = null;
Random random = new Random();
int secretNumber = random.Next(minValue, maxValue);
bool isContinue = true;

do
{
	Console.WriteLine("Как вас зовут?");
	userName = Console.ReadLine();

	var match = Regex.Match(userName, nameValidationPattern, RegexOptions.IgnoreCase);

	if (!match.Success)
	{
		Console.WriteLine("Некоректный ввод. Попробуйте еще.");
		verifiUserName = false;
	}
	else
	{
		verifiUserName = true;
	}
} while (!verifiUserName);

Console.WriteLine(
	$"Привет {userName}. " +
	$"Я загадал тебе число от {minValue} до {maxValue - 1}. " +
	$"Попробуй отгадать");

while (isContinue)
{
	int userNumber = -1;
	bool isIntNumber = false;
	bool isVerifiNumber = false;
	bool isVerifiUserAnswer = false;

	do
	{
		Console.WriteLine($"Введи число от {minValue} до {maxValue - 1} {secretNumber}");
		string? userInput = Console.ReadLine();
		isIntNumber = int.TryParse(userInput, out userNumber);
		isVerifiNumber = isIntNumber && userNumber >= minValue && userNumber <= maxValue;

		if (!isVerifiNumber)
		{
			Console.WriteLine($"Вы ввели {userInput}. Нужно ввести число от {minValue} до {maxValue - 1}");
		}
	} while (!isVerifiNumber);

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
			userInputContinue = Console.ReadLine();

			var match = Regex.Match(userInputContinue, playerContinueAnswerPattern, RegexOptions.IgnoreCase);

			if (!match.Success)
			{
				Console.WriteLine("Неверный ввод. Введите y/n.");
				isVerifiUserAnswer = false;
			}
			else
			{
				isVerifiUserAnswer = true;
			}
		} while (!isVerifiUserAnswer);

		if (userInputContinue.ToLower() == "y")
		{
			isContinue = true;
			random = new Random();
			secretNumber = random.Next(minValue, maxValue);
			answerCount = 0;
		}
		if (userInputContinue.ToLower() == "n")
		{
			isContinue = false;
		}
	}
}




