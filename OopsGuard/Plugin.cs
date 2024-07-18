using Dalamud.Plugin;

namespace OopsGuard;

public sealed class Plugin : IDalamudPlugin
{
    private readonly ActionDisabler actionDisabler;

    public Plugin(IDalamudPluginInterface pluginInterface)
    {
        pluginInterface.Create<Service>();
        actionDisabler = new();
    }

    public void Dispose()
    {
        actionDisabler.Dispose();
    }
}
