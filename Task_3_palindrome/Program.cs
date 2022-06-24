Console.Write("Enter 5-digit number: ");
int number = int.Parse(Console.ReadLine());

if (number > 9999 & number < 100000){
    string str = number.ToString();
    if (str[0] == str[4] & str[1] == str[3]){
        Console.Write("Yes, it's a palindrome");
    }
    else{
        Console.Write("No, it's not a palindrome");
    }
}
else{
    Console.Write("Your number is not correct. Try again.");
} 










