using HarmonyLib;

namespace RobOne.Inventory.Mods;

internal class Inventory : ModBase
{
    [HarmonyPostfix, HarmonyPatch(typeof(MapDisplay), nameof(MapDisplay.FetchMap))]
    private static void Banana_Test_fun(MapDisplay __instance)
    {
        Log.Debug("SHOWING MAP");
    }
}
