// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Weep : ModuleRules
{
	public Weep(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Weep",
			"Weep/Variant_Platforming",
			"Weep/Variant_Platforming/Animation",
			"Weep/Variant_Combat",
			"Weep/Variant_Combat/AI",
			"Weep/Variant_Combat/Animation",
			"Weep/Variant_Combat/Gameplay",
			"Weep/Variant_Combat/Interfaces",
			"Weep/Variant_Combat/UI",
			"Weep/Variant_SideScrolling",
			"Weep/Variant_SideScrolling/AI",
			"Weep/Variant_SideScrolling/Gameplay",
			"Weep/Variant_SideScrolling/Interfaces",
			"Weep/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
