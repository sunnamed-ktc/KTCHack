using KTCHack.Core;
using KTCHack.Core.Age;
using KTCHack.Core.Enemy;
using KTCHack.Core.GUI;
using KTCHack.Core.Helper;
using Rewired;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Rewired.ReInput;

namespace KTCHack
{
    public class KTCHack : MonoBehaviour
    {
        public static GameObject Instance;



        // if u want to write, like debug, something add in (Y + 20)
        // Ex`s:
        // Example: GUI.Label(new Rect(10, 10, 200, 40), "This is debu # 1!");
        // Example: GUI.Label(new Rect(10, 30, 200, 40), "This is debug # 2!");

        public static void Initialize()
        {
            Instance = new GameObject("KTCHack", typeof(KTCHack));

            GameObject.DontDestroyOnLoad(Instance);

            Instance.AddComponent<KTCPlayer>();
            Instance.AddComponent<KTCCastle>();
            Instance.AddComponent<KTCHelp>();
            Instance.AddComponent<KTCWallet>();
            Instance.AddComponent<KTCGame>();
            Instance.AddComponent<KTCInput>();
            Instance.AddComponent<KTCEnemyManager>();
            Instance.AddComponent<KTCEnemySpawner>();
            Instance.AddComponent<KTCTechonology>();
        }



        private void OnGUI()
        {
            #region Old Help Menu (only text)
            /*KTCHelp.Submit();*/
            #endregion

            KTCGUIMenu.Check();

            KTCGUIMenu.Show();
        }
    }
}
