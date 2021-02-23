using KTCHack.Core.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.Kingdomm
{
    public class KTCKingdom : MonoBehaviour
    {
        public static KTCKingdom Instance;

        public static Kingdom Kingdom;



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Kingdom == null)
            {
                Kingdom = FindObjectOfType<Kingdom>();
            }
        }
    }
}
