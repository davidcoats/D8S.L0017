# D8S.L0017
Personal, unopinionated, .NET Standard 2.1 foundation library.

=> Note: all code here should REALLY be in F10Y.L0000.


Sub-libraries are reserved for internal structure (leaf function libraries, function libraries relying on leaf libraries and a leaf value library, etc.).

Note: internal structure can be driven by libraries that depend on custom types (from type sub-libraries).


## Instance Set Descriptor

Domain Set:
	.NET
	C#

Instance Variety Descriptor (Aggregation, count: 3)
	Functions: instance variety name
	UtilityTypes: instance variety name
	Values: instance variety name

D8S: organization name
Public: visibility

netstandard2.1: target framework moniker
CONSTRAINED: D8S.L0017

General: applicability
Unopinionated: opinion


## Instance Varieties

Allowed:

- Functions
- Utility Types (no Data Types)
- Values

Disallowed: All others, including:

- Data Types (Utility Types are allowed)
- Executables (Scripts, Demonstrations, Experiments, Explorations; these are in the associated Construction project, or better, in the central scripts project)

- Service Definitions and Implementations
- IHasX/IWithX types
- Razor Components
- Database entities
- Marker Types


## Allowed Dependencies

- netstandard2.1: target framework
- Marker attribute types libraries:
	- R5T.T0143 - Markers
	- R5T.T0131 - Values
	- R5T.T0132 - Functions
	- R5T.T0142 - Types
- Documentation:
	- R5T.T0156 - Documentations
	- R5T.Y0006 - .NET documentations


## Opinions

Allowed Opinions:

- Unopinionated


Disallowed Opinions:

- Context Based
- IHasX/IWithX
- Service Based


## Internal Structure

Because the D8S.L0017 library is so strictly specified (C#/.NET foundation, .NET Standard 2.1, personal, unopinionated, generally applicable)

While this library strongly prefers a single, unified library approach for D8S.L0017, a multi-library internal structure is allowed via:

- D8S.L0017.L000:
- D8S.L0017.L001:
	- D8S.L0017.L000
	- D8S.L0017.F000
	- D8S.L0017.Z000
