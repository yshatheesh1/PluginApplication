using System;

namespace PluginBase
{
    public interface Plugin {
        string Name { get; set; }
        string Description { get; set; }
        int Execute();
    }
}
