using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.GUI
{
    public class GUIDebugger : MonoBehaviour
    {
        public string FirstContent { get; }

        public string Content { get; set; }

        public float TextPositionY { get; }



        public GUIDebugger(string content)
        {
            FirstContent = content;
            Content = content;

            GUIHelper.UpdateLastTextPosition();

            TextPositionY = GUIHelper.LastTextPositionY;
        }



        public void ShowDebuggerContent()
        {
            UnityEngine.GUI.Label(new Rect(20, TextPositionY, 160, 20), Content);
        }

        public void ChangeDebuggerContent(string text)
        {
            Content = text;
        }
    }
}
