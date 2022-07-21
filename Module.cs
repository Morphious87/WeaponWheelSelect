using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Reflection;
using UnityEngine;
using SGUI;
using BepInEx;

namespace RadialGunSelect
{
    [BepInDependency("etgmodding.etg.mtgapi")]
    [BepInPlugin(GUID, NAME, VERSION)]
    public class Module : BaseUnityPlugin
    {
        public const string GUID = "morphious86.etg.radialgunselect";
        public const string NAME = "Weapon Wheel Select";
        public const string VERSION = "1.1.0";

        public void Start()
        {
            ETGModMainBehaviour.WaitForGameManagerStart(GMStart);
        }

        public void GMStart(GameManager g)
        {
            try
            {
                HooksManager.Init();
                ConsoleCommandsManager.Init();
                RadialGunSelectController.Init();

                MorphUtils.LogRainbow($"{NAME} v{VERSION} started successfully.");
            }
            catch (Exception e)
            {
                MorphUtils.LogError($"{NAME} v{VERSION} failed to initialize!", e);
            }
        }
    }
}
