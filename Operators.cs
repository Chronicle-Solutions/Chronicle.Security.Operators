using Chronicle.Plugins.Core;
using Chronicle.Security.Operators;
namespace Chronicle.Security.Operator
{
    public class Operators : IPlugable
    {
        public string PluginName => "Operator Management";

        public string PluginDescription => "Allow administrators to administer user security";

        public Version Version => new Version("1.0.0.0");

        public int Execute()
        {
            OperatorForm f = new();

            f.Show();

            return 0;
        }
    }
}
