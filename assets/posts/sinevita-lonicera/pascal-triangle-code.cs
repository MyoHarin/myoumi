using System;
using SineVita.Lonicera;
Func<int, int> factorial = (n) => {
  if (n == 0) return 1;
  int result = 1;
  for (int i = 1; i <= n; i++) {
      result *= i;
  }
  return result;
};
Func<int, int, long> combination = (r, n) => {
  if (r > n) return 0;
  return Factorial(n) / (Factorial(r) * Factorial(n - r));
};

Lonicera<int,long> PascalTriangle = new Lonicera<int,long>(growth=combination)
for (int i = 1; i < 10; i++) { // add number from 1 to 9
  PascalTriangle.Add(i, growNew=true)
}

// Print Elememnts
int index = 0;
Console.WriteLine(loniTest.Links.Count);
for (int i = 1; i < loniTest.NodeCount; i++) {
  for (int j = 0; j < i; j++) {
    Console.Write($"| {loniTest.Links[index]} ");
    index++;
  }
  Console.Write("\n");
}
Console.WriteLine();
foreach(var link in loniTest.Links) {
  Console.Write($"| {link} ");
}
using System;
Func<int, int> factorial = (n) => {
  if (n == 0) return 1;
  int result = 1;
  for (int i = 1; i <= n; i++) {
      result *= i;
  }
  return result;
};
Func<int, int, long> combination = (r, n) => {
  if (r > n) return 0;
  return Factorial(n) / (Factorial(r) * Factorial(n - r));
};

Lonicera<int,long> PascalTriangle = new Lonicera<int,long>(growth=combination)
for (int i = 1; i < 10; i++) { // add number from 1 to 9
  PascalTriangle.Add(i, growNew=true)
}

// Print Elememnts
int index = 0;
Console.WriteLine(loniTest.Links.Count);
for (int i = 1; i < loniTest.NodeCount; i++) {
  for (int j = 0; j < i; j++) {
    Console.Write($"| {loniTest.Links[index]} ");
    index++;
  }
  Console.Write("\n");
}
