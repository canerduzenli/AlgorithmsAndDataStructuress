

string str = "Programmatic Python";
var result = str.ToLower()
                .GroupBy(c => c)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToArray();
