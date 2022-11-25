## SlavRim Example Mod

### Template mod for easier development startup.

### Prerequisites:

- [.NET SDK 6+](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [.NET Runtime + SDK 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
- Installed game.

### How to setup:

1. Delete .github folder.
2. Change path to the game directory(<b>default is: "D:\Steam\steamapps\common\RimWorld\"</b>) to your's.
3. Cleanup solution.
4. If you readed this whole file, just hide or delete it.

### Q&A's:

#### 1: <i>What's Shared.mod.props.csproj and why do we need it?</i>
- It's base shared mod properties, it contains default configurations, building events and other helpful stuff that you'll not need to write by yourself.

#### 2: <i>What's Assets folder purpose?</i>
- Assets is the root directory of your mod, you can place there anything that you want to see in the root of mod(<b>For example: About, Defs, Languages etc.</b>).

#### 3. <i>How to build for all versions ?</i>
- To build for multiple versions, select lowest version, Cleanup solution, use <b>Build > Batch Build</b>.

#### 4. What's happens with Cleanup and Build ?
- Cleanup resets build folder, so you'll need to rebuild all.
- Build updates assemblies and tries to update files.
