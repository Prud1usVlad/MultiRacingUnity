// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
    using System.Collections.Generic;
    using Coherence.ProtocolDef;
    using Coherence.Serializer;
    using Coherence.SimulationFrame;
    using Coherence.Entities;
    using Coherence.Utils;
    using Coherence.Brook;
    using Logger = Coherence.Log.Logger;
    using UnityEngine;
    using Coherence.Toolkit;
    
    public struct GenericFieldEntity0 : ICoherenceComponentData
    {
        public static uint valueMask => 0b00000000000000000000000000000001;
        public Entity value;
        
        public uint FieldsMask { get; set; }
        public uint StoppedMask { get; set; }
        public uint GetComponentType() => 82;
        public int PriorityLevel() => 100;
        public const int order = 0;
        public uint InitialFieldsMask() => 0b00000000000000000000000000000001;
        public bool HasFields() => true;
        public bool HasRefFields() => true;
        
        public HashSet<Entity> GetEntityRefs()
        {
            return new HashSet<Entity>()
            {
                value,
            };
        }
        
        public IEntityMapper.Error MapToAbsolute(IEntityMapper mapper)
        {
            Entity absoluteEntity;
            IEntityMapper.Error err;
            err = mapper.MapToAbsoluteEntity(value, false, out absoluteEntity);
            
            if (err != IEntityMapper.Error.None)
            {
                return err;
            }
            
            value = absoluteEntity;
            return IEntityMapper.Error.None;  
        }
        
        public IEntityMapper.Error MapToRelative(IEntityMapper mapper)
        {
            Entity relativeEntity;
            IEntityMapper.Error err;
            // We assume that the inConnection held changes with unresolved references, so the 'createMapping=true' is
            // there only because there's a chance that the parent creation change will be processed after this one
            // meaning there's no mapping for the parent yet. This wouldn't be necessary if mapping creation would happen
            // in the clientWorld via create/destroy requests while here we would only check whether mapping exists or not.		
            var createParentMapping_value = true;
            err = mapper.MapToRelativeEntity(value, createParentMapping_value,
             out relativeEntity);
            
            if (err != IEntityMapper.Error.None)
            {
                return err;
            }
          
            value = relativeEntity;
            return IEntityMapper.Error.None;   
        }
        
        public ICoherenceComponentData Clone() => this;
        public int GetComponentOrder() => order;
        public bool IsSendOrdered() => false;
        public AbsoluteSimulationFrame Frame;
        
    
        public void SetSimulationFrame(AbsoluteSimulationFrame frame)
        {
            Frame = frame;
        }
        
        public AbsoluteSimulationFrame GetSimulationFrame() => Frame;
        
        public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
        {
            var other = (GenericFieldEntity0)data;

            FieldsMask |= mask;
            StoppedMask &= ~(mask);

            if ((mask & 0x01) != 0)
            {
                Frame = other.Frame;
                value = other.value;
            }
            
            mask >>= 1;
            StoppedMask |= other.StoppedMask;

            return this;
        }
        
        public uint DiffWith(ICoherenceComponentData data)
        {
            throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");
        }
        
        public static uint Serialize(GenericFieldEntity0 data, uint mask, IOutProtocolBitStream bitStream, Logger logger)
        {
            if (bitStream.WriteMask(data.StoppedMask != 0))
            {
                bitStream.WriteMaskBits(data.StoppedMask, 1);
            }

            if (bitStream.WriteMask((mask & 0x01) != 0))
            {
            
                var fieldValue = data.value;
            

            
                bitStream.WriteEntity(fieldValue);
            }
            
            mask >>= 1;
          
            return mask;
        }
        
        public static (GenericFieldEntity0, uint) Deserialize(InProtocolBitStream bitStream)
        {
            var stoppedMask = (uint)0;
            if (bitStream.ReadMask())
            {
                stoppedMask = bitStream.ReadMaskBits(1);
            }

            var mask = (uint)0;
            var val = new GenericFieldEntity0();
            if (bitStream.ReadMask())
            {
                val.value = bitStream.ReadEntity();
                mask |= valueMask;
            }
                    
            val.FieldsMask = mask;
            val.StoppedMask = stoppedMask;

            return (val, mask);
        }
        
        
        public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
        {
            var last = lastSent as GenericFieldEntity0?;
            
        }

        public override string ToString()
        {
            return $"GenericFieldEntity0(value: { value }, Mask: {System.Convert.ToString(FieldsMask, 2).PadLeft(1, '0')}), Stopped: {System.Convert.ToString(StoppedMask, 2).PadLeft(1, '0')})";
        }
    }
    

}