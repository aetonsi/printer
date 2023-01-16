
// https://stackoverflow.com/questions/199528/c-sharp-console-receive-input-with-pipe
string text;
if (Console.IsInputRedirected) {
    // Console.Error.WriteLine("pipe");
    text = new StreamReader(Console.OpenStandardInput()).ReadToEnd();
} else {
    // Console.Error.WriteLine("args");
    text = String.Join(' ', Environment.GetCommandLineArgs().Skip(1).ToArray());
}

Console.Write(text);