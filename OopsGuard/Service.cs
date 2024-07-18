using Dalamud.IoC;
using Dalamud.Plugin.Services;

namespace OopsGuard;

internal class Service
{
    [PluginService] internal static IGameInteropProvider GameInteropProvider { get; private set; } = null!;
}
