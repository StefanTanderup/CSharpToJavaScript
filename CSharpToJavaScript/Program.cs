using CSharpToJavaScript;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string inputPath = args[0];
        string outputPath = args[1];

        CSTOJS cstojs = new CSTOJS();
        cstojs.Options.DisableConsoleOutput = true;
        cstojs.Options.OutPutPath = outputPath;
        await cstojs.GenerateOneAsync(inputPath);
    }
}