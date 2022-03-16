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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployStrategyConf : AbstractModel
    {
        
        /// <summary>
        /// Total batches
        /// </summary>
        [JsonProperty("TotalBatchCount")]
        public long? TotalBatchCount{ get; set; }

        /// <summary>
        /// Number of pods for the beta batch
        /// </summary>
        [JsonProperty("BetaBatchNum")]
        public long? BetaBatchNum{ get; set; }

        /// <summary>
        /// Batch deployment policy. `0`: automatically; `1`: manually; `2`: beta batch (manual)
        /// </summary>
        [JsonProperty("DeployStrategyType")]
        public long? DeployStrategyType{ get; set; }

        /// <summary>
        /// Interval between batches
        /// </summary>
        [JsonProperty("BatchInterval")]
        public long? BatchInterval{ get; set; }

        /// <summary>
        /// The minimum number of available pods
        /// </summary>
        [JsonProperty("MinAvailable")]
        public long? MinAvailable{ get; set; }

        /// <summary>
        /// Whether to enable force release
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalBatchCount", this.TotalBatchCount);
            this.SetParamSimple(map, prefix + "BetaBatchNum", this.BetaBatchNum);
            this.SetParamSimple(map, prefix + "DeployStrategyType", this.DeployStrategyType);
            this.SetParamSimple(map, prefix + "BatchInterval", this.BatchInterval);
            this.SetParamSimple(map, prefix + "MinAvailable", this.MinAvailable);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

