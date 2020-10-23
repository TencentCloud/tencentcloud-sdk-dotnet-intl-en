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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability category ID.
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability name.
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability level.
        /// </summary>
        [JsonProperty("VulLevel")]
        public string VulLevel{ get; set; }

        /// <summary>
        /// Vulnerability type.
        /// </summary>
        [JsonProperty("VulType")]
        public string VulType{ get; set; }

        /// <summary>
        /// Vulnerability description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Repair plan.
        /// </summary>
        [JsonProperty("RepairPlan")]
        public string RepairPlan{ get; set; }

        /// <summary>
        /// Vulnerability CVE.
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// Reference link.
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

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
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulLevel", this.VulLevel);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RepairPlan", this.RepairPlan);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

