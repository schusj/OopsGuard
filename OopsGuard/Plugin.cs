using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace OopsGuard;

public sealed class Plugin : IDalamudPlugin
{
    [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] internal static IGameInteropProvider GameInteropProvider { get; private set; } = null!;


    private readonly ActionDisabler actionDisabler;

    public Plugin()
    {
        actionDisabler = new ActionDisabler(GameInteropProvider);
        actionDisabler.Enable();
    }

    public void Dispose()
    {
        actionDisabler.Dispose();
    }

}
