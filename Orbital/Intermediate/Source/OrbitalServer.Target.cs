using UnrealBuildTool;

public class OrbitalServerTarget : TargetRules
{
	public OrbitalServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Orbital");
	}
}
