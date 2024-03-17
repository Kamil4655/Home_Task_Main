

//1)
//int num = 14;

//if (num >= 15)
//{
//    Console.WriteLine("HAva istidi");
//}
//else
//{
//    Console.WriteLine("Hava soyuqdur");
//}


//2)
//string month = "Fevral";

//switch (month)
//{ 
//    case "Yanvar":
//    case "Mart":
//    case "May":
//    case "Iyul":
//    case "Avqust":
//    case "Sentyabr":
//    case "Oktyabr":
//        Console.WriteLine("31");
//        break;

//    case "Aprel":
//    case "Iyun":
//    case "Noyabr":
//        Console.WriteLine("30");
//        break;

//    case "Fevral":
//        Console.WriteLine("28");
//        break;
//    default:
//        Console.WriteLine("BELE BIR AY YOXDUR");
//        break;
//}



//3)
//int num = 8;
//int fac = num * (num - 1)!;
//for (int i = 0; i < num; i++)
//{
//    fac = num * (num - 1)!;
//}
//Console.WriteLine(fac);


//4)
//int num1;

//num1 = 18; 
//if (num1 == 0 || num1 == 1)
//{ 
//}
//else
//{
//    for (int a = 2; a <= num1 / 2; a++)
//    {
//        if (num1 % a == 0)
//        {
//            Console.WriteLine(num1 + " Murekkeb ededdir");
//            return;
//        }

//    }
//    Console.WriteLine(num1 + " sade ededdir");

//}

//5)
//int[] num = { 5, 9, 15, 128,7 };
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] %2 !=0 )
//    {
// sum+= num[i];
//    }

//}
//Console.WriteLine(sum);


//6) 

//int[] arr = { 5, 9, 15, 128, 900 };
//int min = arr[0];
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);


//7)

//int num = 555;
//if (num % 10 == num / 100 && num % 10 == (num / 10) % 10)
//{
//    Console.WriteLine("regemler beraberdir");
//}
//else
//{
//    Console.WriteLine("regemler ferqlidir.");
//}




//9)

//int number = 12345;
//int sum = 0,
//reminder;
//while (number > 0)
//{
//    reminder = number % 10;
//    sum = sum + reminder;
//    number = number / 10;
//}
//Console.WriteLine(sum);


//10)

//int[] arr = {3, 5, 9, 15, 128, 900 };
//int min = arr[0];
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(min);



//11)

//int[] arr = { 3, 5, 9, 15,8, 128, 900 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 10 == arr[i])
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);




//12)

//int num = 67;

//if (num % 10 > num / 10)
//{
//    Console.WriteLine("Teklik boyukdu.");
//}
//else if (num % 10 == num / 10)
//{
//    Console.WriteLine("Beraberdir.");
//}
//else if (num % 10 < num / 10)
//{
//    Console.WriteLine("Onluq boyukdu.");
//}




//13)


//int[] nums = { 2, 100, 4, 34, 1, 56, 13 };
//int max = 0;
//int min = 0;


//for (int i = 1; i < nums.Length; i++)
//{
//    if (nums[max] < nums[i])
//    {
//        max = i;
//    }
//    if (nums[min] > nums[i])
//    {
//        min = i;
//    }
//}

//nums[max] += nums[min];
//nums[min] = nums[max] - nums[min];
//nums[max] = nums[max] - nums[min];


//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write(nums[i] + " ");
//}




//14)


//int num = 45785656;
//int count = 0;

//while (num % 10 != 0)
//{
//    count++;
//    num /= 10;
//}

//Console.WriteLine(count);




//15)

//int num = 2366;
//int newNum = 7 * 100000 + num * 10 + 8;
//Console.WriteLine(newNum);




//16) 

//int num = 123;
//int newnum = num + num * 1000;
//Console.WriteLine(newnum);





//17)

//int num = 522;
//int newnum = (num * 10 + 7) * 7 / 100;
//Console.WriteLine(newnum);




//18)

//int num = 105;

//if (num % 2 == 0)
//{
//    Console.WriteLine("cut ededdir");
//}
//else if (num == 0)
//{
//    Console.WriteLine("Ne cut ne tek ededdir");
//}
//else if (num % 2 == 1)
//{
//    Console.WriteLine("Tek ededdir");
//}




//19)

//int num = 42;

//if (num % 21 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}





//20)

//int numOne = 25;
//int numTwo = 23;

//if (numOne > numTwo)
//{
//    Console.WriteLine(numOne);
//}
//else if (numOne == numTwo)
//{
//    Console.WriteLine("Beraberdir");
//}
//else if (numTwo>numOne)
//{
//    Console.WriteLine(numTwo);
//}




//21)

//string[] arr = { "AF105", "KAmil", "AB106", "Amin" };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        Console.WriteLine("Var");
//    }
//    else
//    {
//        Console.WriteLine("yoxdu");
//    }
//}




//22)

//int m = 922;
//int divisible = 15;
//int count = 0;
//for (int i = 1; i <= m; i++)
//{

//    if (i % divisible == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count + " dene boluneni var");
