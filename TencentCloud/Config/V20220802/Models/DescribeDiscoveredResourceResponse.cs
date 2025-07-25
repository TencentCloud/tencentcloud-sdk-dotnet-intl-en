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

    public class DescribeDiscoveredResourceResponse : AbstractModel
    {
        
        /// <summary>
        /// Resource ID
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Resource type
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Resource Name
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Resource region
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Resource availability zone
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceZone")]
        public string ResourceZone{ get; set; }

        /// <summary>
        /// Resource configuration
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Configuration")]
        public string Configuration{ get; set; }

        /// <summary>
        /// Resource creation time
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// Resource tag
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Resource update time
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceZone", this.ResourceZone);
            this.SetParamSimple(map, prefix + "Configuration", this.Configuration);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

