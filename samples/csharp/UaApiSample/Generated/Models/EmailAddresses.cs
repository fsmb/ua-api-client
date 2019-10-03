﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Apis.Ua.Clients.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Email information
    /// </summary>
    public partial class EmailAddresses
    {
        /// <summary>
        /// Initializes a new instance of the EmailAddresses class.
        /// </summary>
        public EmailAddresses() { }

        /// <summary>
        /// Initializes a new instance of the EmailAddresses class.
        /// </summary>
        public EmailAddresses(EmailAddress forPublic, EmailAddress forBoard, IList<EmailAddress> other = default(IList<EmailAddress>))
        {
            ForPublic = forPublic;
            ForBoard = forBoard;
            Other = other;
        }

        /// <summary>
        /// Public email
        /// </summary>
        [JsonProperty(PropertyName = "forPublic")]
        public EmailAddress ForPublic { get; set; }

        /// <summary>
        /// Board email
        /// </summary>
        [JsonProperty(PropertyName = "forBoard")]
        public EmailAddress ForBoard { get; set; }

        /// <summary>
        /// Other emails
        /// </summary>
        [JsonProperty(PropertyName = "other")]
        public IList<EmailAddress> Other { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ForPublic == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ForPublic");
            }
            if (ForBoard == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ForBoard");
            }
            if (this.ForPublic != null)
            {
                this.ForPublic.Validate();
            }
            if (this.ForBoard != null)
            {
                this.ForBoard.Validate();
            }
            if (this.Other != null)
            {
                foreach (var element in this.Other)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
