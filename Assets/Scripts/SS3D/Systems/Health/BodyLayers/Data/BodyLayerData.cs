using System.Collections.Generic;
using UnityEngine;

namespace SS3D.Systems.Health.Data
{
    [CreateAssetMenu(fileName = "BodyLayerData", menuName = "SS3D/Systems/Health/Data")]
    public class BodyLayerData : ScriptableObject
    {
       public List<BodyLayerInfo> BodyLayerInfos;
    }
}