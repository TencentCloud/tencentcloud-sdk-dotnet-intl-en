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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulLevelImageSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Percentage of high-risk vulnerabilities in the latest local images
        /// </summary>
        [JsonProperty("HighLevelVulLocalImagePercent")]
        public float? HighLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// Percentage of medium-risk vulnerabilities in the latest local images
        /// </summary>
        [JsonProperty("MediumLevelVulLocalImagePercent")]
        public float? MediumLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// Percentage of low-risk vulnerabilities in the latest local images
        /// </summary>
        [JsonProperty("LowLevelVulLocalImagePercent")]
        public float? LowLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// Percentage of critical vulnerabilities in the latest local images
        /// </summary>
        [JsonProperty("CriticalLevelVulLocalImagePercent")]
        public float? CriticalLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// Number of affected local images on the latest version
        /// </summary>
        [JsonProperty("LocalNewestImageCount")]
        public long? LocalNewestImageCount{ get; set; }

        /// <summary>
        /// Number of affected repository images on the latest version
        /// </summary>
        [JsonProperty("RegistryNewestImageCount")]
        public long? RegistryNewestImageCount{ get; set; }

        /// <summary>
        /// Percentage of high-risk vulnerabilities in the latest repository image
        /// </summary>
        [JsonProperty("HighLevelVulRegistryImagePercent")]
        public float? HighLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// Percentage of medium-risk vulnerabilities in the latest repository image
        /// </summary>
        [JsonProperty("MediumLevelVulRegistryImagePercent")]
        public float? MediumLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// Percentage of low-risk vulnerabilities in the latest repository image
        /// </summary>
        [JsonProperty("LowLevelVulRegistryImagePercent")]
        public float? LowLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// Percentage of critical vulnerabilities in the latest repository image
        /// </summary>
        [JsonProperty("CriticalLevelVulRegistryImagePercent")]
        public float? CriticalLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighLevelVulLocalImagePercent", this.HighLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "MediumLevelVulLocalImagePercent", this.MediumLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "LowLevelVulLocalImagePercent", this.LowLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "CriticalLevelVulLocalImagePercent", this.CriticalLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "LocalNewestImageCount", this.LocalNewestImageCount);
            this.SetParamSimple(map, prefix + "RegistryNewestImageCount", this.RegistryNewestImageCount);
            this.SetParamSimple(map, prefix + "HighLevelVulRegistryImagePercent", this.HighLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "MediumLevelVulRegistryImagePercent", this.MediumLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "LowLevelVulRegistryImagePercent", this.LowLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "CriticalLevelVulRegistryImagePercent", this.CriticalLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

