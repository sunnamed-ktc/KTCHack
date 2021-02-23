using KTCHack.Core.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.BeggarCamping
{
    public class KTCBeggarCamping : MonoBehaviour
    {
        public static KTCBeggarCamping Instance;

        public static BeggarCamp Camping;

        public static GUIDebugger Debugger;



        private void Start()
        {
            Instance = this;

            Debugger = new GUIDebugger("Beggar count:");
        }

        private void Update()
        {
            if (Camping == null)
            {
                Camping = FindObjectOfType<BeggarCamp>();
            }

            Debugger.ChangeDebuggerContent($"{Debugger.FirstContent} {FindObjectsOfType<Beggar>().Length}");
        }



        public static void SpawnBeggar(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Camping?.GetType().GetMethod("SpawnBeggar", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Camping, null);
            }
        }

        public static void SpawnBeggar()
        {
            Camping?.GetType().GetMethod("SpawnBeggar", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Camping, null);
        }
    }
}
