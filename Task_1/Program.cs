// FIRST SOLUTION

/* Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <=number){
    Console.WriteLine(Math.Pow(i, 3));
    i+=1;
} */


// SECOND SOLUTION    

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Cubes table: ");

for (int i = 1; i <= number; i++){
    Console.WriteLine(Math.Pow(i, 3));
}

// Я не стала решать задачу с массивами, так как мне кажется, они тут совсем не нужны, это не тот случай