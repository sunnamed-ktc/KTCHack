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



        public void ShowContent()
        {
            UnityEngine.GUI.Label(new Rect(20, TextPositionY, 400, 400), Content);
        }

        public void ChangeContent(string text)
        {
            Content = text;
        }

        public bool TryJoinContentAndChange(string text, bool useSplit = true)
        {
            if (string.IsNullOrEmpty(FirstContent))
            {
                ChangeContent(text);

                return false;
            }

            if (useSplit)
            {
                Content = (FirstContent + " " + text);
            }
            else
            {
                Content = (FirstContent + text);
            }

            return true;
        }
    }
}
