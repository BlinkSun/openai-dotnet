// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionStreamResponseDelta : IJsonModel<InternalChatCompletionStreamResponseDelta>
    {
        void IJsonModel<InternalChatCompletionStreamResponseDelta>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionStreamResponseDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionStreamResponseDelta)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Audio) && _additionalBinaryDataProperties?.ContainsKey("audio") != true)
            {
                writer.WritePropertyName("audio"u8);
                writer.WriteObjectValue(Audio, options);
            }
            if (Optional.IsDefined(FunctionCall) && _additionalBinaryDataProperties?.ContainsKey("function_call") != true)
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue(FunctionCall, options);
            }
            if (true && Optional.IsCollectionDefined(ToolCalls) && _additionalBinaryDataProperties?.ContainsKey("tool_calls") != true)
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (StreamingChatToolCallUpdate item in ToolCalls)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Refusal) && _additionalBinaryDataProperties?.ContainsKey("refusal") != true)
            {
                if (Refusal != null)
                {
                    writer.WritePropertyName("refusal"u8);
                    writer.WriteStringValue(Refusal);
                }
                else
                {
                    writer.WriteNull("refusal"u8);
                }
            }
            if (Optional.IsDefined(Role) && _additionalBinaryDataProperties?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToSerialString());
            }
            // CUSTOM: Check inner collection is defined.
            if (Optional.IsDefined(Content) && _additionalBinaryDataProperties?.ContainsKey("content") != true && Content.IsInnerCollectionDefined())
            {
                if (Content != null)
                {
                    writer.WritePropertyName("content"u8);
                    this.SerializeContentValue(writer, options);
                }
                else
                {
                    writer.WriteNull("content"u8);
                }
            }
            if (true && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalChatCompletionStreamResponseDelta IJsonModel<InternalChatCompletionStreamResponseDelta>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalChatCompletionStreamResponseDelta JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionStreamResponseDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionStreamResponseDelta)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionStreamResponseDelta(document.RootElement, options);
        }

        internal static InternalChatCompletionStreamResponseDelta DeserializeInternalChatCompletionStreamResponseDelta(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingChatOutputAudioUpdate audio = default;
            StreamingChatFunctionCallUpdate functionCall = default;
            IReadOnlyList<StreamingChatToolCallUpdate> toolCalls = default;
            string refusal = default;
            Chat.ChatMessageRole? role = default;
            ChatMessageContent content = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("audio"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audio = StreamingChatOutputAudioUpdate.DeserializeStreamingChatOutputAudioUpdate(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("function_call"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = StreamingChatFunctionCallUpdate.DeserializeStreamingChatFunctionCallUpdate(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("tool_calls"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingChatToolCallUpdate> array = new List<StreamingChatToolCallUpdate>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(StreamingChatToolCallUpdate.DeserializeStreamingChatToolCallUpdate(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (prop.NameEquals("refusal"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        refusal = null;
                        continue;
                    }
                    refusal = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("role"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = prop.Value.GetString().ToChatMessageRole();
                    continue;
                }
                if (prop.NameEquals("content"u8))
                {
                    DeserializeContentValue(prop, ref content);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            // CUSTOM: Initialize Content collection property.
            return new InternalChatCompletionStreamResponseDelta(
                audio,
                functionCall,
                toolCalls ?? new ChangeTrackingList<StreamingChatToolCallUpdate>(),
                refusal,
                role,
                content ?? new ChatMessageContent(),
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalChatCompletionStreamResponseDelta>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionStreamResponseDelta>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionStreamResponseDelta)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionStreamResponseDelta IPersistableModel<InternalChatCompletionStreamResponseDelta>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalChatCompletionStreamResponseDelta PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionStreamResponseDelta>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatCompletionStreamResponseDelta(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionStreamResponseDelta)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionStreamResponseDelta>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalChatCompletionStreamResponseDelta internalChatCompletionStreamResponseDelta)
        {
            if (internalChatCompletionStreamResponseDelta == null)
            {
                return null;
            }
            return BinaryContent.Create(internalChatCompletionStreamResponseDelta, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalChatCompletionStreamResponseDelta(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalChatCompletionStreamResponseDelta(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
