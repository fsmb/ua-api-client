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
    /// Phone information
    /// </summary>
    public partial class Phones
    {
        /// <summary>
        /// Initializes a new instance of the Phones class.
        /// </summary>
        public Phones() { }

        /// <summary>
        /// Initializes a new instance of the Phones class.
        /// </summary>
        public Phones(Phone forPublic, Phone forBoard, IList<Phone> other = default(IList<Phone>))
        {
            ForPublic = forPublic;
            ForBoard = forBoard;
            Other = other;
        }

        /// <summary>
        /// Public phone
        /// </summary>
        [JsonProperty(PropertyName = "forPublic")]
        public Phone ForPublic { get; set; }

        /// <summary>
        /// Board phone
        /// </summary>
        [JsonProperty(PropertyName = "forBoard")]
        public Phone ForBoard { get; set; }

        /// <summary>
        /// Other phone numbers
        /// </summary>
        [JsonProperty(PropertyName = "other")]
        public IList<Phone> Other { get; set; }

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