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

    public class DescribeVulTopRequest : AbstractModel
    {
        
        /// <summary>
        /// Top servers by vulnerability risks. The specific number is in the range of 1 to 100.
        /// </summary>
        [JsonProperty("Top")]
        public ulong? Top{ get; set; }

        /// <summary>
        /// 1: web CMS vulnerability; 2: application vulnerability; 4: Linux software vulnerability; 5: Windows system vulnerability; 6: emergency vulnerability. If this parameter is left blank or set to 0, the statistical data of all these types of vulnerabilities is returned.
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// Whether to count only focused vulnerabilities. 1: count only focused vulnerabilities; 0: count all vulnerabilities.
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

