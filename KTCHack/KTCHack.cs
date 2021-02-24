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



        private void OnGUI()
        {
            #region Old Help Menu (only text)
            /*KTCHelp.Submit();*/
            #endregion

            KTCGUIMenu.Check();

            KTCGUIMenu.Show();

            KTCBeggarCamping.Debugger.ShowContent();
        }



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
    }
}
