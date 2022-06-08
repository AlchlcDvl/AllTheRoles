
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Reactor;
using Reactor.Patches;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using Hazel;
using Epic;
using Epic.OnlineServices.Stats;
using Essentials;
using Essentials.Options;

namespace AllTheRoles
{
    [HarmonyPatch]
    
    [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]

    public static class VersionShowerPatch
    {
        public static void Postfix(VersionShower __instance)
        {
            __instance.text.text += " + <color=#FFFF00>All The Roles</color> by Ember and AD";
        }

    }

}
