// <auto-generated>
//     Generated by the F# GRPC code generator. DO NOT EDIT!
//     source: google/protobuf/source_context.proto
// </auto-generated>
namespace rec Google.Protobuf.FSharp.WellKnownTypes
#nowarn "40"
module SourceContextReflection =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal SourceContext_Descriptor() = Descriptor().MessageTypes.[0]
    let private descriptorBackingField: global.System.Lazy<global.Google.Protobuf.Reflection.FileDescriptor> =
        let descriptorData = global.System.Convert.FromBase64String("\
            CiRnb29nbGUvcHJvdG9idWYvc291cmNlX2NvbnRleHQucHJvdG8SD2dvb2dsZS5wcm90b2J1ZiIsCg1T\
            b3VyY2VDb250ZXh0EhsKCWZpbGVfbmFtZRgBIAEoCVIIZmlsZU5hbWVCigEKE2NvbS5nb29nbGUucHJv\
            dG9idWZCElNvdXJjZUNvbnRleHRQcm90b1ABWjZnb29nbGUuZ29sYW5nLm9yZy9wcm90b2J1Zi90eXBl\
            cy9rbm93bi9zb3VyY2Vjb250ZXh0cGKiAgNHUEKqAh5Hb29nbGUuUHJvdG9idWYuV2VsbEtub3duVHlw\
            ZXNiBnByb3RvMw==")
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
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.SourceContext>, global.Google.Protobuf.FSharp.WellKnownTypes.SourceContext.Parser, [| "FileName" |], null, null, null, null)
                        |]
                    )
                )
            ),
            true
        )
    let Descriptor(): global.Google.Protobuf.Reflection.FileDescriptor = descriptorBackingField.Value
type SourceContext = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable FileName: string
} with
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : SourceContext = {
        SourceContext._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        SourceContext.FileName = me.FileName
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.FileName <> SourceContext.DefaultValue.FileName
        then
            output.WriteRawTag(10uy)
            output.WriteString(me.FileName)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.FileName <> SourceContext.DefaultValue.FileName then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeStringSize(me.FileName)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: SourceContext) =
        if other.FileName <> SourceContext.DefaultValue.FileName
        then me.FileName <- other.FileName
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 10u ->
                me.FileName <- input.ReadString()
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<SourceContext> with
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
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.SourceContextReflection.SourceContext_Descriptor()
module SourceContext =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        SourceContext._UnknownFields = null
        SourceContext.FileName = ""
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        SourceContext._UnknownFields = null
        SourceContext.FileName = ""
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<SourceContext>(global.System.Func<_>(empty))
    let FileNameFieldNumber = 1
// End of auto-generated code
