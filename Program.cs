// 1 задача
int [] test = GetArray(10, -9, 9);// вызов метода с массивом
Console.WriteLine($"{String.Join(",",test)}");
Console.Write("количество четных чисел = ");
EvenNumber ();// вызов метода счета








// метод счета четных чисел
void EvenNumber (){
    int count =0;
for (int i=0;i<test.Length;i++){
    if (test[i]%2 ==0){
        count++;
    }
    }
    Console.WriteLine($"{count}");
}
// метод заполнения массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}