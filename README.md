# SharpMetal

Low-level Objective-C and Metal bindings for .NET 10. Foundation, Metal, MetalFX and QuartzCore APIs retain explicit native ownership. Creating native resources requires an Apple host; managed structure/layout inspection is portable. Apple frameworks and libobjc are supplied by the operating system and are not redistributed in the package.

The sample creates a Metal device, allocates a shared buffer, writes and reads its memory, then releases the buffer and device. On other hosts it checks managed layouts and reports that the native workload is unavailable. See [verification](docs/VERIFICATION.md) and [design](DESIGN.md).

The original SharpMetal repository ancestry and MPL-2.0 license are preserved; InfinityBrowser extraction provenance and its root MIT notice are included under docs/provenance. The original fork is https://github.com/IsaacMarovitz/SharpMetal.
