using KTCHack.Core.BeggarCamping;
using KTCHack.Core.Enemy;
using KTCHack.Core.GUI;
using KTCHack.Core.Kingdomm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core
{
    public class KTCInput : MonoBehaviour
    {
        public static KTCInput Instance;



        private void Start()
        {
            Instance = this;
        }



        private void Update()
        {
            // Adding + 30 Coins
            if (Input.GetKeyDown(KeyCode.Z))
            {
                KTCWallet.AddCoins();
            }

            // Adding + 3 gems
            if (Input.GetKeyDown(KeyCode.X))
            {
                KTCWallet.AddGems();
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                KTCCastle.UpgradeCastle(false);
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                KTCCastle.UpgradeTowers();
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                KTCBeggarCamping.SpawnBeggar();
            }

            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                KTCGUIMenu.Native();
            }

            // UnInject cheat from KTC (game)
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Injection.UnInject();
            }
        }
    }
}
