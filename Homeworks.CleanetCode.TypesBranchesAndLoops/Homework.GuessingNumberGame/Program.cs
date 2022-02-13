using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Добро пожаловать в игру 'Угадай число'");

int minValue = 0;
int maxValue = 999;
int answerCount = 0;
bool verifiUserName = false;
string? userName = null;
Random random = new Random();
int secretNumber = random.Next(minValue, maxValue);
bool isWin = false;

do
{
	Console.WriteLine("Как вас зовут?");
	userName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userName))
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
	$"Я загадал тебе число от {minValue} до {maxValue}. " +
	$"Попробуй отгадать");

while (!isWin)
{
	int userNumber = -1;
	bool isIntNumber = false;
	bool isVerifiNumber = false;

	do
	{
		Console.WriteLine($"Введи число от {minValue} до {maxValue}");
		string? userInput = Console.ReadLine();
		isIntNumber = int.TryParse(userInput, out userNumber);
		isVerifiNumber = isIntNumber && userNumber >= minValue && userNumber <= maxValue;

		if (!isVerifiNumber)
		{
			Console.WriteLine($"Вы ввели {userInput}. Нужно ввести число от {minValue} до {maxValue}");
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
		isWin = true;
		Console.WriteLine($"Вы победили! На это у вас ушло {answerCount} попыток");
	}
}
