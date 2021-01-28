#nullable enable
using System;
#if NET_CORE
using System.Numerics;
#endif
using System.Runtime.CompilerServices ;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Extensions.Numerics {

    /// <summary>Class with extension methods for all standard integer types</summary>
    public static class IntegerExtensions {

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(this sbyte value, sbyte min, sbyte max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(this byte value, byte min, byte max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(this short value, short min, short max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(this ushort value, ushort min, ushort max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(this int value, int min, int max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(this uint value, uint min, uint max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(this long value, long min, long max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(this ulong value, ulong min, ulong max) =>
            value < min ? min : value > max ? max : value;

#if NET_CORE
        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BigInteger Clamp(this BigInteger value, BigInteger min, BigInteger max) =>
            value < min ? min : value > max ? max : value;
#endif

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(this float value, float min, float max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(this double value, double min, double max) =>
            value < min ? min : value > max ? max : value;

        /// <summary>Clamps a value between two bounds</summary>
        /// <param name="value">Value to clamp</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <remarks>If max &lt; min the result is undefined</remarks>
        /// <returns>
        /// <paramref name="min"/> if <paramref name="value"/> &lt; <paramref name="min"/>,
        /// <paramref name="max"/> if <paramref name="value"/> &gt; <paramref name="max"/>,
        /// <paramref name="value"/> otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Clamp(this decimal value, decimal min, decimal max) =>
            value < min ? min : value > max ? max : value;
    }
}
