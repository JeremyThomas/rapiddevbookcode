// Guids.cs
// MUST match guids.h
using System;

namespace JeremyThomas.EnumerableVisualizerVSPackage
{
    static class GuidList
    {
        public const string guidEnumerableVisualizerVSPackagePkgString = "07ea796c-6649-482d-82f8-b5be69a5f574";
        public const string guidEnumerableVisualizerVSPackageCmdSetString = "3600c23f-82e6-45e4-bdd8-0b804f4dd2a9";

        public static readonly Guid guidEnumerableVisualizerVSPackageCmdSet = new Guid(guidEnumerableVisualizerVSPackageCmdSetString);
    };
}