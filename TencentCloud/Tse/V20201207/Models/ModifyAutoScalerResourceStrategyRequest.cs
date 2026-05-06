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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoScalerResourceStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Gateway instance ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("StrategyId")]
        public string StrategyId{ get; set; }

        /// <summary>
        /// Policy name.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Metric scaling configuration
        /// </summary>
        [JsonProperty("Config")]
        public CloudNativeAPIGatewayStrategyAutoScalerConfig Config{ get; set; }

        /// <summary>
        /// Scheduled scaling configuration
        /// </summary>
        [JsonProperty("CronScalerConfig")]
        [System.Obsolete]
        public CloudNativeAPIGatewayStrategyCronScalerConfig CronScalerConfig{ get; set; }

        /// <summary>
        /// Maximum number of nodes
        /// </summary>
        [JsonProperty("MaxReplicas")]
        [System.Obsolete]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// Metric scaling configuration
        /// </summary>
        [JsonProperty("CronConfig")]
        public CloudNativeAPIGatewayStrategyCronScalerConfig CronConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "CronScalerConfig.", this.CronScalerConfig);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamObj(map, prefix + "CronConfig.", this.CronConfig);
        }
    }
}

