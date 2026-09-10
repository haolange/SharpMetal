# SharpMetal

Low-level Objective-C and Metal bindings for .NET 10, including Foundation, Metal, MetalFX and QuartzCore. Native resources have explicit ownership. Managed layout inspection is portable; native execution requires an Apple host and system frameworks.

## Getting started

- Install the .NET SDK selected by [global.json](global.json). Runtime projects target .NET 10; compiler generators retain their declared build-time targets.
- For source development, copy [stack.local.props.example](stack.local.props.example) to `stack.local.props` and adjust the checkout paths. The template assumes sibling InfinityStack repositories; only mapped dependencies used by the chosen build need to be present. Product tests may require additional peers.
- Follow [docs/VERIFICATION.md](docs/VERIFICATION.md) for the authoritative build, test, pack and platform-specific commands. Start with the [standalone sample](samples/SharpMetal.Sample).
- For package consumption, use `StackReferenceMode=Package` and an explicitly supplied feed containing the matching product versions. Source and package modes apply to the complete graph. Package availability is determined by published assets; this README does not assume a nuget.org release.

## Repository layout

`src/` owns runtime code, `samples/` runnable workloads, `docs/` design and verification, and `eng/` verification automation. Tests and tools live in their own directories where applicable. [DESIGN.md](DESIGN.md) defines product boundaries; [AGENTS.md](AGENTS.md) defines contribution rules.

Build outputs, isolated package caches and raw run evidence belong under ignored `artifacts/`. Commit source, reviewed lock files and portable configuration templates; keep machine paths in `stack.local.props`. Historical run summaries do not imply that their disposable output directories still exist.

## License

[MPL-2.0](LICENSE). Existing copyright notices and third-party notices remain with their respective files. Extraction records and inherited notices are retained under [docs/provenance](docs/provenance).

Apple frameworks and libobjc are supplied by the OS. The original upstream is [IsaacMarovitz/SharpMetal](https://github.com/IsaacMarovitz/SharpMetal). Extraction history is recorded in [provenance](docs/provenance); the inherited MPL-2.0 text and notices are preserved.
