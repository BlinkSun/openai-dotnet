// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    [PersistableModelProxy(typeof(InternalUnknownChatOutputPrediction))]
    public partial class ChatOutputPrediction : IJsonModel<ChatOutputPrediction>
    {
        internal ChatOutputPrediction()
        {
        }

        void IJsonModel<ChatOutputPrediction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatOutputPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatOutputPrediction)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
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

        ChatOutputPrediction IJsonModel<ChatOutputPrediction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ChatOutputPrediction JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatOutputPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatOutputPrediction)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatOutputPrediction(document.RootElement, options);
        }

        internal static ChatOutputPrediction DeserializeChatOutputPrediction(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "content":
                        return InternalChatOutputPredictionContent.DeserializeInternalChatOutputPredictionContent(element, options);
                }
            }
            return InternalUnknownChatOutputPrediction.DeserializeInternalUnknownChatOutputPrediction(element, options);
        }

        BinaryData IPersistableModel<ChatOutputPrediction>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatOutputPrediction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatOutputPrediction)} does not support writing '{options.Format}' format.");
            }
        }

        ChatOutputPrediction IPersistableModel<ChatOutputPrediction>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ChatOutputPrediction PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatOutputPrediction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatOutputPrediction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatOutputPrediction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatOutputPrediction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ChatOutputPrediction chatOutputPrediction)
        {
            if (chatOutputPrediction == null)
            {
                return null;
            }
            return BinaryContent.Create(chatOutputPrediction, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ChatOutputPrediction(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeChatOutputPrediction(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
