using SPTarkov.Server.Core.Models.Spt.Mod;
using SemRange = SemanticVersioning.Range;
using SemVersion = SemanticVersioning.Version;

namespace KAC_KS1;

public sealed record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.spy.kac-ks1";
    public override string Name { get; init; } = "kac-ks1";
    public override string Author { get; init; } = "Spy";
    public override SemVersion Version { get; init; } = new("1.0.5");
    public override SemRange SptVersion { get; init; } = new("^4.0.13");
    public override string License { get; init; } = "MIT";
    public override bool? IsBundleMod { get; init; } = true;
    public override Dictionary<string, SemRange>? ModDependencies { get; init; } = new()
    {
        ["com.wtt.commonlib"] = new SemRange("~2.0.20")
    };
    public override string? Url { get; init; } = null;
    public override List<string>? Contributors { get; init; } = null;
    public override List<string>? Incompatibilities { get; init; } = null;
}
