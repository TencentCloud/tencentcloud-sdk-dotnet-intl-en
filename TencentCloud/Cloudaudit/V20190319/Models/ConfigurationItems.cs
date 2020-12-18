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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigurationItems : AbstractModel
    {
        
        /// <summary>
        /// Time of getting a configuration item
        /// </summary>
        [JsonProperty("ConfigurationItemCaptureTime")]
        public string ConfigurationItemCaptureTime{ get; set; }

        /// <summary>
        /// Resource relationship list
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Relationships")]
        public string Relationships{ get; set; }

        /// <summary>
        /// This parameter takes effect only when `DiffMode` is set to `true`. When the input parameter `ChronologicalOrder` of the `GetConfigurationItems` API is set to `Forward`, details of the configuration item before the first one (if not a creation configuration item) will be returned. When this parameter is set to `Reverse`, details of the configuration item after the last one (if not a resource deletion configuration item) will be returned.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastItemInfo")]
        public string LastItemInfo{ get; set; }

        /// <summary>
        /// List of events associated with the configuration changes
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelatedEvents")]
        public RelatedEvent[] RelatedEvents{ get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Configuration item ID
        /// </summary>
        [JsonProperty("ConfigurationStateId")]
        public string ConfigurationStateId{ get; set; }

        /// <summary>
        /// Resource creation time
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// CFA version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Resource region
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Configuration")]
        public string Configuration{ get; set; }

        /// <summary>
        /// Resource name
        /// </summary>
        [JsonProperty("ResourceAlias")]
        public string ResourceAlias{ get; set; }

        /// <summary>
        /// Configuration item status. Valid values: OK, ResourceDiscovered, ResourceNotRecorded, ResourceDeleted, ResourceDeletedNotRecorded.
        /// </summary>
        [JsonProperty("ConfigurationItemStatus")]
        public string ConfigurationItemStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigurationItemCaptureTime", this.ConfigurationItemCaptureTime);
            this.SetParamSimple(map, prefix + "Relationships", this.Relationships);
            this.SetParamSimple(map, prefix + "LastItemInfo", this.LastItemInfo);
            this.SetParamArrayObj(map, prefix + "RelatedEvents.", this.RelatedEvents);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ConfigurationStateId", this.ConfigurationStateId);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "Configuration", this.Configuration);
            this.SetParamSimple(map, prefix + "ResourceAlias", this.ResourceAlias);
            this.SetParamSimple(map, prefix + "ConfigurationItemStatus", this.ConfigurationItemStatus);
        }
    }
}

