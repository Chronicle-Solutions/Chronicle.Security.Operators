using Chronicle.Plugins.Core;
using Chronicle.Security.Operators;
namespace Chronicle.Security.Operator
{
    public class Operators : IPlugable
    {
        public override string PluginName => "Operator Management";

        public override string PluginDescription => "Allow administrators to administer user security";

        public override Version Version => new Version("1.0.0.0");

        public override int Execute()
        {
            OperatorForm f = new();

            f.Show();

            return 0;
        }
    }
}
