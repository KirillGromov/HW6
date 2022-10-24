void ShowPosNum(int size){
    int[] arr = new int[size];
    int counter = 0;
    for(int i = 0; i < arr.Length; i++){
        arr[i] = int.Parse(Console.ReadLine());
        if(arr[i]>0){
            counter++;
        }
    }
    ShowArr(arr);
    Console.WriteLine(counter);
}

void ShowArr(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("");
}

int InfoAboutSize(){
    Console.WriteLine("Сколько цифр будет?");

    int size = int.Parse(Console.ReadLine());

    return size;
}

ShowPosNum(InfoAboutSize());


