﻿namespace PnP.Core.Services
{
    /// <summary>
    /// Possible APIs used to talk to data stores
    /// </summary>
    internal enum ApiType
    {
        /// <summary>
        /// Using the SharePoint REST API
        /// </summary>
        SPORest = 0,

        /// <summary>
        /// Using the production v1 Microsoft Graph REST API
        /// </summary>
        Graph = 1,

        /// <summary>
        /// Using the beta Microsoft Graph REST API
        /// </summary>
        GraphBeta = 2,

        /// <summary>
        /// Using the SharePoint CSOM API
        /// </summary>
        CSOM = 3

    }
}
