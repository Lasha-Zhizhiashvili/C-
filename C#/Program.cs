using C_;

//int[] intArray = { 1, 2, 3 };
string[] names = { "Nika", "Giorgi", "Daviti", "Daviti" };

List<string> names2 = new List<string> { "Nika", "Giorgi", "Daviti", "Daviti" };

//var result = Algorithm.FindAll(names, x => x.EndsWith("i"));
//var result = Algorithm.FindAll(names, x => x[x.Length - 1] == 'i');

var res = Algorithm.Distinct(names, x => x == "Nika");
var res1 = Algorithm.Any(names2, x => x == "Nika");
var res2 = Algorithm.All(names2, x => x == "Nika");

Console.ReadLine();