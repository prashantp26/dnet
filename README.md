# C#/.Net + Blazor 

> [!note]
> As a project, it is essentially the foundations for a homebrew ORM - a simple learning WIP tool.
> Bullet items with ~~strikethrough~~ represent unfinished tasks.

This repo attempts to demonstrate use of following C#/.Net, and to some extent, some relevant CS concepts through a Blazor webapp project in .Net 8:

```mermaid
---
title: Data mapper
---
flowchart TB 
	IRepository -- implement --> RepoBase 
	RepoBase -- inherit --> EntityRepo 
	DataContext -- -.loaded-onto.-> --> RepoBase
    EntityRepo -- injected-thru --> RepoMan 	
```

### Types
- use of compound data types
    - structs
    - classes
    - records 
    - generics
    - ~~anonymous types~~
    - ~~boxing/unboxing~~

### Data Structures
- enumerables/collections
- ~~Graphs and Trees~~

### Control flow
- conditionals
- ~~recursion~~

### OOP
- polymorphism
- composition/inheritance
- abstract/virtual members
- access modifiers:
    - private, protected, internal, public, sealed

### Design patterns
- Inversion of Control
- Repository
- Adapter
- Decorator (extension methods)

#### .NET Libraries
- LINQ
- ~~EF Core~~

### Concurrent programming
- async/await using Task

### Blazor
- Interactive SSR render mode
- ~~Interactive WASM (webassembly)~~
- ~~Interactive AUTO~~


