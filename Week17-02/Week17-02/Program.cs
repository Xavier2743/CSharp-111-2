using System.Net;

Task<string> task = MyDownloadPageAsync("https://www.google.com");
Console.WriteLine("Hi1");

string page = task.Result;
Console.WriteLine("Hi2");

static async Task<string> MyDownloadPageAsync(string url)
{
    var webClient = new WebClient();
    var task = webClient.DownloadStringTaskAsync(url);
    string content = await task;
    return content;
}