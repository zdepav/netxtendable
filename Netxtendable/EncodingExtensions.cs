using System.Text;

namespace Netxtendable {
    
    /// <summary>Class with extension methods for <see cref="Encoding"/></summary>
    public static class EncodingExtensions {

        /// <summary>T
        /// ries to convert given sequence of bytes into a string using the given encoding.
        /// </summary>
        /// <param name="enc">Encoding to use.</param>
        /// <param name="bytes">Bytes that should be converted.</param>
        /// <param name="str">Output string.</param>
        /// <returns>true if the conversion was successful, false otherwise</returns>
        public static bool TryGetString(this Encoding enc, byte[] bytes, out string str) {
            str = "";
            if (enc is null || bytes is null) {
                return false;
            }
            try {
                str = enc.GetString(bytes);
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
        /// <returns>true if the conversion was successful, false otherwise</returns>
        public static bool TryGetChars(this Encoding enc, byte[] bytes, out char[]? str) {
            str = null;
            if (enc is null || bytes is null) {
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
