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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgDetectJS : AbstractModel
    {
        
        /// <summary>
        /// Method to validate client behavior.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Proof-of-work strength. Values:
        /// <li>`low` (default): Low</li>
        /// <li>`middle`: Medium</li>
        /// <li>`high`: High</li>
        /// </summary>
        [JsonProperty("WorkLevel")]
        public string WorkLevel{ get; set; }

        /// <summary>
        /// Implement a delay before executing JS in milliseconds. Value range: 0-1000. Default value: 500.
        /// </summary>
        [JsonProperty("ExecuteMode")]
        public long? ExecuteMode{ get; set; }

        /// <summary>
        /// The period threshold for validating the result "Client JS disabled" in seconds. Value range: 5-3600. Default value: 10.
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// The number of times for the result "Client JS disabled" occurred in the specified period. Value range: 1-100000000. Default value: 30.
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Client behavior validation results.
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "WorkLevel", this.WorkLevel);
            this.SetParamSimple(map, prefix + "ExecuteMode", this.ExecuteMode);
            this.SetParamSimple(map, prefix + "InvalidStatTime", this.InvalidStatTime);
            this.SetParamSimple(map, prefix + "InvalidThreshold", this.InvalidThreshold);
            this.SetParamArrayObj(map, prefix + "AlgDetectResults.", this.AlgDetectResults);
        }
    }
}

