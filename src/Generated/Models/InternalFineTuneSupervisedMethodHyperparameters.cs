// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuneSupervisedMethodHyperparameters
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalFineTuneSupervisedMethodHyperparameters()
        {
        }

        internal InternalFineTuneSupervisedMethodHyperparameters(BinaryData batchSize, BinaryData learningRateMultiplier, BinaryData nEpochs, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            BatchSize = batchSize;
            LearningRateMultiplier = learningRateMultiplier;
            NEpochs = nEpochs;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public BinaryData BatchSize { get; set; }

        public BinaryData LearningRateMultiplier { get; set; }

        public BinaryData NEpochs { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
