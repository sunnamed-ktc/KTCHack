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
    public class KTCGame : MonoBehaviour
    {
        public static Game Game;

        public static KTCGame Instance;



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Game == null)
            {
                Game = FindObjectOfType<Game>();
            }
        }
    }
}
