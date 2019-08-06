using System;
using System.Collections.Generic;

namespace basic13
{
    public class Program
    {
        public static void Main(string[] args){
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] arr = {-3, 5, -7};
            // LoopArray(arr);
            // FindMax(arr);
            // GetAverage(arr);
            // OddArray();
            // GreaterThanY(arr, 3);
            // SquareArrayValues(arr);
            // EliminateNegatives(arr);
            // MinMaxAverage(arr);
            // ShiftValues(arr);
            NumToString(arr);
        }

        // Print 1-255
        public static void PrintNumbers() {
            for(int i = 1; i <=255; i++){
                System.Console.WriteLine(i);
            }
        }
        
        //Print odds 1-255
        public static void PrintOdds(){
            for(int i = 1; i <=255; i++){
                if(i % 2 == 1){
                    System.Console.WriteLine(i);
                }
            }
        }

        //Print sum 0-255
        public static void PrintSum(){
            int sum = 0;
            for(int i = 1; i <=255; i++){
                sum = sum + i;
                System.Console.WriteLine("New Number: " + i + ", Sum: " + sum);
            }
        }
        
        //Iterating through an Array
        public static void LoopArray(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }
        }

        //Find Max of Array
        public static void FindMax(int[] numbers){
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
            }
            System.Console.WriteLine(max);
        }

        //Get Average of Array
        public static void GetAverage(int[] numbers){
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum = sum + numbers[i];
            }
            System.Console.WriteLine(sum/numbers.Length);
        }

        //Array of Odds
        public static void OddArray(){
            int[] newArr;
            int j = 0;
            int k = 0;
            for(int i = 0; i <= 255; i++){
                if(i % 2 == 1){
                    j++;
                }
            }
            newArr = new int[j];
            for(int i = 0; i <= 255; i++){
                if(i % 2 == 1){
                    k++;
                    newArr[k-1] = i;
                }
            }
            for(int i = 0; i < newArr.Length; i++){
                System.Console.WriteLine(newArr[i]);
            }
        }

        //Greater than Y
        public static void GreaterThanY(int[] numbers, int y){
            int num = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    num++;
                }
            }
            System.Console.WriteLine(num);
        }

        //Square the Values
        public static void SquareArrayValues(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = (numbers[i] * numbers[i]);
                System.Console.WriteLine(numbers[i]);
            }
        }

        //Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
                System.Console.WriteLine(numbers[i]);
            }
        }

        //Min, Max, and Average
        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min){
                    min = numbers[i];
                }
                sum = sum + numbers[i];
            }
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(sum/numbers.Length);
        }

        //Shifting the values in an array
        public static void ShiftValues(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(i + 1 == numbers.Length){
                    numbers[i] = 0;
                }
                else{
                    numbers[i] = numbers[i+1];
                }
                System.Console.WriteLine(numbers[i]);
            }
        }

        //Number to String
        public static void NumToString(int[] numbers){
            List<object> stringArr = new List<object>();
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    stringArr.Add("Dojo");
                }
                else{
                    stringArr.Add(numbers[i]);
                }
            }
            foreach(var item in stringArr){
                System.Console.WriteLine(item);
            }
        }
    }
}
