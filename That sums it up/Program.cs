List<double> listOfnumbers = new(){3.14, 2.72, 63.00, 84.7, 8.9, 4.0, 23.12};

double sum= listOfnumbers.Sum(x=>x);
double average= listOfnumbers.Average();
int countElementOfList= listOfnumbers.Count();

Console.WriteLine("somma di tutti gli elementi della lista: " + sum);
Console.WriteLine("media della lista: " + average);
Console.WriteLine("la lista ha " + countElementOfList + " elementi");



