using UnrealBuildTool;

public class PuzzleStarterProjectServerTarget : TargetRules
{
	public PuzzleStarterProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PuzzleStarterProject");
	}
}
