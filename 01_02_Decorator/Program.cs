using System.Net;
using _01_02_Decorator;


    WebClient webClient = new WebClient();

    WebClientDecorator WebClientDecorator = new WebClientDecorator(webClient);

string resultTopLearn = WebClientDecorator.DownloadString("https://Toplearn.com");
string resultOkhovat = WebClientDecorator.DownloadString("https://price.okhovat.info");
Console.WriteLine(resultTopLearn);
Console.WriteLine("----------------------------------------");
Console.WriteLine(resultOkhovat);
    Console.ReadLine(); 
