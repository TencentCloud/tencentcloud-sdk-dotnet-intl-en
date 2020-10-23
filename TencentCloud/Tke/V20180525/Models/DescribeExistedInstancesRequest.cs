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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExistedInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID. Enter the `ClusterId` field returned when you call the DescribeClusters API (Only VPC ID obtained through `ClusterId` need filtering conditions. When comparing statuses, the nodes on all clusters in this region will be used for comparison. You cannot specify `InstanceIds` and `ClusterId` at the same time.)
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Query by one or more instance ID(s). Instance ID format: ins-xxxxxxxx. (Refer to section ID.N of the API overview for this parameter's specific format.) Up to 100 instances are allowed for each request. You cannot specify InstanceIds and Filters at the same time.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Filter condition. For fields and other information, see [the DescribeInstances API](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1). If a ClusterId has been set, then the cluster's VPC ID will be attached as a query field. In this situation, if a "vpc-id" is specified in Filter, then the specified VPC ID must be consistent with the cluster's VPC ID.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Filter by instance IP (Supports both private and public IPs)
        /// </summary>
        [JsonProperty("VagueIpAddress")]
        public string VagueIpAddress{ get; set; }

        /// <summary>
        /// Filter by instance name
        /// </summary>
        [JsonProperty("VagueInstanceName")]
        public string VagueInstanceName{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on Offset, see the relevant section in the API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on Limit, see the relevant section in the API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "VagueIpAddress", this.VagueIpAddress);
            this.SetParamSimple(map, prefix + "VagueInstanceName", this.VagueInstanceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

