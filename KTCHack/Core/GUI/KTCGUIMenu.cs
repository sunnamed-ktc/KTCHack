using KTCHack.Core.Age;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.GUI
{
    public class KTCGUIMenu : MonoBehaviour
    {
        public static KTCGUIMenu Instance;

        public static bool IsMenuOppened { get; private set; }

        public static string OpenMenuText { get; private set; } = "Menu";



        private void Start()
        {
            Instance = this;
        }

        

        public static void Check()
        {
            if (UnityEngine.GUI.Button(new Rect(20, 20, 160, 20), OpenMenuText))
            {
                IsMenuOppened = !IsMenuOppened;
            }
        }

        public static void Show()
        {
            if (IsMenuOppened)
            {
                UnityEngine.GUI.Box(new Rect(20, 40, 160, 400), "<color=white>This is KTCHack Menu!</color>");

                if (UnityEngine.GUI.Button(new Rect(20, 70, 160, 20), "+30 Coins (Z)"))
                {
                    KTCWallet.AddCoins();
                }

                if (UnityEngine.GUI.Button(new Rect(20, 100, 160, 20), "+3 Gems (X)"))
                {
                    KTCWallet.AddGems();
                }

                if (UnityEngine.GUI.Button(new Rect(20, 130, 160, 20), "Walls | Wrecks (1 Level)"))
                {
                    KTCCastle.UpgradeWallsOrWrecks(1);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 160, 160, 20), "Walls | Wrecks (2 Level)"))
                {
                    KTCCastle.UpgradeWallsOrWrecks(2);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 190, 160, 20), "Walls | Wrecks (3 Level)"))
                {
                    KTCCastle.UpgradeWallsOrWrecks(3);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 220, 160, 20), "Walls | Wrecks (4 Level)"))
                {
                    KTCCastle.UpgradeWallsOrWrecks(4);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 250, 160, 20), "Walls | Wrecks (5 Level)"))
                {
                    KTCCastle.UpgradeWallsOrWrecks(5);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 280, 160, 20), "Towers (Level ?)"))
                {
                    KTCCastle.UpgradeTowers();
                }

                if (UnityEngine.GUI.Button(new Rect(20, 310, 160, 20), "Infinity Stamina"))
                {
                    KTCPlayer.SetInfinityStamina();
                }

                if (UnityEngine.GUI.Button(new Rect(20, 340, 160, 20), "Speed"))
                {
                    KTCPlayer.ChangeSpeedMultiplier(3);
                }

                if (UnityEngine.GUI.Button(new Rect(20, 370, 160, 20), "Uninject hack (Tab)"))
                {
                    Injection.UnInject();
                }
            }
        }

        public static void Native()
        {
            if (!IsMenuOppened)
            {
                Open();

                return;
            }

            if (IsMenuOppened)
            {
                Close();
            }
        }

        public static void Open()
        {
            if (!IsMenuOppened)
            {
                IsMenuOppened = true;
            }
        }

        public static void Close()
        {
            if (IsMenuOppened)
            {
                IsMenuOppened = false;
            }
        }
    }
}
