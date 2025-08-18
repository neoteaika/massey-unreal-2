using UnrealBuildTool;

public class OrbitalClientTarget : TargetRules
{
	public OrbitalClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Orbital");
	}
}
