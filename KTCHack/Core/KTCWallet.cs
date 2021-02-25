using KTCHack.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core
{
    [RequiredComponent]
    public class KTCWallet : MonoBehaviour
    {
        public static Wallet Wallet;

        public static KTCWallet Instance;



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Wallet == null)
            {
                Wallet = KTCPlayer.Player?._wallet;
            }
        }



        public static void AddCoins(int count = 30)
        {
            Wallet.coins += count;
        }

        public static void AddGems(int count = 3)
        {
            Wallet.gems += count;
        }
    }
}
