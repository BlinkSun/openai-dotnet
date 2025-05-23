// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Images
{
    public readonly partial struct GeneratedImageStyle : IEquatable<GeneratedImageStyle>
    {
        private readonly string _value;
        private const string VividValue = "vivid";
        private const string NaturalValue = "natural";

        public GeneratedImageStyle(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static GeneratedImageStyle Vivid { get; } = new GeneratedImageStyle(VividValue);

        public static GeneratedImageStyle Natural { get; } = new GeneratedImageStyle(NaturalValue);

        public static bool operator ==(GeneratedImageStyle left, GeneratedImageStyle right) => left.Equals(right);

        public static bool operator !=(GeneratedImageStyle left, GeneratedImageStyle right) => !left.Equals(right);

        public static implicit operator GeneratedImageStyle(string value) => new GeneratedImageStyle(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeneratedImageStyle other && Equals(other);

        public bool Equals(GeneratedImageStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
