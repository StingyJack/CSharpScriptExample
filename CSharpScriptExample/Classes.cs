namespace CSharpScriptExample
{
    using System.Collections.Generic;
    using System.Text;

    public class Globals
    {
        public ObjType1 Source { get; set; }
        public ObjType2 Dest { get; set; }
    }

    public class ObjType1
    {
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
        public Dictionary<string, StringBuilder> StringBuilders { get; set; }
    }

    public class ObjType2
    {
        public string Prop2 { get; set; }
        public int Prop1 { get; set; }
        public List<string> StringBuilderContent { get; set; }
    }
}