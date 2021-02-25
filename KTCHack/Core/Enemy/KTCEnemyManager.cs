using KTCHack.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.Enemy
{
    [RequiredComponent]
    public class KTCEnemyManager : MonoBehaviour
    {
        public static EnemyManager Manager;


     
        private void Update()
        {
            if (Manager == null)
            {
                Manager = FindObjectOfType<EnemyManager>();
            }
        }



        public static void StartRedMoon()
        {
            Manager?.StartRedMoon();
        }

        public static void TryClearRedMoon()
        {
            Manager?.GetType().GetMethod("ClearRedMoon", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Manager, null);
        }
    }
}
