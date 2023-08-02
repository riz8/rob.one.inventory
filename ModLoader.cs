using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using RobOne.Inventory.Mods;

namespace RobOne.Inventory;
internal class ModLoader
{
    private readonly List<ModBase> mods = new List<ModBase>();

    public void LoadMods()
    {
        foreach (Type type in
           Assembly.GetAssembly(typeof(ModBase)).GetTypes()
           .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Mods.ModBase))))
        {
            mods.Add((ModBase)Activator.CreateInstance(type));
        }
        foreach (var mod in mods)
        {
            Log.Message("Rob.One.Inventory.SubModule " + mod.ModName + " loaded");
        }
    }
    public void UnloadMods()
    {
        foreach (var mod in mods)
        {
            mod.Dispose();
        }
        mods.Clear();
    }
}
