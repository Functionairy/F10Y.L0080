using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0080
{
    /// <summary>
    /// .NET 8.0 foundation library JSON operator.
    /// </summary>
    [FunctionsMarker]
    public partial interface IJsonOperator :
        L0060.IJsonOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="L0060.IJsonOperator"/>
        [Ignore]
        public L0060.IJsonOperator _L0060 => L0060.JsonOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
