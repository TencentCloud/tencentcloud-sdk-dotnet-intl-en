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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// Unique traffic package ID
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// Traffic package name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TrafficPackageName")]
        public string TrafficPackageName{ get; set; }

        /// <summary>
        /// Traffic package size in GB
        /// </summary>
        [JsonProperty("TotalAmount")]
        public float? TotalAmount{ get; set; }

        /// <summary>
        /// Traffic package balance in GB
        /// </summary>
        [JsonProperty("RemainingAmount")]
        public float? RemainingAmount{ get; set; }

        /// <summary>
        /// Traffic package status. Valid values: `AVAILABLE`, `EXPIRED`, `EXHAUSTED`, `REFUNDED`, `DELETED`
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Traffic package creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Traffic package expiration time
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// Used traffic in GB
        /// </summary>
        [JsonProperty("UsedAmount")]
        public float? UsedAmount{ get; set; }

        /// <summary>
        /// Traffic package tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Traffic package type (idle-time or full-time)
        /// </summary>
        [JsonProperty("DeductType")]
        public string DeductType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamSimple(map, prefix + "TrafficPackageName", this.TrafficPackageName);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "RemainingAmount", this.RemainingAmount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "DeductType", this.DeductType);
        }
    }
}

