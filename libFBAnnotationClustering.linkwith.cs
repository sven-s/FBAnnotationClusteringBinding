using System;
using ObjCRuntime;

[assembly: LinkWith ("libFBAnnotationClustering.a", LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
