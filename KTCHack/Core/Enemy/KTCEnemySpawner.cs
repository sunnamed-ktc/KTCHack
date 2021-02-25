using KTCHack.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KTCHack.Core.Enemy
{
    [RequiredComponent]
    public class KTCEnemySpawner : MonoBehaviour
    {
        public static CaveCollapseSequence EnemySpawner;



        private void Update()
        {
            if (EnemySpawner == null)
            {
                EnemySpawner = FindObjectOfType<CaveCollapseSequence>();
            }
        }



        public static void SpawnEnemy(EnemyBlueprint spawnType, int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                EnemySpawner.SpawnEnemy(spawnType);
            }
        }
    }
}
