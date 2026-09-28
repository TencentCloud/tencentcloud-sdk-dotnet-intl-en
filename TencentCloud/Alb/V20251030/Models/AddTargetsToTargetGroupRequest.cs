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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddTargetsToTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Target group ID. The format is `lbtg-` followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// List of backend services to be added to the target group. A single request can add up to **50** backend services.
        /// </summary>
        [JsonProperty("Targets")]
        public TargetToAdd[] Targets{ get; set; }

        /// <summary>
        /// Whether to preview this request. 
        /// - **false** (default): Send a normal request and add the backend service directly to the target group. 
        /// - **true**: Send a preview request to check whether the parameters, format, and service limits for adding the backend service meet the requirements.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

