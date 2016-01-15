using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebProofIdentitySync.models
{
    /// <summary>
    /// Model for Edit and Create AppUser
    /// </summary>
    internal sealed class CreateUpdateAppUser
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the web proof user identifier.
        /// </summary>
        /// <value>
        /// The web proof user identifier.
        /// </value>
        [Required]
        public Guid WebProofUserId { get; set; }

        /// <summary>
        /// Gets or sets the web proof global identifier.<br/>
        /// This is the Guid for the main client installation and is used to find the corrent client db.
        /// </summary>
        /// <value>
        /// The web proof global identifier.
        /// </value>
        [Required]
        public Guid WebProofGlobalId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [Required, DisplayName("User Name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disabled in web proof.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is disabled in web proof; otherwise, <c>false</c>.
        /// </value>
        [Required]
        [DisplayName("WebProof Disabled")]
        public bool IsDisabledInWebProof { get; set; }

        /// <summary>
        /// Gets or sets the last client database synchronize date.
        /// </summary>
        /// <value>
        /// The last client database synchronize timestamp.
        /// </value>
        [DisplayName("Last Synced")]
        public DateTime? LastClientDbSyncDate { get; set; }

        /// <summary>
        /// Gets or sets the access failed count.
        /// </summary>
        /// <value>
        /// The access failed count.
        /// </value>
        [DisplayName("Failed Logins")]
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// Gets or sets the lockout end date UTC.
        /// </summary>
        /// <value>
        /// The lockout end date UTC.
        /// </value>
        [DisplayName("Lockout Ends")]
        public DateTime? LockoutEndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required, DisplayName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [email confirmed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [email confirmed]; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Email Confirmed")]
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [lockout enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [lockout enabled]; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Lockout Enabled")]
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [DisplayName("Sms Number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [phone number confirmed].
        /// </summary>
        /// <value>
        /// <c>true</c> if [phone number confirmed]; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Number Confirmed")]
        public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        [DisplayName("Roles")]
        public IEnumerable<IdentityRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [two factor enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [two factor enabled]; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Enable Two Factor Auth")]
        public bool TwoFactorEnabled { get; set; }
    }
}
