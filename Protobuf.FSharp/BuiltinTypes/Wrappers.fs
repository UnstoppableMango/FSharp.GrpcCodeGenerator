// <auto-generated>
//     Generated by the F# GRPC code generator. DO NOT EDIT!
//     source: google/protobuf/wrappers.proto
// </auto-generated>
namespace rec Google.Protobuf.FSharp.WellKnownTypes
#nowarn "40"
module WrappersReflection =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DoubleValue_Descriptor() = Descriptor().MessageTypes.[0]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal FloatValue_Descriptor() = Descriptor().MessageTypes.[1]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal Int64Value_Descriptor() = Descriptor().MessageTypes.[2]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal UInt64Value_Descriptor() = Descriptor().MessageTypes.[3]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal Int32Value_Descriptor() = Descriptor().MessageTypes.[4]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal UInt32Value_Descriptor() = Descriptor().MessageTypes.[5]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal BoolValue_Descriptor() = Descriptor().MessageTypes.[6]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal StringValue_Descriptor() = Descriptor().MessageTypes.[7]
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal BytesValue_Descriptor() = Descriptor().MessageTypes.[8]
    let private descriptorBackingField: global.System.Lazy<global.Google.Protobuf.Reflection.FileDescriptor> =
        let descriptorData = global.System.Convert.FromBase64String("\
            Ch5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8SD2dvb2dsZS5wcm90b2J1ZiIjCgtEb3VibGVW\
            YWx1ZRIUCgV2YWx1ZRgBIAEoAVIFdmFsdWUiIgoKRmxvYXRWYWx1ZRIUCgV2YWx1ZRgBIAEoAlIFdmFs\
            dWUiIgoKSW50NjRWYWx1ZRIUCgV2YWx1ZRgBIAEoA1IFdmFsdWUiIwoLVUludDY0VmFsdWUSFAoFdmFs\
            dWUYASABKARSBXZhbHVlIiIKCkludDMyVmFsdWUSFAoFdmFsdWUYASABKAVSBXZhbHVlIiMKC1VJbnQz\
            MlZhbHVlEhQKBXZhbHVlGAEgASgNUgV2YWx1ZSIhCglCb29sVmFsdWUSFAoFdmFsdWUYASABKAhSBXZh\
            bHVlIiMKC1N0cmluZ1ZhbHVlEhQKBXZhbHVlGAEgASgJUgV2YWx1ZSIiCgpCeXRlc1ZhbHVlEhQKBXZh\
            bHVlGAEgASgMUgV2YWx1ZUKDAQoTY29tLmdvb2dsZS5wcm90b2J1ZkINV3JhcHBlcnNQcm90b1ABWjFn\
            b29nbGUuZ29sYW5nLm9yZy9wcm90b2J1Zi90eXBlcy9rbm93bi93cmFwcGVyc3Bi+AEBogIDR1BCqgIe\
            R29vZ2xlLlByb3RvYnVmLldlbGxLbm93blR5cGVzYgZwcm90bzM=")
        global.System.Lazy<_>(
            (fun () ->
                global.Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(
                    descriptorData,
                    [|
                    |],
                    new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(
                        null,
                        null,
                        [|
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.DoubleValue>, global.Google.Protobuf.FSharp.WellKnownTypes.DoubleValue.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.FloatValue>, global.Google.Protobuf.FSharp.WellKnownTypes.FloatValue.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.Int64Value>, global.Google.Protobuf.FSharp.WellKnownTypes.Int64Value.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.UInt64Value>, global.Google.Protobuf.FSharp.WellKnownTypes.UInt64Value.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.Int32Value>, global.Google.Protobuf.FSharp.WellKnownTypes.Int32Value.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.UInt32Value>, global.Google.Protobuf.FSharp.WellKnownTypes.UInt32Value.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.BoolValue>, global.Google.Protobuf.FSharp.WellKnownTypes.BoolValue.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.StringValue>, global.Google.Protobuf.FSharp.WellKnownTypes.StringValue.Parser, [| "Value" |], null, null, null, null)
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.BytesValue>, global.Google.Protobuf.FSharp.WellKnownTypes.BytesValue.Parser, [| "Value" |], null, null, null, null)
                        |]
                    )
                )
            ),
            true
        )
    let Descriptor(): global.Google.Protobuf.Reflection.FileDescriptor = descriptorBackingField.Value
type DoubleValue = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: float
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : DoubleValue = {
        DoubleValue._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        DoubleValue.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> DoubleValue.DefaultValue.Value
        then
            output.WriteRawTag(9uy)
            output.WriteDouble(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> DoubleValue.DefaultValue.Value then size <- size + 9
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: DoubleValue) =
        if other.Value <> DoubleValue.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 9u ->
                me.Value <- input.ReadDouble()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<DoubleValue> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.DoubleValue_Descriptor()
module DoubleValue =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        DoubleValue._UnknownFields = null
        DoubleValue.Value = 0.0
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        DoubleValue._UnknownFields = null
        DoubleValue.Value = 0.0
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<DoubleValue>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type FloatValue = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: float32
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : FloatValue = {
        FloatValue._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        FloatValue.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> FloatValue.DefaultValue.Value
        then
            output.WriteRawTag(13uy)
            output.WriteFloat(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> FloatValue.DefaultValue.Value then size <- size + 5
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: FloatValue) =
        if other.Value <> FloatValue.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 13u ->
                me.Value <- input.ReadFloat()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<FloatValue> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.FloatValue_Descriptor()
module FloatValue =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        FloatValue._UnknownFields = null
        FloatValue.Value = 0f
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        FloatValue._UnknownFields = null
        FloatValue.Value = 0f
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<FloatValue>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type Int64Value = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: int64
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : Int64Value = {
        Int64Value._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        Int64Value.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> Int64Value.DefaultValue.Value
        then
            output.WriteRawTag(8uy)
            output.WriteInt64(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> Int64Value.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeInt64Size(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: Int64Value) =
        if other.Value <> Int64Value.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Value <- input.ReadInt64()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<Int64Value> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.Int64Value_Descriptor()
module Int64Value =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        Int64Value._UnknownFields = null
        Int64Value.Value = 0L
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        Int64Value._UnknownFields = null
        Int64Value.Value = 0L
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<Int64Value>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type UInt64Value = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: uint64
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : UInt64Value = {
        UInt64Value._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        UInt64Value.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> UInt64Value.DefaultValue.Value
        then
            output.WriteRawTag(8uy)
            output.WriteUInt64(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> UInt64Value.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeUInt64Size(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: UInt64Value) =
        if other.Value <> UInt64Value.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Value <- input.ReadUInt64()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<UInt64Value> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.UInt64Value_Descriptor()
module UInt64Value =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        UInt64Value._UnknownFields = null
        UInt64Value.Value = 0UL
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        UInt64Value._UnknownFields = null
        UInt64Value.Value = 0UL
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<UInt64Value>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type Int32Value = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: int32
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : Int32Value = {
        Int32Value._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        Int32Value.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> Int32Value.DefaultValue.Value
        then
            output.WriteRawTag(8uy)
            output.WriteInt32(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> Int32Value.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeInt32Size(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: Int32Value) =
        if other.Value <> Int32Value.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Value <- input.ReadInt32()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<Int32Value> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.Int32Value_Descriptor()
module Int32Value =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        Int32Value._UnknownFields = null
        Int32Value.Value = 0
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        Int32Value._UnknownFields = null
        Int32Value.Value = 0
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<Int32Value>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type UInt32Value = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: uint32
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : UInt32Value = {
        UInt32Value._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        UInt32Value.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> UInt32Value.DefaultValue.Value
        then
            output.WriteRawTag(8uy)
            output.WriteUInt32(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> UInt32Value.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeUInt32Size(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: UInt32Value) =
        if other.Value <> UInt32Value.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Value <- input.ReadUInt32()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<UInt32Value> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.UInt32Value_Descriptor()
module UInt32Value =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        UInt32Value._UnknownFields = null
        UInt32Value.Value = 0u
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        UInt32Value._UnknownFields = null
        UInt32Value.Value = 0u
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<UInt32Value>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type BoolValue = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: bool
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : BoolValue = {
        BoolValue._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        BoolValue.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> BoolValue.DefaultValue.Value
        then
            output.WriteRawTag(8uy)
            output.WriteBool(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> BoolValue.DefaultValue.Value then size <- size + 2
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: BoolValue) =
        if other.Value <> BoolValue.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Value <- input.ReadBool()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<BoolValue> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.BoolValue_Descriptor()
module BoolValue =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        BoolValue._UnknownFields = null
        BoolValue.Value = false
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        BoolValue._UnknownFields = null
        BoolValue.Value = false
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<BoolValue>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type StringValue = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: string
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : StringValue = {
        StringValue._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        StringValue.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> StringValue.DefaultValue.Value
        then
            output.WriteRawTag(10uy)
            output.WriteString(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> StringValue.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeStringSize(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: StringValue) =
        if other.Value <> StringValue.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 10u ->
                me.Value <- input.ReadString()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<StringValue> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.StringValue_Descriptor()
module StringValue =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        StringValue._UnknownFields = null
        StringValue.Value = ""
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        StringValue._UnknownFields = null
        StringValue.Value = ""
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<StringValue>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
type BytesValue = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Value: global.Google.Protobuf.ByteString
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : BytesValue = {
        BytesValue._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        BytesValue.Value = me.Value
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Value <> BytesValue.DefaultValue.Value
        then
            output.WriteRawTag(10uy)
            output.WriteBytes(me.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Value <> BytesValue.DefaultValue.Value then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeBytesSize(me.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: BytesValue) =
        if other.Value <> BytesValue.DefaultValue.Value
        then me.Value <- other.Value
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 10u ->
                me.Value <- input.ReadBytes()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<BytesValue> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.WrappersReflection.BytesValue_Descriptor()
module BytesValue =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        BytesValue._UnknownFields = null
        BytesValue.Value = global.Google.Protobuf.ByteString.Empty
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        BytesValue._UnknownFields = null
        BytesValue.Value = global.Google.Protobuf.ByteString.Empty
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<BytesValue>(global.System.Func<_>(empty))
    let ValueFieldNumber = 1
// End of auto-generated code
