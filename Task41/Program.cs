Console.Clear();
Console.WriteLine("Введите число и нажмите Enter");
string result=string.Empty;
string value=string.Empty;
value=Console.ReadLine();


do{
if (value=="Q" || value=="q"){break ;}
Console.WriteLine("Введите другое число и нажмите Enter. Для продолжения нажмите Q");
result=result+value+" ";
value=Console.ReadLine();
}
while (value!="Q");

string[] array = result.Split(" ");
int counter = 0;
for (int i=0;i<array.Length;i++){
    Console.Write(array[i]);

      
    if(int.Parse(Convert.ToString(array[i]))<0){counter+=counter;}
    if(i<array.Length-2){
        Console.Write(", ");
    }
   if(i==array.Length-1)
    Console.Write(" -> ");

    
}
Console.Write(counter);












