System.Console.WriteLine("Банковский счёт");

double balance = 1000;
System.Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; // пополнение
System.Console.WriteLine($"После покупки на 500: {balance}");

balance -= 200; // покупка
System.Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;   // начисление 5% процентов
System.Console.WriteLine($"После начисление 5%: {balance}");

balance /= 2; // разделили счёт пополам с партнёром
System.Console.WriteLine($"После деления пополам: {balance}");


System.Console.WriteLine();
System.Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

System.Console.WriteLine($"Балл: {myGrade} >= {passingGrade}: {isPassing}");
System.Console.WriteLine($"Возраст: {myAge} == {votingAge}: {isExactAge}");
System.Console.WriteLine($"Возраст: {myAge} >= {votingAge} (может голосовать): {canVote}");
System.Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");