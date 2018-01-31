// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object describing supported model by name and categories.
    /// </summary>
    public partial class ModelDescription
    {
        /// <summary>
        /// Initializes a new instance of the ModelDescription class.
        /// </summary>
        public ModelDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelDescription class.
        /// </summary>
        public ModelDescription(string name = default(string), IList<string> categories = default(IList<string>))
        {
            Name = name;
            Categories = categories;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }

    }
}