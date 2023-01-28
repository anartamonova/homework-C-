// See https://aka.ms/new-console-template for more information
Console.Write("Введите цифру: ");
int x = Convert.ToInt32(Console.ReadLine());
      string y = x.ToString();
char[] num= y.ToCharArray();

if (num.Length == 5) {
  if (num[0] == num[4] || num [1] == num [3]) {
    Console.WriteLine(" --> да");
  }
  else {
    Console.WriteLine(" --> нет");
  };
}
else {
  Console.WriteLine("Введите пятизначное число"); 
}
       
