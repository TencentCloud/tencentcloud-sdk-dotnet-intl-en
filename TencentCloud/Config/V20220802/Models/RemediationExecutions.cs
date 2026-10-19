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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemediationExecutions : AbstractModel
    {
        
        /// <summary>
        /// Remediation status. Valid values: 1 (running), 2 (successful), and 3 (failed).
        /// </summary>
        [JsonProperty("ExecutionStatus")]
        public ulong? ExecutionStatus{ get; set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        [JsonProperty("ExecutionResourceType")]
        public string ExecutionResourceType{ get; set; }

        /// <summary>
        /// Fixing time
        /// </summary>
        [JsonProperty("ExecutionCreateDate")]
        public string ExecutionCreateDate{ get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("ExecutionStatusMessage")]
        public string ExecutionStatusMessage{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ExecutionResourceIds")]
        public string ExecutionResourceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionStatus", this.ExecutionStatus);
            this.SetParamSimple(map, prefix + "ExecutionResourceType", this.ExecutionResourceType);
            this.SetParamSimple(map, prefix + "ExecutionCreateDate", this.ExecutionCreateDate);
            this.SetParamSimple(map, prefix + "ExecutionStatusMessage", this.ExecutionStatusMessage);
            this.SetParamSimple(map, prefix + "ExecutionResourceIds", this.ExecutionResourceIds);
        }
    }
}

