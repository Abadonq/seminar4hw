﻿
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number){
    
    int counter = Convert.ToString(number).Length;
    int difference = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
     difference = number - number % 10;
      result = result + (number-difference);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Sum => " + sumNumber);






