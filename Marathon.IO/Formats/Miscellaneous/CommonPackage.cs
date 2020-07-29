﻿namespace Marathon.IO.Formats.Miscellaneous
{
    /// <summary>
    /// File base for the Sonic '06 Common.bin format.
    /// </summary>
    public class CommonPackage : FileBase
    {
        public const string Extension = ".bin";

        /* TODO: Everything else...
                 This format seems very much all over the place and unfortunately is 61KB, which is huge for reversing. */
    }
}