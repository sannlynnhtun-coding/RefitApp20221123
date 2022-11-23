using Newtonsoft.Json;
using Refit;
using RefitApp20221123.Shared;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var l_MinTheinKhaApi = RestService.For<IMinTheinKhaController>("https://localhost:7239");
var lstQuestion = await l_MinTheinKhaApi.Get();
var answer = await l_MinTheinKhaApi.Get(10);

Console.WriteLine(JsonConvert.SerializeObject(lstQuestion, Formatting.Indented));
Console.WriteLine(JsonConvert.SerializeObject(answer, Formatting.Indented));
Console.ReadKey();