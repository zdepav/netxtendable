using System.Text;

namespace Netxtendable.Text {
    
    /// <summary>Class with extension methods for <see cref="Encoding"/>.</summary>
    public static class EncodingExtensions {

        /// <summary>T
        /// ries to convert given sequence of bytes into a string using the given encoding.
        /// </summary>
        /// <param name="enc">Encoding to use.</param>
        /// <param name="bytes">Bytes that should be converted.</param>
        /// <param name="str">Output string.</param>
        /// <param name="byteIndex">Index of first decoded byte in <paramref name="bytes"/>.</param>
        /// <param name="byteCount">Number of bytes to decode.</param>
        /// <returns>true if the conversion was successful, false otherwise</returns>
        public static bool TryGetString(this Encoding enc, byte[] bytes, out string str, int byteIndex = 0, int byteCount = 0) {
            str = "";
            if (enc is null || bytes is null ||
                byteIndex < 0 || byteIndex >= bytes.Length ||
                byteCount < 0 || byteCount > bytes.Length - byteIndex
            ) {
                return false;
            }
            if (byteCount == 0) {
                byteCount = bytes.Length - byteIndex;
            }
            try {
                str = enc.GetString(bytes, byteIndex, byteCount);
                return true;
            } catch {
                return false;
            }
        }

        /// <summary>T
        /// ries to convert given sequence of bytes into characters using the given encoding.
        /// </summary>
        /// <param name="enc">Encoding to use.</param>
        /// <param name="bytes">Bytes that should be converted.</param>
        /// <param name="str">Output char array.</param>
        /// <param name="byteIndex">Index of first decoded byte in <paramref name="bytes"/>.</param>
        /// <param name="byteCount">Number of bytes to decode.</param>
        /// <returns>true if the conversion was successful, false otherwise</returns>
        public static bool TryGetChars(this Encoding enc, byte[] bytes, out char[]? str, int byteIndex = 0, int byteCount = 0) {
            str = null;
            if (enc is null || bytes is null ||
                byteIndex < 0 || byteIndex >= bytes.Length ||
                byteCount < 0 || byteCount > bytes.Length - byteIndex
            ) {
                return false;
            }
            try {
                str = enc.GetChars(bytes);
                return true;
            } catch {
                return false;
            }
        }

    }

}
