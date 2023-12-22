#region  Task1
//Console.Write("Enter the first number:");
//string num1Str=Console.ReadLine();
//int num1 = Convert.ToInt32(num1Str);
//Console.Write("Enter the second number:");
//string num2Str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2Str);
//Console.Write("Enter the first number:");
//string num3Str = Console.ReadLine();
//int num3 = Convert.ToInt32(num3Str);
//int biggest;

//if (num1 > num2)
//{
//    if (num1 > num3)
//        biggest = num1;
//else
//    biggest = num3;
//}
//else if(num2 > num3)
//    biggest = num2; 
//else biggest = num3;
//Console.WriteLine($"Biggest number:{biggest}");
#endregion

#region  Task2
//Console.Write("Enter the text:");
//string text=Console.ReadLine();
//bool hasA = false;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'A') hasA = true;
//    break;
//}
//if (hasA) Console.WriteLine("There is a 'A' letter");
//else Console.WriteLine("There is not a  'A' letter");



#endregion

#region Task2(+)
//Console.Write("Yazini daxil edin:");
//string text=Console.ReadLine();
//Console.Write("Axtarilan herfi daxil edin:");
//string letterStr=Console.ReadLine();
//char letter =Convert.ToChar(letterStr);
//bool hasLetter = false;
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == letter)
//    {
//        hasLetter = true;
//        break;
//    }
//}
//if (hasLetter) Console.WriteLine($"{letter} herfi var");
//else Console.WriteLine($"{letter} herfi yoxdur");

#endregion

#region  Task3

//Console.Write("Yazini daxil edin:");
//string text=Console.ReadLine();

//int count = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'A')
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Yazida {count} sayda A herfi var");
#endregion

#region  Task4
//int num;
//do
//{
//Console.Write("Ededi daxil edin:");
//string numStr=Console.ReadLine();
// num=Convert.ToInt32(numStr);
//}
//while (num<=0 || num%2!=0);
//int result = num * num;
//Console.Write($"Verilmish ededin kvadrati:{result}");
#endregion

#region Task5

//int[] nums=new int[5];
//for (int i=0; i<nums.Length; i++)
//{
//Console.Write($"{i+1}.ededi daxil et: ");
//string numStr=Console.ReadLine();
//int num=Convert.ToInt32(numStr);

//nums[i]=num;
//}

//int sum=0;

//for(int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//Console.WriteLine("sum="+sum);
#endregion

#region Task5(+)
//Console.WriteLine("Ededlerin sayini daxil edin");
//string numsCountStr=Console.ReadLine();
//int numsCount = Convert.ToInt32(numsCountStr);

//int[] nums = new int[numsCount ];

//string output = " ";
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write($"{i + 1}.ededi daxil et: ");
//    string numStr = Console.ReadLine();
//    int num = Convert.ToInt32(numStr);
//    nums[i] = num;

//    if(i!=0 && num>=0)
//    output += "+"; 
//    output += numStr;
//}

//int sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//output +=$"={sum}";
//Console.WriteLine(output);
#endregion

#region  Task6
//bool checkInput;
//do
//{
//checkInput=true;
//    Console.WriteLine("Tehsil novunu daxil et:");
//    string educationType = Console.ReadLine();



//    switch (educationType)
//    {
//        case "programming":
//            Console.WriteLine("400 saat");
//            break;
//        case "design":
//            Console.WriteLine("250 saat");
//            break;
//        case "system":
//            Console.WriteLine("200saat");
//            break;
//        default:
//        checkInput = false;
//        Console.WriteLine("Tehsil novu yalnishdir!");
//            break;

//    }
//} while (!checkInput);



#endregion  