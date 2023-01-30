


Console.WriteLine(String.Join(", ", Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse)
                                                      .Where(x => x % 2 ==0)
                                                      .OrderBy(x => x)
                                                      .ToArray()));


