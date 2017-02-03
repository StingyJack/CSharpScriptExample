namespace CSharpScriptExample
{
    using System;
    using System.Data;
    using System.IO;
    using Microsoft.CodeAnalysis.CSharp.Scripting;
    using Microsoft.CodeAnalysis.Scripting;

    public class Program
    {
        private static void Main(string[] args)
        {
            var scriptCode = File.ReadAllText("objectmapper.csx");
            var scriptOptions = ScriptOptions.Default
                .AddImports("System", "System.Data")
                .WithReferences(typeof(string).Assembly)
                .WithReferences(typeof(DataSet).Assembly);

            var globalsType = new Globals
            {
                Source = new ObjType1 {Prop1 = "MuhString"},
                Dest = new ObjType2()
            };
            var script = CSharpScript.Create(scriptCode, scriptOptions, typeof(Globals));
            var result = script.RunAsync(globalsType).Result;
            if (result.Exception != null)
            {
                Console.WriteLine($"ERR:{result.Exception}");
            }
            else if (globalsType.Source.Prop1 == globalsType.Dest.Prop2)
            {
                Console.WriteLine("Win");
            }
            Console.ReadLine();
        }

      
    }
}