// using System.Collections.Generic;
//
// namespace Task3;
//
// public class Test
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public string Value { get; set; }
//     public Test[] Values { get; set; }
//
//     public void AddToDictionary(Dictionary<int,Test> testsIdDictionary)
//     {
//         testsIdDictionary.Add(Id, this);
//         
//         if (Values == null)
//         {
//             return;
//         }
//         
//         foreach (var test in Values)
//         {
//             test.AddToDictionary(testsIdDictionary);
//         }
//     }
// }
