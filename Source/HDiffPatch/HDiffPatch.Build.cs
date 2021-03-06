// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HDiffPatch : ModuleRules
{
	public HDiffPatch(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"PakFile"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
		OptimizeCode = CodeOptimization.Never;

		bool bHotPatcherPlugin = false;
		if (bHotPatcherPlugin)
		{
			PublicDefinitions.Add("HOTPATCHER_PLUGIN=1");
			PublicDependencyModuleNames.Add("BinariesPatchFeature");
		}
		PublicDefinitions.AddRange(new string[]
		{
			"HAVE__SETMODE=0",
			"HAVE_SETMODE=0"
		});
	}
}
