using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.GUI
{
    public class GUIHelper : MonoBehaviour
    {
        public static float LastTextPositionY { get; private set; } = 410;



        public static void UpdateLastTextPosition(float value = 30)
        {
            LastTextPositionY += value;
        }
    }
}
