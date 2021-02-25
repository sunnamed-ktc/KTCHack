using KTCHack.Core.Attributes;
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
    [RequiredComponent]
    public class KTCCastle : MonoBehaviour
    {
        public static Castle Castle;

        public static KTCCastle Instance;



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Castle == null)
            {
                Castle = FindObjectOfType<Castle>();
            }
        }



        // Bad working!
        public static void UpgradeCastle(bool includePrevious)
        {
            Castle?.GetType().GetMethod("CatchupToLevel", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Castle, new object[]
            {
                includePrevious,
            });
        }

        // Hah, level is not using in code, but why not? =)
        public static void UpgradeTowers(float range = 12f)
        {
            Castle?.GetType().GetMethod("UpgradeTowers", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Castle, new object[]
            {
                range,
                0
            });
        }

        public static bool UpgradeWallsOrWrecks(int level, float range = 12f)
        {
            return (bool)Castle?.GetType().GetMethod("UpgradeWallsOrWrecks", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(Castle, new object[]
            {
                range,
                level
            });
        }
    }
}
