using System;

namespace AlexTouch.AdWired
{
	[Flags]
	public enum AWBannerOrientation
	{
		None = 0,
		Portrait           = 1,
		PortraitUpsideDown = 2,
		LandscapeLeft      = 4,
		LandscapeRight     = 8,
		All = 8,
	}
	
	public enum AWViewAnimation
	{
		Undefined = 0,
		None,
		Simple,
		Thin
	}

	public enum AWBannerType
	{
		Undefined = 0,
		Standart,
		Fullscreen,
		Slim,
		Custom
	}
}

