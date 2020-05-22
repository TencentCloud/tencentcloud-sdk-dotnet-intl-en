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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupAssociationStatistics : AbstractModel
    {
        
        /// <summary>
        /// Security group instance ID.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// Number of CVM instances.
        /// </summary>
        [JsonProperty("CVM")]
        public ulong? CVM{ get; set; }

        /// <summary>
        /// Number of database instances.
        /// </summary>
        [JsonProperty("CDB")]
        public ulong? CDB{ get; set; }

        /// <summary>
        /// Number of ENI instances.
        /// </summary>
        [JsonProperty("ENI")]
        public ulong? ENI{ get; set; }

        /// <summary>
        /// Number of times a security group is referenced by other security groups
        /// </summary>
        [JsonProperty("SG")]
        public ulong? SG{ get; set; }

        /// <summary>
        /// Number of load balancer instances.
        /// </summary>
        [JsonProperty("CLB")]
        public ulong? CLB{ get; set; }

        /// <summary>
        /// The binding statistics for all instances.
        /// </summary>
        [JsonProperty("InstanceStatistics")]
        public InstanceStatistic[] InstanceStatistics{ get; set; }

        /// <summary>
        /// Total count of all resources (excluding resources referenced by security groups).
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "CVM", this.CVM);
            this.SetParamSimple(map, prefix + "CDB", this.CDB);
            this.SetParamSimple(map, prefix + "ENI", this.ENI);
            this.SetParamSimple(map, prefix + "SG", this.SG);
            this.SetParamSimple(map, prefix + "CLB", this.CLB);
            this.SetParamArrayObj(map, prefix + "InstanceStatistics.", this.InstanceStatistics);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

