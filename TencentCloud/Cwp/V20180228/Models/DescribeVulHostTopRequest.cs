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

    public class DescribeVulHostTopRequest : AbstractModel
    {
        
        /// <summary>
        /// Obtain top values: 1-100
        /// </summary>
        [JsonProperty("Top")]
        public ulong? Top{ get; set; }

        /// <summary>
        /// 1: web-cms vulnerabilities; 2: application vulnerabilities; 4: Linux software vulnerabilities; 5: Windows system vulnerabilities; 6: emergency vulnerabilities. If it is left blank or set to 0, the total statistics of vulnerabilities 1, 2, 4, and 5 are returned.
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// Whether to count only critical vulnerabilities: 1: only critical vulnerabilities; 0: all vulnerabilities
        /// </summary>
        [JsonProperty("IsFollowVul")]
        public ulong? IsFollowVul{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "IsFollowVul", this.IsFollowVul);
        }
    }
}

