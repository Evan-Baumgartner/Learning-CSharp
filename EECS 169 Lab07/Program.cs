//This program is a practice problem to learn C#. It uses the prompt given in Lab 7 of KU's into to programming course
//EECS 169, the full prompt can be found at https://wiki.ittc.ku.edu/ittc_wiki/index.php?title=EECS168:Lab7. 
//This lab explores functions. It takes in a number from the user in command line inputs and allows the user to choose
//between 6 functions, count digits, sum digits, is palindrome, reverse, is prime, and exit. Additionally there are
//some required helper functions (see prompt for further details).

using System;
using System.ComponentModel.Design;
class Number_manipulation{
    static void Main(){
        string user_choice;
        int num;

        do{
            Print_menu();
            user_choice = Console.ReadLine()!;
            switch (user_choice){
                case "1":
                    num = Get_num();
                    Console.WriteLine(Count_digits(num));
                    break;
                case "2":
                    num = Get_num();
                    Console.WriteLine(Sum_digits(num));
                    break;
                case "3":
                    num = Get_num();
                    if(Is_palindrome(num)){
                        Console.WriteLine("Yes");
                    }
                    else{
                        Console.WriteLine("No");
                    }
                    break;
                case "4":
                    num = Get_num();
                    Console.WriteLine(Reverse(num));
                    break;
                case "5":
                    num = Get_num();
                    if(Is_palindrome(num)){
                        Console.WriteLine("Yes");
                    }
                    else{
                        Console.WriteLine("No");
                    }
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
        while (user_choice != "6");
    }

    static int Get_num(){
        int num;
        Console.Write("Input a positive integer number: ");
        num = Convert.ToInt32(Console.ReadLine());
        return num;
    }
    static void Print_menu(){
        Console.WriteLine("1. Count Digits\n2. Sum Digits\n3. Is Palendrome\n4. Reverse\n5. Is Prime\n 6. Exit");
    }

    static int Last_digit(int num){
        return num%10;
    }

    static int Remove_last_digit(int num){
        return (num - Last_digit(num)) / 10;
    }

    static int Add_digit(int num, int add){
        return (num * 10) + add;
    }

    static int Reverse(int num){
        int new_num = 0;
        while (num != 0){
            new_num *= 10;
            new_num += Last_digit(num);
            num = Remove_last_digit(num);
        }
        return new_num;
    }

    static bool Is_palindrome(int num){
        return num == Reverse(num);
    }

    static int Count_digits(int num){
        int num_digits = 0;
        while (num != 0){
            num = Remove_last_digit(num);
            num_digits++;
        }
        return num_digits;
    }

    static int Sum_digits(int num){
        int sum = 0;
        while (num != 0){
            sum += Last_digit(num);
            num = Remove_last_digit(num);
        }
        return sum;
    }

    static bool Is_prime(int num){
        for(int i = 2; i < num; i++){
            if((num % i) == 0){
                return true;
            }
        }
        return false;
    }
}   