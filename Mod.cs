global using Mod = ExampleMod.Mod;

namespace ExampleMod;

public sealed class Mod : Verse.Mod
{
    public static Mod Instance { get; private set; }
    public Mod(ModContentPack content) : base(content)
    {
        Instance = this;
        SayHelloWorld();
    }
    private static void SayHelloWorld([CallerFilePath] string file = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0) => 
        Log.Message(
            ColoredText.Colorize(
                $"Hello, world!\n{file} {member}:{line}",
                Color.cyan
            )
        );
}