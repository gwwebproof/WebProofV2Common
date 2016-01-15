namespace WebProofIdentitySync.models
{
    /// <summary>
    /// Status type for a single user import record.
    /// </summary>
    internal enum UserImportStatus
    {
        /// <summary>
        /// The failed status for a new user.
        /// </summary>
        NewFailed = 0,
        /// <summary>
        /// The ok status for a new user.
        /// </summary>
        NewOk = 1,
        /// <summary>
        /// The new role failed status, when a new user is not added to role
        /// </summary>
        NewRoleFailed = 2,
        /// <summary>
        /// The failed status for updating a user.
        /// </summary>
        UpdateFailed = 3,
        /// <summary>
        /// The ok status for updating a user.
        /// </summary>
        UpdateOk = 4,
        /// <summary>
        /// The update not needed status for updating a user.
        /// </summary>
        UpdateNotNeeded = 5
    }

    /// <summary>
    /// Status for a single user import / update.
    /// </summary>
    internal sealed class WebProofUserImport
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public UserImportStatus Status { get; set; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get
            {
                return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
                    ? string.Format("{0}, {1}", FirstName, LastName) : (!string.IsNullOrEmpty(FirstName) ? FirstName : (!string.IsNullOrEmpty(LastName) ? LastName : UserName));
            }
        }
    }
}
