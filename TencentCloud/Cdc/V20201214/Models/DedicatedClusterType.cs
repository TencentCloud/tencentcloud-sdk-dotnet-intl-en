/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterType : AbstractModel
    {
        
        /// <summary>
        /// Configuration id
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// Configuration description, corresponding to description 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Configuration name, corresponding to computing resource type
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Configuration creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// List of supported storage types
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// Supported uplink switch transmission rate
        /// </summary>
        [JsonProperty("SupportedUplinkGiB")]
        public long?[] SupportedUplinkGiB{ get; set; }

        /// <summary>
        /// List of supported instance families
        /// </summary>
        [JsonProperty("SupportedInstanceFamily")]
        public string[] SupportedInstanceFamily{ get; set; }

        /// <summary>
        /// Floor weight capacity (KG)
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Power requirements (KW)
        /// </summary>
        [JsonProperty("PowerDrawKva")]
        public float? PowerDrawKva{ get; set; }

        /// <summary>
        /// Displays the details of computing resource types, and does not display resources such as storage; corresponding to type
        /// </summary>
        [JsonProperty("ComputeFormatDesc")]
        public string ComputeFormatDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkGiB.", this.SupportedUplinkGiB);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDrawKva", this.PowerDrawKva);
            this.SetParamSimple(map, prefix + "ComputeFormatDesc", this.ComputeFormatDesc);
        }
    }
}

