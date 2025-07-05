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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AggregateResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// Resource type
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Resource name
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Region
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Resource Status
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public string ResourceStatus{ get; set; }

        /// <summary>
        /// Whether to delete. 1: Deleted; 0: Not deleted.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceDelete")]
        public ulong? ResourceDelete{ get; set; }

        /// <summary>
        /// Resource creation time
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// Tag information
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Availability zone
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceZone")]
        public string ResourceZone{ get; set; }

        /// <summary>
        /// Compliance status
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string ComplianceResult{ get; set; }

        /// <summary>
        /// Resource owner uid
        /// </summary>
        [JsonProperty("ResourceOwnerId")]
        public ulong? ResourceOwnerId{ get; set; }

        /// <summary>
        /// User nickname
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceOwnerName")]
        public string ResourceOwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "ResourceDelete", this.ResourceDelete);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ResourceZone", this.ResourceZone);
            this.SetParamSimple(map, prefix + "ComplianceResult", this.ComplianceResult);
            this.SetParamSimple(map, prefix + "ResourceOwnerId", this.ResourceOwnerId);
            this.SetParamSimple(map, prefix + "ResourceOwnerName", this.ResourceOwnerName);
        }
    }
}

