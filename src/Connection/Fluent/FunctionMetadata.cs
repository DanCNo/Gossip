﻿namespace Gossip.Connection.Fluent
{
    /// <summary>
    ///     Represents metadata about a given function call.
    /// </summary>
    public class FunctionMetadata
    {
        /// <summary>
        ///     The caller member name.
        /// </summary>
        public string CallerMemberName { get; set; }

        /// <summary>
        ///     The caller file path.
        /// </summary>
        public string CallerFilePath { get; set; }
    }
}