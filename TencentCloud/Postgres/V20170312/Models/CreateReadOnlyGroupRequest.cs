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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReadOnlyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Primary instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/api/409/16773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// Read-Only group name. only supports chinese, english, digits, "_", or "-" with length less than 60.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Project ID. default value is 0, means it belongs to the default project.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// VPC ID. note: uses classic networks by default. currently, basic networks are not supported, so this parameter is required.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. note: uses classic networks by default. currently, basic networks are not supported, so this parameter is required.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Delay time size switch: 0 for off, 1 for on. this parameter is required.
        /// </summary>
        [JsonProperty("ReplayLagEliminate")]
        public ulong? ReplayLagEliminate{ get; set; }

        /// <summary>
        /// Delay space size switch: 0 for off, 1 for on. this parameter must match ReplayLagEliminate.
        /// </summary>
        [JsonProperty("ReplayLatencyEliminate")]
        public ulong? ReplayLatencyEliminate{ get; set; }

        /// <summary>
        /// The size threshold of the delay time, a positive integer with unit: s. this parameter is required when ReplayLagEliminate is 1 and must be set to 0 when ReplayLagEliminate is 0.
        /// </summary>
        [JsonProperty("MaxReplayLag")]
        public ulong? MaxReplayLag{ get; set; }

        /// <summary>
        /// Delay threshold for space size, a positive integer in MB. this parameter is required when ReplayLatencyEliminate is 1 and must be set to 0 when ReplayLatencyEliminate is 0.
        /// </summary>
        [JsonProperty("MaxReplayLatency")]
        public ulong? MaxReplayLatency{ get; set; }

        /// <summary>
        /// Specifies the minimum number of instances to retain with delay removal. value range [0,100]. this parameter is required when ReplayLatencyEliminate is 1 and invalid when ReplayLagEliminate is 0.
        /// </summary>
        [JsonProperty("MinDelayEliminateReserve")]
        public ulong? MinDelayEliminateReserve{ get; set; }

        /// <summary>
        /// Security group ID
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ReplayLagEliminate", this.ReplayLagEliminate);
            this.SetParamSimple(map, prefix + "ReplayLatencyEliminate", this.ReplayLatencyEliminate);
            this.SetParamSimple(map, prefix + "MaxReplayLag", this.MaxReplayLag);
            this.SetParamSimple(map, prefix + "MaxReplayLatency", this.MaxReplayLatency);
            this.SetParamSimple(map, prefix + "MinDelayEliminateReserve", this.MinDelayEliminateReserve);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

