namespace RobOne.Inventory;

[BepInEx.BepInPlugin(GUID, NAME, VERSION)]
public class Main : BepInEx.BaseUnityPlugin
{
    #region Meta
    public const string GUID = "rob.one.inventory";
    public const string NAME = "Inventory";
    public const string VERSION = "0.1";
    #endregion

    private ModLoader _modLoader = new ModLoader();
    public Main()
    {
    }
    #region Runtime
    internal void Awake()
    {
        Log.Initialize(Logger);

        Log.Message("Rob.One.Inventory Started");

        _modLoader.LoadMods();
    }

    internal void OnDestroy()
    {
        _modLoader.UnloadMods();
    }

    internal void Update()
    {
    }
    #endregion
}
