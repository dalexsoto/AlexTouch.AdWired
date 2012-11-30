using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlexTouch.AdWired
{
	[BaseType (typeof (NSObject))]
	[Model]
	interface AdWiredDelegate 
	{
		[Export ("bannerDidStart:"), EventArgs("AdWiredDelegateArgs")]
		void DidStart (AWView bannerView);
		
		[Export ("bannerDidStop:"), EventArgs("AdWiredDelegateArgs")]
		void DidStop (AWView bannerView);
		
		[Export ("bannerDidFail:"), EventArgs("AdWiredDelegateArgs")]
		void DidFail (AWView bannerView);
	} 
	
	[BaseType (typeof (UIView),
	Delegates= new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (AdWiredDelegate) })]
	interface AWView
	{
		[Wrap ("WeakDelegate")]
		AdWiredDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export("bannerDidStartSelector", ArgumentSemantic.Assign)]
		Selector BannerDidStartSelector { get; set; }

		[Export("bannerDidStopSelector", ArgumentSemantic.Assign)]
		Selector BannerDidStopSelector { get; set; }

		[Export("bannerDidFailSelector", ArgumentSemantic.Assign)]
		Selector BannerDidFailSelector { get; set; }
		
		[Export ("placeId", ArgumentSemantic.Copy)]
		string PlaceId { get; set; }

		[Export ("keywords", ArgumentSemantic.Copy)]
		string [] Keywords { get; set; }
		
		[Export ("bannerType", ArgumentSemantic.Assign)]
		AWBannerType BannerType { get; }
		
		[Export ("closeAnimation", ArgumentSemantic.Assign)]
		AWViewAnimation CloseAnimation { get; set; }
		
		[Export ("frameLocked", ArgumentSemantic.Assign)]
		bool FrameLocked { get; set; }
		
		[Export ("frameLock", ArgumentSemantic.Assign)]
		RectangleF FrameLock { get; set; }
		
		[Export ("fullscreenOrientationMask", ArgumentSemantic.Assign)]
		AWBannerOrientation FullscreenOrientationMask { get; set; }
		
		[Export ("setDebugMode:")] [Static]
		void SetDebugMode (bool trueFalse);

		[Export ("isDebugMode")] [Static]
		bool IsDebugMode { get; }

		[Export ("initialize")] [Static]
		void Initialize ();

		[Export ("initWithDelegate:")]
		IntPtr Constructor (AdWiredDelegate aDelegate);

		[Export ("loadForPlaceId:")]
		bool LoadForPlaceId (string placeId);

		[Export ("loadForPlaceId:keywords:")]
		bool LoadForPlaceId (string placeId, string [] keywords);

		[Export ("changeOrientation:")]
		void ChangeOrientation (UIInterfaceOrientation orientation);

		[Export ("removeWithAnimation:")]
		void RemoveWithAnimation (AWViewAnimation animation);

		[Export ("showInView:placeId:")]
		void ShowInView (UIView view, string placeId);

		[Export ("showInView:placeId:keywords:")]
		void ShowInView (UIView view, string placeId, string [] keywords);
	}
}

