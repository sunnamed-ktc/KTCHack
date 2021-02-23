using KTCHack.Core.GUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core
{
    public class KTCPlayer : MonoBehaviour
    {
        public static Player Player;

        public static KTCPlayer Instance;



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Player == null)
            {
                Player = FindObjectOfType<Player>();
            }
        }



        public static void SetInfinityStamina()
        {
            Player.DebugInfiniteStamina = true;
        }

        public static void ChangeSpeedMultiplier(float value = 15f)
        {
            float lastSpeed = (float)Player?.GetType().GetField("_multiplier", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(Player);

            Player?.GetType().GetField("_multiplier", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(Player, (lastSpeed + value));
        }
    }
}
