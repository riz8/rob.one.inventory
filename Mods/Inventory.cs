using HarmonyLib;

namespace RobOne.Inventory.Mods;

internal class Inventory : ModBase
{
    // Block this as it will reset any filter previously set in the inventory
    [HarmonyPrefix, HarmonyPatch(typeof(InventorySectionDisplay), nameof(InventorySectionDisplay.ResetDefaultSelection))]
    private static bool InventorySectionDisplay_ResetDefaultSelection_Prefix(InventorySectionDisplay __instance)
        => false;

    private static int selectedFilter = 15;
    private static bool openedInventory = false;
    [HarmonyPrefix, HarmonyPatch(typeof(InventoryMenu), nameof(InventoryMenu.OnSectionSelected), new[] { typeof(int) })]
    private static void InventoryMenu_OnSectionSelected_Prefix(InventoryMenu __instance, ref int _sectionID)
    {
        if (openedInventory)
        {
            _sectionID = selectedFilter;
        }
        else
        {
            selectedFilter = _sectionID;
        }

        openedInventory = false;
    }

    [HarmonyPrefix, HarmonyPatch(typeof(InventoryMenu), nameof(InventoryMenu.Show))]
    private static void InventoryMenu_Show(InventoryMenu __instance)
    {
        openedInventory = true;
    }
}
