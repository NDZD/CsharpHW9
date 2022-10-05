// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//Console.Clear();

int GetResult(int M, int N){
    
    int result = 0;
    if(N == M) return result+N;
    
    return N + GetResult(M, N - 1); 
    }

    System.Console.WriteLine(GetResult(4,8));