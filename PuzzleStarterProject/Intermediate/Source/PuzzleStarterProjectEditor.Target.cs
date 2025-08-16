using UnrealBuildTool;

public class PuzzleStarterProjectEditorTarget : TargetRules
{
	public PuzzleStarterProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PuzzleStarterProject");
	}
}
