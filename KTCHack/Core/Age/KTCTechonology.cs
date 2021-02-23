using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.Age
{
    public class KTCTechonology : MonoBehaviour
    {
        public static KTCTechonology Instance;

        public static PopupSegment Segment;



        public static TechnologyAge CurrentAge { get; private set; }



        private void Start()
        {
            Instance = this;
        }

        private void Update()
        {
            if (Segment == null)
            {
                Segment = FindObjectOfType<PopupSegment>();

                if (Segment != null)
                {
                    CurrentAge = Segment.currentTechAge;
                }
            }
        }



        // Not working, game is checking if u unlocked techonology
        public static void Set(TechnologyAge age)
        {
            Segment?.SetAge(age);
        }
    }
}
