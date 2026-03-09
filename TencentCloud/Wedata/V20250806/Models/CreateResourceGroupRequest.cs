/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateResourceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource group name. specifies the name of a general resource group. it must start with a letter, may include letters, numbers, and underscores (_), and can contain up to 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Opened resource group information.
        /// </summary>
        [JsonProperty("Type")]
        public ResourceType Type{ get; set; }

        /// <summary>
        /// Whether to perform auto-renewal.
        /// </summary>
        [JsonProperty("AutoRenewEnabled")]
        public bool? AutoRenewEnabled{ get; set; }

        /// <summary>
        /// Purchase duration, in unit month.
        /// </summary>
        [JsonProperty("PurchasePeriod")]
        public long? PurchasePeriod{ get; set; }

        /// <summary>
        /// vpcId
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet
        /// </summary>
        [JsonProperty("SubNet")]
        public string SubNet{ get; set; }

        /// <summary>
        /// Resource purchase region.
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Project id of the associated project space.
        /// </summary>
        [JsonProperty("AssociatedProjectId")]
        public string AssociatedProjectId{ get; set; }

        /// <summary>
        /// Resource group description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "AutoRenewEnabled", this.AutoRenewEnabled);
            this.SetParamSimple(map, prefix + "PurchasePeriod", this.PurchasePeriod);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubNet", this.SubNet);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "AssociatedProjectId", this.AssociatedProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

