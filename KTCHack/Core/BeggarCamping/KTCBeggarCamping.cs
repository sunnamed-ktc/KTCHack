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

            Debugger.TryJoinContentAndChange(FindObjectsOfType<Beggar>().Length.ToString());
        }



        public static void SpawnBeggarsOnCamping()
        {
            foreach (BeggarCamp beggar in FindObjectsOfType<BeggarCamp>())
            {
                TrySpecificallySpawnOne(beggar);
            }
        }

        public static void TrySpecificallySpawnOne(BeggarCamp camping)
        {
            camping?.GetType().GetMethod("SpawnBeggar", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(camping, null);
        }

        public static void TrySpawnOne()
        {
            Camping?.GetType().GetMethod("SpawnBeggar", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Camping, null);
        }
    }
}
