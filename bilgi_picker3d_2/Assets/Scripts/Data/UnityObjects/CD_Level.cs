using System.Collections.Generic;
using Data.ValuableObjects;
using UnityEngine;

namespace Data.UnityObjects
{
    [CreateAssetMenu(fileName = "Cd_level", menuName = "Picker3D/CD_Level", order = 1)]
    public class CD_Level : ScriptableObject
    {
        public List<LevelData> Levels = new List<LevelData>();
    }
}
