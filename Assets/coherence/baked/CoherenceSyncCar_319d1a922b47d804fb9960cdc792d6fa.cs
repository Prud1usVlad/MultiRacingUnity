// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using Coherence.Toolkit;
    using Coherence.Toolkit.Bindings;
    using Coherence.Entities;
    using Coherence.ProtocolDef;
    using Coherence.Brook;
    using Coherence.Toolkit.Bindings.ValueBindings;
    using Coherence.Toolkit.Bindings.TransformBindings;
    using Coherence.Connection;
    using Coherence.Log;
    using Logger = Coherence.Log.Logger;
    using UnityEngine.Scripting;
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_1628e74f_cb5f_4289_b01d_230946f60f56 : PositionBinding
    {   
        private global::UnityEngine.Transform CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::UnityEngine.Transform)UnityComponent;
        }

        public override string CoherenceComponentName => "WorldPosition";
        public override uint FieldMask => 0b00000000000000000000000000000001;

        public override UnityEngine.Vector3 Value
        {
            get { return (UnityEngine.Vector3)(coherenceSync.coherencePosition); }
            set { coherenceSync.coherencePosition = (UnityEngine.Vector3)(value); }
        }

        protected override UnityEngine.Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((WorldPosition)coherenceComponent).value;
            if (!coherenceSync.HasParentWithCoherenceSync) { value += floatingOriginDelta; }
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (WorldPosition)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.value = Value;
            }
            else
            {
                update.value = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new WorldPosition();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_ecee7d0a_55f2_415f_b962_d538d4716879 : RotationBinding
    {   
        private global::UnityEngine.Transform CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::UnityEngine.Transform)UnityComponent;
        }

        public override string CoherenceComponentName => "WorldOrientation";
        public override uint FieldMask => 0b00000000000000000000000000000001;

        public override UnityEngine.Quaternion Value
        {
            get { return (UnityEngine.Quaternion)(coherenceSync.coherenceRotation); }
            set { coherenceSync.coherenceRotation = (UnityEngine.Quaternion)(value); }
        }

        protected override UnityEngine.Quaternion ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((WorldOrientation)coherenceComponent).value;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (WorldOrientation)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.value = Value;
            }
            else
            {
                update.value = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new WorldOrientation();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_0c041ac1_b1bb_4a1d_9692_ab6e39829dca : ScaleBinding
    {   
        private global::UnityEngine.Transform CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::UnityEngine.Transform)UnityComponent;
        }

        public override string CoherenceComponentName => "GenericScale";
        public override uint FieldMask => 0b00000000000000000000000000000001;

        public override UnityEngine.Vector3 Value
        {
            get { return (UnityEngine.Vector3)(coherenceSync.coherenceLocalScale); }
            set { coherenceSync.coherenceLocalScale = (UnityEngine.Vector3)(value); }
        }

        protected override UnityEngine.Vector3 ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((GenericScale)coherenceComponent).value;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (GenericScale)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.value = Value;
            }
            else
            {
                update.value = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new GenericScale();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_6c674014_c9c8_460a_b7a6_3c9a25cddfbe : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000000001;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.maxSpeed); }
            set { CastedUnityComponent.maxSpeed = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).maxSpeed;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.maxSpeed = Value;
            }
            else
            {
                update.maxSpeed = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_623201ca_9596_4d47_8d9c_3f115f2dae38 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000000010;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.accelerationMul); }
            set { CastedUnityComponent.accelerationMul = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).accelerationMul;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.accelerationMul = Value;
            }
            else
            {
                update.accelerationMul = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_af712eb2_5969_45f8_8e29_8fb6a0a666b5 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000000100;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.turnMul); }
            set { CastedUnityComponent.turnMul = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).turnMul;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.turnMul = Value;
            }
            else
            {
                update.turnMul = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_69371d9e_7c97_40eb_952b_8256554d3578 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000001000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.driftMul); }
            set { CastedUnityComponent.driftMul = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).driftMul;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.driftMul = Value;
            }
            else
            {
                update.driftMul = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_4e22fff1_b8f4_4c00_b841_36dacc237016 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000010000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.inertionMul); }
            set { CastedUnityComponent.inertionMul = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).inertionMul;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.inertionMul = Value;
            }
            else
            {
                update.inertionMul = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_352a66f4_07dc_4af8_9a53_0d62df267903 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000000100000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.sideMovementForSkidmarks); }
            set { CastedUnityComponent.sideMovementForSkidmarks = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).sideMovementForSkidmarks;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.sideMovementForSkidmarks = Value;
            }
            else
            {
                update.sideMovementForSkidmarks = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_af226961_c021_4632_9ec2_77f27d07c1bb : BoolBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000001000000;

        public override System.Boolean Value
        {
            get { return (System.Boolean)(CastedUnityComponent.enabled); }
            set { CastedUnityComponent.enabled = (System.Boolean)(value); }
        }

        protected override System.Boolean ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).enabled;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.enabled = Value;
            }
            else
            {
                update.enabled = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_4ab9d861_8b2f_4723_9236_504f3697ba8e : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000010000000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.accelerationInput); }
            set { CastedUnityComponent.accelerationInput = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).accelerationInput;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.accelerationInput = Value;
            }
            else
            {
                update.accelerationInput = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_38d669aa_1d02_461a_8875_6123421218b8 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000000100000000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.steeringInput); }
            set { CastedUnityComponent.steeringInput = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).steeringInput;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.steeringInput = Value;
            }
            else
            {
                update.steeringInput = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_445716dc_1b36_446d_b5ff_332442f5e257 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000001000000000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.rotationAngle); }
            set { CastedUnityComponent.rotationAngle = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).rotationAngle;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.rotationAngle = Value;
            }
            else
            {
                update.rotationAngle = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_7828af33_4e68_4e04_912f_ef1821c967a0 : FloatBinding
    {   
        private global::CarController CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::CarController)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170";
        public override uint FieldMask => 0b00000000000000000000010000000000;

        public override System.Single Value
        {
            get { return (System.Single)(CastedUnityComponent.velocityVsUp); }
            set { CastedUnityComponent.velocityVsUp = (System.Single)(value); }
        }

        protected override System.Single ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent).velocityVsUp;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.velocityVsUp = Value;
            }
            else
            {
                update.velocityVsUp = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_CarController_3897654430183329170();
        }    
    }
    
    public class Binding_319d1a922b47d804fb9960cdc792d6fa_bc3162db_9e89_47d4_9293_620ae7977fec : Vector2Binding
    {   
        private global::UnityEngine.Rigidbody2D CastedUnityComponent;

        protected override void OnBindingCloned()
        {
    	    CastedUnityComponent = (global::UnityEngine.Rigidbody2D)UnityComponent;
        }

        public override string CoherenceComponentName => "Car_319d1a922b47d804fb9960cdc792d6fa_Rigidbody2D_3118235588787588515";
        public override uint FieldMask => 0b00000000000000000000000000000001;

        public override UnityEngine.Vector2 Value
        {
            get { return (UnityEngine.Vector2)(CastedUnityComponent.velocity); }
            set { CastedUnityComponent.velocity = (UnityEngine.Vector2)(value); }
        }

        protected override UnityEngine.Vector2 ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
        {
            var value = ((Car_319d1a922b47d804fb9960cdc792d6fa_Rigidbody2D_3118235588787588515)coherenceComponent).velocity;
            
            return value;
        }

        public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, double time)
        {
            var update = (Car_319d1a922b47d804fb9960cdc792d6fa_Rigidbody2D_3118235588787588515)coherenceComponent;
            if (RuntimeInterpolationSettings.IsInterpolationNone)
            {
                update.velocity = Value;
            }
            else
            {
                update.velocity = GetInterpolatedAt(time);
            }
            
            return update;
        }

        public override ICoherenceComponentData CreateComponentData()
        {
            return new Car_319d1a922b47d804fb9960cdc792d6fa_Rigidbody2D_3118235588787588515();
        }    
    }

    public class CoherenceSyncCar_319d1a922b47d804fb9960cdc792d6fa : CoherenceSyncBaked
    {
        private Entity entityId;
        private Logger logger = Coherence.Log.Log.GetLogger<CoherenceSyncCar_319d1a922b47d804fb9960cdc792d6fa>();
        
        
        
        private IClient client;
        private CoherenceBridge bridge;
        
        private readonly Dictionary<string, Binding> bakedValueBindings = new Dictionary<string, Binding>()
        {
            ["1628e74f-cb5f-4289-b01d-230946f60f56"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_1628e74f_cb5f_4289_b01d_230946f60f56(),
            ["ecee7d0a-55f2-415f-b962-d538d4716879"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_ecee7d0a_55f2_415f_b962_d538d4716879(),
            ["0c041ac1-b1bb-4a1d-9692-ab6e39829dca"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_0c041ac1_b1bb_4a1d_9692_ab6e39829dca(),
            ["6c674014-c9c8-460a-b7a6-3c9a25cddfbe"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_6c674014_c9c8_460a_b7a6_3c9a25cddfbe(),
            ["623201ca-9596-4d47-8d9c-3f115f2dae38"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_623201ca_9596_4d47_8d9c_3f115f2dae38(),
            ["af712eb2-5969-45f8-8e29-8fb6a0a666b5"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_af712eb2_5969_45f8_8e29_8fb6a0a666b5(),
            ["69371d9e-7c97-40eb-952b-8256554d3578"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_69371d9e_7c97_40eb_952b_8256554d3578(),
            ["4e22fff1-b8f4-4c00-b841-36dacc237016"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_4e22fff1_b8f4_4c00_b841_36dacc237016(),
            ["352a66f4-07dc-4af8-9a53-0d62df267903"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_352a66f4_07dc_4af8_9a53_0d62df267903(),
            ["af226961-c021-4632-9ec2-77f27d07c1bb"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_af226961_c021_4632_9ec2_77f27d07c1bb(),
            ["4ab9d861-8b2f-4723-9236-504f3697ba8e"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_4ab9d861_8b2f_4723_9236_504f3697ba8e(),
            ["38d669aa-1d02-461a-8875-6123421218b8"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_38d669aa_1d02_461a_8875_6123421218b8(),
            ["445716dc-1b36-446d-b5ff-332442f5e257"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_445716dc_1b36_446d_b5ff_332442f5e257(),
            ["7828af33-4e68-4e04-912f-ef1821c967a0"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_7828af33_4e68_4e04_912f_ef1821c967a0(),
            ["bc3162db-9e89-47d4-9293-620ae7977fec"] = new Binding_319d1a922b47d804fb9960cdc792d6fa_bc3162db_9e89_47d4_9293_620ae7977fec(),
        };
        
        private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings = new Dictionary<string, Action<CommandBinding, CommandsHandler>>();
        
        public CoherenceSyncCar_319d1a922b47d804fb9960cdc792d6fa()
        {
        }
        
        public override Binding BakeValueBinding(Binding valueBinding)
        {
            if (bakedValueBindings.TryGetValue(valueBinding.guid, out var bakedBinding))
            {
                valueBinding.CloneTo(bakedBinding);
                return bakedBinding;
            }
            
            return null;
        }
        
        public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
        {
            if (bakedCommandBindings.TryGetValue(commandBinding.guid, out var commandBindingBaker))
            {
                commandBindingBaker.Invoke(commandBinding, commandsHandler);
            }
        }
        
        public override void ReceiveCommand(IEntityCommand command)
        {
            switch (command)
            {
                default:
                    logger.Warning($"CoherenceSyncCar_319d1a922b47d804fb9960cdc792d6fa Unhandled command: {command.GetType()}.");
                    break;
            }
        }
        
        public override List<ICoherenceComponentData> CreateEntity(bool usesLodsAtRuntime, string archetypeName)
        {
            if (!usesLodsAtRuntime)
            {
                return null;
            }
            
            if (Archetypes.IndexForName.TryGetValue(archetypeName, out int archetypeIndex))
            {
                var components = new List<ICoherenceComponentData>()
                {
                    new ArchetypeComponent
                    {
                        index = archetypeIndex
                    }
                };

                return components;
            }
    
            logger.Warning($"Unable to find archetype {archetypeName} in dictionary. Please, bake manually (coherence > Bake)");
            
            return null;
        }
        
        public override void Dispose()
        {
        }
        
        public override void Initialize(Entity entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
        {
            this.logger = logger.With<CoherenceSyncCar_319d1a922b47d804fb9960cdc792d6fa>();
            this.bridge = bridge;
            this.entityId = entityId;
            this.client = client;        
        }
    }

}