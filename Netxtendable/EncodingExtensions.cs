using System.Text;

namespace Netxtendable {

    public static class EncodingExtensions {

        public static bool TryGetString(this Encoding enc, byte[] bytes, out string str) {
            str = null;
            if (enc is null || bytes is null)
                return false;
            try {
                str = enc.GetString(bytes);
                return true;
            } catch {
                return false;
            }
        }

    }

}
