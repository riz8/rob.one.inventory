namespace RobOne.Inventory.Mods;

internal abstract class ModBase : System.IDisposable
{
    public void Dispose()
    {
        _patcher.UnpatchSelf();
    }

    private readonly HarmonyLib.Harmony _patcher;
    protected ModBase()
    {
        _patcher = new HarmonyLib.Harmony(GetType().Name);
        _patcher.PatchAll(GetType());
    }
}
