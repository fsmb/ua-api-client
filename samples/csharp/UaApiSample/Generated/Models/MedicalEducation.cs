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
    /// Medical school education
    /// </summary>
    public partial class MedicalEducation
    {
        /// <summary>
        /// Initializes a new instance of the MedicalEducation class.
        /// </summary>
        public MedicalEducation() { }

        /// <summary>
        /// Initializes a new instance of the MedicalEducation class.
        /// </summary>
        public MedicalEducation(School school, DateTime? beginDate = default(DateTime?), DateTime? endDate = default(DateTime?),
            CodedDescription degree = default(CodedDescription), DateTime? graduationDate = default(DateTime?))
        {
            School = school;
            BeginDate = beginDate;
            EndDate = endDate;
            Degree = degree;
            GraduationDate = graduationDate;
        }

        /// <summary>
        /// Medical school
        /// </summary>
        [JsonProperty(PropertyName = "school")]
        public School School { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [JsonProperty(PropertyName = "beginDate")]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Degree information
        /// </summary>
        [JsonProperty(PropertyName = "degree")]
        public CodedDescription Degree { get; set; }

        /// <summary>
        /// Graduation date
        /// </summary>
        [JsonProperty(PropertyName = "graduationDate")]
        public DateTime? GraduationDate { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (School == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "School");
            }
            if (this.School != null)
            {
                this.School.Validate();
            }
        }
    }
}
