// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void InputNums(){
    int b1, k1, b2, k2;
    Console.WriteLine("Введите b1");
    b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1");
    k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2");
    b2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2");
    k2 = int.Parse(Console.ReadLine());
    ShowRes(b1, k1, b2, k2);
}

void ShowRes(int b1, int k1, int b2, int k2){
    if ((k1 == k2) && (b1 == b2)){
        Console.WriteLine("Прямые совпадают");
    }else if(k1==k2){
        Console.WriteLine("Прямые параллельны");
    }else {  
        float x = (float)(b2-b1)/(float)(k1-k2);  
        float y = (float)(k1*(b2-b1))/(float)(k1-k2)+b1;  
        Console.WriteLine("X= " + x); 
        Console.WriteLine("Y= " + y);
    }
}

InputNums();


// if ((k1 == k2) && (b1 == b2)){
//     cout << "Прямые совпадают";
// }else if (k1==k2){
//   cout << "Прямые параллельны";
// }  else {  
//     x=(b2-b1)/(k1-k2);  
//     y=(k1*(b2-b1))/(k1-k2)+b1;  
//     cout << "x=" << x << "y=" << y;  
// }