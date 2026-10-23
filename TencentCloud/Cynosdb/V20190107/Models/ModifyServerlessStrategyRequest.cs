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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServerlessStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>serverless cluster id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Whether the cluster auto pauses, optional range</p><li>yes</li><li>no</li>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// <p>Delay of Cluster Auto-Pause, in seconds. Optional range: [600,691200]. Default: 600</p>
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// <p>This parameter is temporarily unavailable.</p>
        /// </summary>
        [JsonProperty("AutoScaleUpDelay")]
        public long? AutoScaleUpDelay{ get; set; }

        /// <summary>
        /// <p>This parameter is temporarily unavailable.</p>
        /// </summary>
        [JsonProperty("AutoScaleDownDelay")]
        public long? AutoScaleDownDelay{ get; set; }

        /// <summary>
        /// <p>Minimum cpu value. For the optional range, see the API response of DescribeServerlessInstanceSpecs.</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>Maximum value of cpu. For the optional range, see the API response of DescribeServerlessInstanceSpecs</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>Minimum cpu value of the read-only instance. For the optional range, see the API response of DescribeServerlessInstanceSpecs</p>
        /// </summary>
        [JsonProperty("MinRoCpu")]
        public float? MinRoCpu{ get; set; }

        /// <summary>
        /// <p>Read-only maximum value of cpu. For the optional range, see the API response of DescribeServerlessInstanceSpecs.</p>
        /// </summary>
        [JsonProperty("MaxRoCpu")]
        public float? MaxRoCpu{ get; set; }

        /// <summary>
        /// <p>Minimum number of read-only nodes</p>
        /// </summary>
        [JsonProperty("MinRoCount")]
        public long? MinRoCount{ get; set; }

        /// <summary>
        /// <p>Maximum number of read-only nodes</p>
        /// </summary>
        [JsonProperty("MaxRoCount")]
        public long? MaxRoCount{ get; set; }

        /// <summary>
        /// <p>Whether archive is enabled, optional range<li>yes</li><li>no</li>Default value: yes</p>
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// <p>Upgrade type. Default value: upgradeImmediate. Available values: upgradeImmediate: complete the modification immediately; upgradeInMaintain: complete the modification during the maintenance window</p>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// <p>List of security groups that the newly-added read-only instances need to bind to. This only binds security groups to read-only instances newly generated during this adjustment of policies, and existing instances are not bound.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIdsForNewRo")]
        public string[] SecurityGroupIdsForNewRo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "AutoScaleUpDelay", this.AutoScaleUpDelay);
            this.SetParamSimple(map, prefix + "AutoScaleDownDelay", this.AutoScaleDownDelay);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "MinRoCpu", this.MinRoCpu);
            this.SetParamSimple(map, prefix + "MaxRoCpu", this.MaxRoCpu);
            this.SetParamSimple(map, prefix + "MinRoCount", this.MinRoCount);
            this.SetParamSimple(map, prefix + "MaxRoCount", this.MaxRoCount);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdsForNewRo.", this.SecurityGroupIdsForNewRo);
        }
    }
}

