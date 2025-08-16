using UnrealBuildTool;

public class PuzzleStarterProjectClientTarget : TargetRules
{
	public PuzzleStarterProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PuzzleStarterProject");
	}
}
