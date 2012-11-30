using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libAdWired.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, IsCxx = true, Frameworks = "MessageUI MediaPlayer SystemConfiguration CoreGraphics CFNetwork QuartzCore UIKit AudioToolbox", LinkerFlags = "-lstdc++")]