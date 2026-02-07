using System;

namespace SS3D.Systems.Health.Data
{
    /// <summary>
    /// Holds damage type and base values of a body layer 
    /// </summary>
    [Serializable]
    public struct BodyLayerInfo
    {
        public DamageType DamageType;
        public float Suceptibility;
        public float Resistance;
        
        public BodyLayerInfo(DamageType damageType, float suceptibility = 1, float resistance = 0)
        {
            DamageType = damageType;
            Suceptibility = suceptibility;
            Resistance = resistance;
        }
    }
}