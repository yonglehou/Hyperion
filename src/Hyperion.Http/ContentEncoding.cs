using System;

namespace Hyperion.Http
{
    public static class ContentEncoding
    {
        /// <summary>
        /// UNIX "compress" program method.
        /// </summary>
        [Obsolete("Deprecated in most applications and replaced by gzip or deflate")]
        public const string Compress = "compress";

        /// <summary>
        /// Compression based on the deflate algorithm.
        /// </summary>
        public const string Deflate = "deflate";

        /// <summary>
        /// W3C Efficient XML Interchange.
        /// </summary>
        public const string Exi = "exi";

        /// <summary>
        /// GNU zip format.
        /// </summary>
        public const string GZip = "gzip";

        /// <summary>
        /// No transformation is used. This is the default value for content coding.
        /// </summary>
        public const string Identity = "identity";

        /// <summary>
        /// Network Transfer Format for Java Archives.
        /// </summary>
        public const string Pack200GZip = "pack200-gzip";

        /// <summary>
        /// Compression based on the free bzip2 format.
        /// </summary>
        public const string BZip2 = "bzip2";

        /// <summary>
        /// Compression based on (raw) LZMA is available in Opera 20.
        /// </summary>
        public const string Lzma = "lzma";

        /// <summary>
        /// Microsoft Peer Content Caching and Retrieval.
        /// </summary>
        public const string Peerdist = "peerdist";

        /// <summary>
        /// Google Shared Dictionary Compression for HTTP, based on VCDIFF (RFC 3284); supported natively in recent versions of Google Chrome, Chromium and Android, as well as on Google websites.
        /// </summary>
        public const string Sdch = "sdch";

        /// <summary>
        /// LZMA2-based content compression, supported by a non-official Firefox patch.
        /// </summary>
        public const string Xz = "xz";
    }

}