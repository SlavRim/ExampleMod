global using Mod = ExampleMod.Mod;

namespace ExampleMod;

public sealed class Mod : Verse.Mod
{
    public static Mod Instance { get; private set; }
    public Mod(ModContentPack content) : base(content)
    {
        Instance = this;
        Log.Message("Hello world!");
    }
}