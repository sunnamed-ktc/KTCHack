using KTCHack.Core;
using KTCHack.Core.Age;
using KTCHack.Core.Attributes;
using KTCHack.Core.BeggarCamping;
using KTCHack.Core.Enemy;
using KTCHack.Core.GUI;
using KTCHack.Core.Helper;
using KTCHack.Core.Kingdomm;
using System;
using System.Reflection;
using UnityEngine;

namespace KTCHack
{
    public class KTCHack : MonoBehaviour
    {
        public static GameObject Instance;



        private void OnGUI()
        {
            KTCGUIMenu.Check();

            KTCGUIMenu.Show();

            KTCBeggarCamping.Debugger.ShowContent();
        }



        public static void Initialize()
        {
            Instance = new GameObject("KTCHack", typeof(KTCHack));

            GameObject.DontDestroyOnLoad(Instance);

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsDefined(typeof(RequiredComponent), false))
                {
                    Instance.AddComponent(type);
                }
            }
        }
    }
}
