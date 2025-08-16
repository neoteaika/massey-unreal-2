using UnrealBuildTool;

public class PuzzleStarterProjectTarget : TargetRules
{
	public PuzzleStarterProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PuzzleStarterProject");
	}
}
