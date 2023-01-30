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

    public class DescribeAssetImageScanSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// Switch
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// Scan time, which is a complete time and parsed as hour/minute/second in time zone 0 on the backend.
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// Scan interval
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public ulong? ScanPeriod{ get; set; }

        /// <summary>
        /// Trojan scan
        /// </summary>
        [JsonProperty("ScanVirus")]
        public bool? ScanVirus{ get; set; }

        /// <summary>
        /// Sensitive data scan
        /// </summary>
        [JsonProperty("ScanRisk")]
        public bool? ScanRisk{ get; set; }

        /// <summary>
        /// Vulnerability scan
        /// </summary>
        [JsonProperty("ScanVul")]
        public bool? ScanVul{ get; set; }

        /// <summary>
        /// Scan of all images
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// Scan of specified images
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

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
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamSimple(map, prefix + "ScanVirus", this.ScanVirus);
            this.SetParamSimple(map, prefix + "ScanRisk", this.ScanRisk);
            this.SetParamSimple(map, prefix + "ScanVul", this.ScanVul);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

