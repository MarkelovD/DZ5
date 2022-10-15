// 1 задача

// int [] test = GetArray(10, -9, 9);// вызов метода с массивом
// Console.WriteLine($"{String.Join(",",test)}");
// Console.Write("количество четных чисел = ");
// EvenNumber ();// вызов метода счета

// 2 задача

// int [] test = GetArray(10, 0, 10);// вызов метода с массивом
// Console.WriteLine($"{String.Join(",",test)}");
// Console.Write("сумма чисел стоящих на нечетных позициях массива = ");
// OddNumberSumm();// вызов метода суммы

// 3 задача

int [] test = GetArray(15, -1000, 1000);// вызов метода с массивом
Console.WriteLine($"{String.Join(",",test)}");
RaznMaxMinZnach();


//блок методов
// ##########################################################

// метод счета четных чисел (1 задача)
// void EvenNumber (){
//     int count =0;
// for (int i=0;i<test.Length;i++){
//     if (test[i]%2 ==0){
//         count++;
//     }
//     }
//     Console.WriteLine($"{count}");
// }

// метод счета чисел стоящих на нечентных позициях (2 задача)
// void OddNumberSumm(){
//     int summ = 0;
//     for (int i=0;i<test.Length;i++){
//         if (i%2 !=0){
//             summ+=test[i];
//         }
//     }
//     Console.WriteLine($"{summ}");
// }
// метод разницы максимального и минимального значения (3 задача)
void RaznMaxMinZnach (){
    int MinZnach = test[0];
    int MaxZnach = test[0];
    int razn = 0;
    for (int i = 0; i<test.Length;i++){
        if (MinZnach>test[i]){
            MinZnach = test[i];
        }
        if (MaxZnach<test[i]){
            MaxZnach = test[i];
        }
    }
    razn = MaxZnach-MinZnach;
    Console.WriteLine ($"разница максимального {MaxZnach} и минимального {MinZnach} значения массива = {razn}");
}

// метод заполнения массива (универсальный)
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}