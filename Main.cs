namespace RobOne.Inventory;

[BepInEx.BepInPlugin(GUID, NAME, VERSION)]
public class Main : BepInEx.BaseUnityPlugin
{
    #region Meta
    public const string GUID = "rob.one.inventory";
    public const string NAME = "Inventory";
    public const string VERSION = "0.1";
    #endregion

    public static Main Plugin;

    public Main()
    {
        
    }
    internal void Awake()
    {

        Log.Initialize(Logger);

        Log.Message("Rob.One.Inventory Started");

        Plugin = this;
    }

    internal void OnDestroy()
    {
    }

    internal void Update()
    {
    }
}
