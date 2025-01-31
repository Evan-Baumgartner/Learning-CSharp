using System;

class Bitwise_op {
    static void Main() {
        string num1, num2;

        Console.Write("First binary number: ");
        num1 = Console.ReadLine()!;
        Console.Write("Second binary number: ");
        num2 = Console.ReadLine()!;

        Console.WriteLine("AND: " + AND(num1, num2));
        Console.WriteLine("OR: " + OR(num1, num2));
        Console.WriteLine("XOR: " + XOR(num1, num2));

        string AND(string num1, string num2){
            string AND_num = "";
            for(int i = 0; i < num1.Length; i++){
                if(num1[i] == '1' & num2[i] == '1'){
                    AND_num += "1";
                }
                else{
                    AND_num += "0";
                }
            }
            return AND_num;
        }

        string OR(string num1, string num2){
            string OR_num = "";
            for(int i = 0; i < num1.Length; i++){
                if(num1[i] == '1' | num2[i] == '1'){
                    OR_num += "1";
                }
                else{
                    OR_num += "0";
                }
            }
            return OR_num;
        }

        string XOR(string num1, string num2){
            string XOR_num = "";
            for(int i = 0; i < num1.Length; i++){
                if(num1[i] == '1' ^ num2[i] == '1'){
                    XOR_num += "1";
                }
                else{
                    XOR_num += "0";
                }
            }
            return XOR_num;
        }
    }
}