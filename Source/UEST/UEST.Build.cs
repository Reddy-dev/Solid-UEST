﻿using UnrealBuildTool;

public class UEST : ModuleRules
{
	public UEST(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new[]
		{
			"Boost",
			"Core",
			"CoreUObject",
			"Engine",
			"EngineSettings",
			"IrisCore",
		});

		if (Target.bBuildDeveloperTools)
		{
			PublicDependencyModuleNames.AddRange(new[]
			{
				"CQTest",
			});
		}
	}
}
