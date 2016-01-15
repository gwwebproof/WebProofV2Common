using System;

namespace IntercommIoSync.models
{
    /// <summary>
    /// POCO for the pwebproof_asp table query.
    /// </summary>
    internal class WebProofAsp
    {
        /// <summary>Gets or sets the web proof unique identifier.</summary>
        /// <value>The web proof unique identifier.</value>
        public Guid WebProofGuid { get; set; }

        /// <summary>Gets the web proof identifier.</summary>
        /// <value>The web proof identifier.</value>
        public virtual string WebProofId
        {
            get { return WebProofGuid.ToString(); }
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

    }
}
