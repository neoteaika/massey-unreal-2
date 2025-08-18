using UnrealBuildTool;

public class OrbitalTarget : TargetRules
{
	public OrbitalTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Orbital");
	}
}
