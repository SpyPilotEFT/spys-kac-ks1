using System.Reflection;
using Microsoft.Extensions.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using WTTServerCommonLib;

namespace KAC_KS1;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 2)]
public sealed class Ks1(WTTServerCommonLib.WTTServerCommonLib wttCommon, ILogger<Ks1> log) : IOnLoad
{
    public async Task OnLoad()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (string resourceName in assembly.GetManifestResourceNames())
        {
            log.LogDebug("[KAC-KS1] Embedded resource: {Res}", resourceName);
        }

        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly, null);
        await wttCommon.CustomLocaleService.CreateCustomLocales(assembly, null);
        await wttCommon.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly, null);

        log.LogInformation("Spy's KAC KS1 Loaded. Pretty CAG eh?");
    }
}
