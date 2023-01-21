## SlavRim Example Mod

### Template mod for easier development startup.

### Prerequisites:

- [.NET SDK 7+](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [.NET Runtime & SDK 4+](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) (You can set your own TargetFramework)
- Installed game.

### How to setup:

1. Change path(<b>default is: "D:\Steam\steamapps\common\RimWorld\"</b>) to the game directory in files to yours:<br/>
Shared.mod.props.csproj<br/>
Properties/launchSettings.json

2. Delete files:<br/>
.github/sync.yml<br/>
.github/workflows/sync.yml

3. Cleanup solution.

4. If you did read this whole file, just hide or delete it.

### Q&A's:

#### 1: <i>What's Shared.mod.props.csproj and why do we need it?</i>
- It's base shared mod properties, it contains default configurations, building events and other helpful stuff that you'll not need to write by yourself.

#### 2: <i>What's Assets folder purpose?</i>
- Assets is the root directory of your mod, you can place there anything that you want to see in the root of mod(<b>For example: About, Defs, Languages etc.</b>).

#### 3. <i>How to build for all versions?</i>
- To build for multiple versions, select lowest version, Cleanup solution, use <b>Build > Batch Build</b>.

#### 4. What's happens with Cleanup and Build?
- Cleanup resets build folder, so you'll need to rebuild all.
- Build updates assemblies and tries to update files.

#### 5. I don't know how this works, can you help or explain to me?
- Create an issue and we'll make things clearly.

### If you found a bug or have some ideas, consider creating of issue or a pull request.