// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class MessageCreationOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal MessageCreationOptions(IList<MessageCreationAttachment> attachments, IDictionary<string, string> metadata, Assistants.MessageRole role, IList<MessageContent> content, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Attachments = attachments;
            Metadata = metadata;
            Role = role;
            Content = content;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<MessageCreationAttachment> Attachments { get; set; }

        public IDictionary<string, string> Metadata { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
