// using System.Collections.Generic;
//
// namespace Task3;
//
// public class TestsWrapper
// {
//     public Test[] Tests { get; set; }
//
//     public Dictionary<int, Test> GetTestsDictionary()
//     {
//         var testsIdDictionary = new Dictionary<int, Test>();
//
//         foreach (var test in Tests)
//         {
//             // var innerTests = test.GetAllInnerTests();
//             // foreach (var innerTest in innerTests)
//             // {
//             //     testsIdDictionary.Add(innerTest.Id, innerTest);
//             // }
//
//             test.AddToDictionary(testsIdDictionary);
//         }
//
//         return testsIdDictionary;
//     }
// }