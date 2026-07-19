using System.Reflection;
using Microsoft.Extensions.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SemRange = SemanticVersioning.Range;
using SemVersion = SemanticVersioning.Version;


namespace JSOC_SWR;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.spy.jsoc-swr";
    public override string Name { get; init; } = "JSOC-SWR-FDK";
    public override string Author { get; init; } = "Spy";
    public override SemVersion Version { get; init; } = new("2.0.0");
    public override SemRange SptVersion { get; init; } = new("^4.0.13");
    public override string License { get; init; } = "MIT";
    public override bool? IsBundleMod { get; init; } = true;

    public override Dictionary<string, SemRange>? ModDependencies { get; init; } = new()
    {
        ["com.wtt.commonlib"] = new SemRange("~2.0.20"),
        ["com.epicrangetime.aio"] = new SemRange("~4.0.8")
    };

    public override string? Url { get; init; } = null;
    public override List<string>? Contributors { get; init; } = null;
    public override List<string>? Incompatibilities { get; init; } = null;
};

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 3)]
public class JsocSwr(WTTServerCommonLib.WTTServerCommonLib wttCommon, ILogger<JsocSwr> log) : IOnLoad
{
    public async Task OnLoad()
    {
        var assembly = Assembly.GetExecutingAssembly();

        foreach (var name in assembly.GetManifestResourceNames())
        {
            log.LogDebug("[JSOC-SWR] Embedded resource: {Res}", name);
        }

        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly, null);
        await wttCommon.CustomLocaleService.CreateCustomLocales(assembly, null);
        await wttCommon.CustomAssortSchemeService.CreateCustomAssortSchemes(assembly, null);

        log.LogInformation("Loaded Spy's JSOC-SWR. Pretty CAG eh?");
        await Task.CompletedTask;

    }
}
