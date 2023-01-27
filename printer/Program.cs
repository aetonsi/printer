
// https://stackoverflow.com/questions/199528/c-sharp-console-receive-input-with-pipe
string text = "";

// piping AND no command line arguments (arg 0 is the program itself)
if (Console.IsInputRedirected && Environment.GetCommandLineArgs().Length == 1)
{
    text = new StreamReader(Console.OpenStandardInput()).ReadToEnd();
}
else if (Environment.GetCommandLineArgs().Length > 1) // if at least 1 command line argument (arg 0 is the program itself)
{
    text = String.Join(' ', Environment.GetCommandLineArgs().Skip(1).ToArray());
}

Console.Write(text);