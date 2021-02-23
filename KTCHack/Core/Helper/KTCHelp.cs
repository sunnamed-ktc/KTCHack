using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.Helper
{



    #region Not using more, now its * KTCGUIMenu *
    public class KTCHelp : MonoBehaviour
    {
        public static KTCHelp Instance;

        public static readonly string[] Text =
        {
            "Buttons: ",

            "(Z) - + 30 Coin",
            "(X) - + 3 Gem`s",
            "(Tab) - UnInject",
        };



        private void Start()
        {
            Instance = this;
        }



        public static void Submit()
        {
            float yPosition = 10;
            for (int i = 0; i < Text.Length; i++)
            {
                yPosition += 30;
                UnityEngine.GUI.Label(new Rect(10, yPosition, 200, 40), Text[i]);
            }

            #region Old realization
            /*GUI.Label(new Rect(10, 10, 200, 40), Text[0]);
            GUI.Label(new Rect(10, 30, 200, 40), Text[1]);
            GUI.Label(new Rect(10, 60, 200, 40), Text[2]);
            GUI.Label(new Rect(10, 90, 200, 40), Text[3]);*/
            #endregion
        }
    }
    #endregion



}
