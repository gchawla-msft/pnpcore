﻿namespace PnP.Core.QueryModel
{
    /// <summary>
    /// Defines the target platform for the query
    /// </summary>
    public enum ODataTargetPlatform
    {
        /// <summary>
        /// Microsoft Graph (primary choice)
        /// </summary>
        Graph,
        /// <summary>
        /// Microsoft SharePoint Online REST API (fallback)
        /// </summary>
        SPORest
    }
}
