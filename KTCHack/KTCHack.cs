using KTCHack.Core;
using KTCHack.Core.Age;
using KTCHack.Core.BeggarCamping;
using KTCHack.Core.Enemy;
using KTCHack.Core.GUI;
using KTCHack.Core.Helper;
using KTCHack.Core.Kingdomm;
using UnityEngine;

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
            Instance.AddComponent<KTCKingdom>();
            Instance.AddComponent<KTCBeggarCamping>();
        }



        private void OnGUI()
        {
            #region Old Help Menu (only text)
            /*KTCHelp.Submit();*/
            #endregion

            KTCGUIMenu.Check();

            KTCGUIMenu.Show();

            KTCBeggarCamping.Debugger.ShowDebuggerContent();
        }
    }
}
