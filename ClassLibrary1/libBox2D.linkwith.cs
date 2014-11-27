using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith(
   "libBox2D.a",
   LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64,
   ForceLoad = true,
   Frameworks = "Foundation Accelerate CoreFoundation CoreGraphics AssetsLibrary AVFoundation CoreImage CoreMedia CoreVideo QuartzCore ImageIO",
   LinkerFlags = "-stdlib=libstdc++ -ObjC -lc++",
   IsCxx = true)]