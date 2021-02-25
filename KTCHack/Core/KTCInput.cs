using KTCHack.Core.Attributes;
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
    [RequiredComponent]
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

            // update castle
            if (Input.GetKeyDown(KeyCode.C))
            {
                KTCCastle.UpgradeCastle(false);
            }

            // update towers
            if (Input.GetKeyDown(KeyCode.V))
            {
                KTCCastle.UpgradeTowers();
            }

            // Spawn beggars
            if (Input.GetKeyDown(KeyCode.B))
            {
                KTCBeggarCamping.SpawnBeggarsOnCamping();
            }

            // open/close menu
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
