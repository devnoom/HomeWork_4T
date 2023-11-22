/*დაწერეთ კონსოლ აპლიკაცია , რომელიც დაითვლის 0 დან 10 მდე რიცხვების ჯამს და დაბეჭდავს ამ შედეგს*/


//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    sum += i;
//}
//Console.WriteLine($"sum from 0 to 10 is {sum}");



/*დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს
 * 1 დან ამ რიცხვის ჩათვლით ყველა რიცხვის ჯამს*/


//Console.WriteLine("Enter number");
//int userInput = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= userInput; i++)
//{
//    sum += i;
//}
//Console.WriteLine($"sum from 0 to {userInput} is {sum}");



/*დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს 1 დან რიცხვის 
 ჩათვლით ყველა რიცხვის კუბს*/


//Console.WriteLine("Enter number");
//int userInput = Convert.ToInt32(Console.ReadLine());
//int powNum;
//for (int i = 1; i <= userInput; i++)
//{
//    powNum = (int)Math.Pow(i, 3);
//    Console.WriteLine($"{i} cubed is {powNum}");
//}



/*დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და
 შემდეგ დაბეჭდავს 1 დან ამ რიცხვამდე კენტი რიცხვების ჯამს*/



//Console.WriteLine("Enter a number: ");
//int userInput = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i <= userInput; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine($"Sum of odd numbers from 1 to {userInput} is {sum}");



/*დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს 
 ამ მთელი რიცხვის რაოდენობას სტრიქონებიან ფლოიდის სამკუთხედს შედგენილს მხოლოდ 0 ებით და 1 ებით*/


//Console.Write("Enter a number of rows of Floyd's triangle to be printed : ");
//int triangle = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= triangle; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {

//        Console.Write((i + j) % 2 == 0 ? "1" : "0");
//    }
//    Console.WriteLine();
//}



/*დაწერეთ კონსოლ აპლიკაცია რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რდადებითი
 * რიცხვი და ბოლოს დაბეჭდავს ამ რიცხვის გამყოფებს*/


//Console.Write("Enter a number : ");
//int input = Convert.ToInt32(Console.ReadLine());
//Console.Write($"divisors  of {input} are: ");
//for (int i = 1; i <= input; i++)
//{
//    if (input % i == 0)
//    {
//        Console.Write($"{i}, "
//        );
//    }
//}



/*დაწერეთ კონსოლ აპლიკაცია რომელსაც გადავცემთ ფიბონაჩის მიმდევრობის მე-n წევრს და დაიბეჭდება 
 ეკრანზე მე-n წევრის ჩათვლით ყველა რიცხვი (არ გამოიყენოთ რეკურსია)*/


//Console.WriteLine("Enter a number");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 0; int b = 1;
//for (int i = 0; i <= n; i++)
//{
//    Console.WriteLine($"{a} ");
//    int temp = a;
//    a = b;
//    b = temp + b;
//}




/*დაწერეთ კონსოლ აპლიკაცია რომელიც მთელ დადებით რიცხვებს გადაიყვანს ორობითში არ გამოიყენოთ convert კლასი გარდაქმნისთვის*/



//Console.Write("Enter an integer: ");
//string stringNumber = Console.ReadLine();
//if (int.TryParse(stringNumber, out int number) && number >= 0)
//{
//    if (number == 0)
//    {
//        Console.WriteLine("0");
//    }
//    string binary = "";

//    while (number > 0)
//    {
//        int remainder = number % 2;
//        binary = remainder + binary;
//        number /= 2;
//    }

//    Console.WriteLine(binary);

//}
//else
//{
//    Console.WriteLine("You entered an invalid number");
//}

