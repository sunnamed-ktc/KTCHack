using KTCHack.Core;
using KTCHack.Core.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack
{
    public class Injection
    {
        public static void Inject()
        {
            KTCHack.Initialize();
        }

        public static void UnInject()
        {
            if (KTCHack.Instance != null)
            {
                GameObject.Destroy(KTCHack.Instance.gameObject);
            }
        }
    }
}
