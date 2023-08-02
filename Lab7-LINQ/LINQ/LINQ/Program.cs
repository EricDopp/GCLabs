using System.Security.Cryptography.X509Certificates;

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

var minVal = nums.Min();
Console.WriteLine(minVal);
var maxVal = nums.Max();
Console.WriteLine(maxVal);
var max10k = nums.Where(x => x < 10000).Max();
Console.WriteLine(max10k);
var tenToTenTens = nums.Where(x => x > 10 && x < 100).ToList();
tenToTenTens.ForEach(x => Console.WriteLine(x));
var sixToSevenFigs = nums.Where(x => x >= 100000 && x <= 999999).ToList();
sixToSevenFigs.ForEach(x => Console.WriteLine(x));
var evenNumers = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine(evenNumers);