// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Audio
{
    public readonly partial struct GeneratedSpeechVoice : IEquatable<GeneratedSpeechVoice>
    {
        private readonly string _value;
        private const string AlloyValue = "alloy";
        private const string AshValue = "ash";
        private const string CoralValue = "coral";
        private const string EchoValue = "echo";
        private const string FableValue = "fable";
        private const string OnyxValue = "onyx";
        private const string NovaValue = "nova";
        private const string SageValue = "sage";
        private const string ShimmerValue = "shimmer";

        public GeneratedSpeechVoice(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static GeneratedSpeechVoice Alloy { get; } = new GeneratedSpeechVoice(AlloyValue);

        public static GeneratedSpeechVoice Ash { get; } = new GeneratedSpeechVoice(AshValue);

        public static GeneratedSpeechVoice Coral { get; } = new GeneratedSpeechVoice(CoralValue);

        public static GeneratedSpeechVoice Echo { get; } = new GeneratedSpeechVoice(EchoValue);

        public static GeneratedSpeechVoice Fable { get; } = new GeneratedSpeechVoice(FableValue);

        public static GeneratedSpeechVoice Onyx { get; } = new GeneratedSpeechVoice(OnyxValue);

        public static GeneratedSpeechVoice Nova { get; } = new GeneratedSpeechVoice(NovaValue);

        public static GeneratedSpeechVoice Sage { get; } = new GeneratedSpeechVoice(SageValue);

        public static GeneratedSpeechVoice Shimmer { get; } = new GeneratedSpeechVoice(ShimmerValue);

        public static bool operator ==(GeneratedSpeechVoice left, GeneratedSpeechVoice right) => left.Equals(right);

        public static bool operator !=(GeneratedSpeechVoice left, GeneratedSpeechVoice right) => !left.Equals(right);

        public static implicit operator GeneratedSpeechVoice(string value) => new GeneratedSpeechVoice(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeneratedSpeechVoice other && Equals(other);

        public bool Equals(GeneratedSpeechVoice other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
