// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Worksheet_CTarget : TargetRules
{
	public Worksheet_CTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Worksheet_C" } );
	}
}
