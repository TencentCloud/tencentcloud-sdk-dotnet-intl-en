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

    public class TargetGroupHealthInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the health check.
        /// </summary>
        [JsonProperty("HealthCheckEnabled")]
        public bool? HealthCheckEnabled{ get; set; }

        /// <summary>
        /// Target group ID in the format of lbtg- followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// List of service health check statuses.
        /// </summary>
        [JsonProperty("TargetHealthStatusInfos")]
        public TargetHealthStatusInfo[] TargetHealthStatusInfos{ get; set; }

        /// <summary>
        /// Forward action type. Valid values:
        /// TargetGroup: Forward to a target group.
        /// Redirect: Redirection.
        /// FixedResponse: returns fixed content.
        /// Rewrite: Rewrite.
        /// InsertHeader: Write to an HTTP header.
        /// RemoveHeader: Delete HTTP Header.
        /// Forward action must include one of TargetGroup, Redirect, or FixedResponse, and the execution order is placed last.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckEnabled", this.HealthCheckEnabled);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamArrayObj(map, prefix + "TargetHealthStatusInfos.", this.TargetHealthStatusInfos);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

