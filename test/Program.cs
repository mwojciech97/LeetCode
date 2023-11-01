// See https://aka.ms/new-console-template for more information
Dictionary<string, int> dic = new Dictionary<string, int>();
string[] as1 = { "X:1", "B:2", "X:2", "B:-1", "C:0"};

foreach (string s in as1)
{
    if(!dic.ContainsKey(s.Split(':')[0])) dic.Add(s.Split(':')[0], int.Parse(s.Split(':')[1]));
    else dic[s.Split(':')[0]] += int.Parse(s.Split(':')[1]);
}
foreach(var s in dic)
{
    Console.WriteLine(s.Key + ", " + s.Value);
}
 