namespace RobOne.Inventory.Mods;

internal abstract class ModBase : System.IDisposable
{
    #region Interface
    public string ModName { get; }
    public void Dispose()
    {
        _patcher.UnpatchSelf();
    }
    #endregion

    private readonly HarmonyLib.Harmony _patcher;
    protected ModBase()
    {
        ModName = GetType().Name;

        _patcher = new HarmonyLib.Harmony(GetType().Name);
        _patcher.PatchAll(GetType());

    }

}
