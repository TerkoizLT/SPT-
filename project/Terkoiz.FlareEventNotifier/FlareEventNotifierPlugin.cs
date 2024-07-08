﻿using BepInEx;
using JetBrains.Annotations;

namespace Terkoiz.FlareEventNotifier
{
    [BepInPlugin("com.terkoiz.flareeventnotifier", "Terkoiz.FlareEventNotifier", "1.0.2")]
    public class FlareEventNotifierPlugin : BaseUnityPlugin
    {
        [UsedImplicitly]
        internal void Start()
        {
            new FlareEventHookPatch().Enable();
        }
    }
}
