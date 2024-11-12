using homework;
using Homework;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //int index = ListHelper.FindFirstIndex(numbers, 3);
        //Console.WriteLine("Index of 3: " + index); 

        //List<string> words = new List<string> { "kafka", "dostoevsky", "dochanashvili" };
        //int wordIndex = ListHelper.FindFirstIndex(words, "dochanashvili");
        //Console.WriteLine("Index of 'dochanashvili': " + wordIndex); 

        //int notFoundIndex = ListHelper.FindFirstIndex(numbers, 10);
        //Console.WriteLine("Index of 10: " + notFoundIndex);


        //2
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //int index = listHelper2.FindLastIndex(numbers, 3);
        //Console.WriteLine("Index of 3: " + index);

        //List<string> words = new List<string> { "kafka", "dostoevsky", "dochanashvili" };
        //int wordIndex = listHelper2.FindLastIndex(words, "dochanashvili");
        //Console.WriteLine("Index of 'dochanashvili': " + wordIndex);

        //int notFoundIndex = listHelper2.FindLastIndex(numbers, 10);
        //Console.WriteLine("Index of 10: " + notFoundIndex);

        //3
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 3, 5, 3 };
        //var indices = FindAll.FindAllIndex(numbers, 3);

        //Console.WriteLine("Indices of 3: " + string.Join(" , ", indices)); 



        //5
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //var lastNumber = FindLast.FindLastObjectWithIndex(numbers);
        //Console.WriteLine("Last object: " + lastNumber.lastObject + "Last index: " + lastNumber.index); 

        //List<string> words = new List<string> { "kafka", "dostoevsky", "dochanashvili" };
        //var lastWord = FindLast.FindLastObjectWithIndex(words);
        //Console.WriteLine("Last object: " + lastWord.lastObject + "Last index: " + lastWord.index); 


        //List<string> emptyList = new List<string>();
        //var notFound = FindLast.FindLastObjectWithIndex(emptyList);
        //Console.WriteLine("Last object: " + notFound.lastObject); 
        //Console.WriteLine("Last index: " + notFound.index); 

        //6
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 3, 2, 3 };
        //var result = AllObject.FindAllObjectsWithIndex(numbers, 3);
        //Console.WriteLine("Found objects:");
        //for (int i = 0; i < result.objects.Count; i++)
        //{
        //    Console.WriteLine($"Object: {result.objects[i]}, Index: {result.indices[i]}");
        //}

        //7

        //List<int> numbers = new List<int> { 1, 5, 3, 9, 2 };
        //int maxvalue = MaxValue.FindMaxValue(numbers);
        //Console.WriteLine($"Maximum value: {maxvalue}"); 

        //8

        List<int> numbers = new List<int> { 1, 5, 3, 9, 2 };
        int minValue = minvalue.Findminvalue(numbers); 
        Console.WriteLine($"Minimum value: {minValue}"); 


    }
}
