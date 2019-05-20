using UnrealBuildTool;

public class AILoveYouTarget : TargetRules
{
	public AILoveYouTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("AILoveYou");
	}
}
