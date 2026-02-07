using DG.Tweening.Core.Easing;
using Serilog;
using SS3D.Systems.Health.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Log = SS3D.Logging.Log;

namespace SS3D.Systems.Health
{
	public class BoneLayer : BodyLayer
	{
		public override BodyLayerType LayerType
		{
			get { return BodyLayerType.Bone; }
		}
        
        public BoneLayer(BodyPart bodyPart) : base(bodyPart)
        {
        }

		public BoneLayer(BodyPart bodyPart, BodyLayerData data) : base(bodyPart, data)
        {
            BodyLayerData = data;
        }

		public BoneLayer(BodyPart bodyPart, DamagesContainer damages)
		: base(bodyPart, damages)
        {
        }

        // ReSharper disable Unity.PerformanceAnalysis
        protected override void SetDamagesContainer()
        {
            if (!BodyLayerData)
            {
                Damages.DamagesInfo.Add(DamageType.Crush, new BodyDamageInfo(DamageType.Crush, 0f, 2f, 0f));
                Damages.DamagesInfo.Add(DamageType.Slash, new BodyDamageInfo(DamageType.Slash, 0f, 1f, 0f));
                Damages.DamagesInfo.Add(DamageType.Puncture, new BodyDamageInfo(DamageType.Puncture, 0f, 1.5f, 0f));
                Damages.DamagesInfo.Add(DamageType.Pressure, new BodyDamageInfo(DamageType.Pressure, 0f, 0.2f, 0f));
                Damages.DamagesInfo.Add(DamageType.Heat, new BodyDamageInfo(DamageType.Heat, 0f, 1f, 0f));
                Damages.DamagesInfo.Add(DamageType.Cold, new BodyDamageInfo(DamageType.Cold, 0f, 0.5f, 0f));
                Damages.DamagesInfo.Add(DamageType.Shock, new BodyDamageInfo(DamageType.Shock, 0f, 0.5f, 0f));
                Damages.DamagesInfo.Add(DamageType.Rad, new BodyDamageInfo(DamageType.Rad, 0f, 1f, 0f));
                Damages.DamagesInfo.Add(DamageType.Acid, new BodyDamageInfo(DamageType.Acid, 0f, 1f, 0f));
                Damages.DamagesInfo.Add(DamageType.Toxic, new BodyDamageInfo(DamageType.Toxic, 0f, 0.8f, 0f));
                Damages.DamagesInfo.Add(DamageType.Oxy, new BodyDamageInfo(DamageType.Oxy, 0f, 0f, 0f));
                
                return;
            }
            
            foreach (BodyLayerInfo data in BodyLayerData.BodyLayerInfos) 
            {
                Damages.DamagesInfo.Add(data.DamageType, new BodyDamageInfo(data.DamageType, 0f, data.Suceptibility, data.Resistance));
            }
        }

		/// <summary>
		/// Generate a certain amount of blood and put it in the circulatory system if there's one.
		/// </summary>
		public virtual void ProduceBlood()
		{
			throw new NotImplementedException();
		}

        public override void Cleanlayer()
        {
            
        }
    }
}
