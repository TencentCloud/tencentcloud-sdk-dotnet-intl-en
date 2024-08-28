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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselinePolicy : AbstractModel
    {
        
        /// <summary>
        /// Policy name, which is no more than 128 English characters in length.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Detection interval [1: 1 day|3: 3 days|5: 5 days|7: 7 days]
        /// </summary>
        [JsonProperty("DetectInterval")]
        public long? DetectInterval{ get; set; }

        /// <summary>
        /// Detection time
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// Whether enabled [0: not enabled|1: enabled]
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// Asset type [0: all Professional and Ultimate editions|1: ID | 2: IP]
        /// </summary>
        [JsonProperty("AssetType")]
        public long? AssetType{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Number of associated baseline items
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// Number of associated baseline items
        /// </summary>
        [JsonProperty("ItemCount")]
        public long? ItemCount{ get; set; }

        /// <summary>
        /// Number of associated baseline hosts
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleIds")]
        public long?[] RuleIds{ get; set; }

        /// <summary>
        /// Host ID
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// Host IP
        /// </summary>
        [JsonProperty("HostIps")]
        public string[] HostIps{ get; set; }

        /// <summary>
        /// Whether the system default
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DetectInterval", this.DetectInterval);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "HostIps.", this.HostIps);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

