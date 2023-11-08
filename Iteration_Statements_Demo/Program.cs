



#region FOREACH

//list.Add(1);
//list.Add(2);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

// cannot do string x in myArray because x is technically an int
// (easier to use var)


//foreach (var b in list)
//{
//    Console.WriteLine(b);
//}

//Console.WriteLine();




//way to start from end using a foreach
//foreach (var item in myArray.Reverse())
//{
//    Console.WriteLine(item);
//}

#endregion

#region FOR

//var myArray = new int[10] { 15, 32, 35, 46, 57, 69, 78, 8, 9, 10 };
var list = new List<double>() { 10.3, 64.32, 41.3 };


for (int i = list.Count-1; i >=0 ; i--)
{
    Console.WriteLine(list[i]);
}







//the variable i is local to the scope

//for (int i = myArray.Length-1; i >= 0; i--) 
//{
//    Console.WriteLine(myArray[i]);
//}




//You can initialize i outside of the for loop

//(Declaring it outside the loop allows it to be used after the
//loop is done. You can check the value to find out if the
//loop stopped because of some break statement or it finished
//by reaching the conditional counter.)

//int i = 0;
//for (; i < myArray.Length; i++)
//{
//    Console.WriteLine(myArray[i]);
//}


//how would you go from the last one in array to the first
//using what kind of loop??

//1. for keyword  2.initializer  3.conditional   4.incrementer
//for (int i = myArray.Length-1; i >= 0; i--)
//{
//    //body of loop
//    Console.WriteLine(myArray[i]);
//}

//how would you change loop to print out every two items?
//in list

//for (int i = 0; i < length; i++)
//{

//}


#endregion
#region WHILE
string userName = "Michael Scott";
string password = "MichaelScott123";
bool isAuthenticated = false;
string setPassword = "";

//Console.WriteLine("Login");

//while (setPassword != password)
//{
//    Console.WriteLine("Please enter your password");
//    setPassword = Console.ReadLine();
//    if (setPassword == password)
//    {
//        isAuthenticated = true;
//        break;
//    }
//    Console.WriteLine("Please try again");
//    Console.WriteLine();
//}
//Console.WriteLine($"Welcome, {userName}");

//what would happen with this code?
//int x = 10;

//while (x > 10)
//{
//    Console.WriteLine(x);
//}




//how do we exit out of the above loop?


//int x = 10;

//while (x > 0) 
//{   
//    Console.WriteLine(x);
//    break;
//}

//WHILE LOOP WILL RUN 0 OR MORE TIMES

#endregion
#region DO-WHILE
//int i = 10;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 10);


//DO WHILE loop will run at least one time

#endregion

#region Try-Parse method for Exercise 3
//string numberAsString = "1234";
//int number;

//bool result = int.TryParse(numberAsString, out number);

//if (result)
//{
//    Console.WriteLine($"Conversion succeeded. Number is {number}");
//}
//else
//{
//    Console.WriteLine("Conversion failed.");
//}

#endregion
