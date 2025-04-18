// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageContentTextAnnotationsFilePathObjectFilePath
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalMessageContentTextAnnotationsFilePathObjectFilePath(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        internal InternalMessageContentTextAnnotationsFilePathObjectFilePath(string fileId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileId = fileId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
