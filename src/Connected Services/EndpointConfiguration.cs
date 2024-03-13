namespace Comdata
{
    public enum EndpointConfiguration 
    {
        /// <summary>
        /// The Comdata Certification (UAT) Environment is intended for DEVELOPMENT TESTING PURPOSES ONLY.
        /// </summary>
        Certification,

        /// <summary>
        /// The Comdata Production Environment provides access to your live data.  Be extremely careful with any committed changes.
        /// </summary>
        Production
    }
}
