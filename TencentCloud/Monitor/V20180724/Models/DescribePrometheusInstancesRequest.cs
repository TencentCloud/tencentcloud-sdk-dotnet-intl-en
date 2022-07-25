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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by instance ID or IDs. Instance ID is in the format of `prom-xxxxxxxx`. Up to 100 instances can be queried in one request.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Filter by instance status
        /// <ul>
        /// <li>1: Creating</li>
        /// <li>2: Running</li>
        /// <li>3: Abnormal</li>
        /// <li>4: Rebooting</li>
        /// <li>5: Terminating</li>
        /// <li>6: Service suspended</li>
        /// <li>8: Suspending service for overdue payment</li>
        /// <li>9: Service suspended for overdue payment</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long?[] InstanceStatus{ get; set; }

        /// <summary>
        /// Filter by instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Filter by AZ in the format of `ap-guangzhou-1`
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Filter by tag key-value pair. The `tag-key` should be replaced with a specific tag key.
        /// </summary>
        [JsonProperty("TagFilters")]
        public PrometheusTag[] TagFilters{ get; set; }

        /// <summary>
        /// Filter by instance IPv4 address
        /// </summary>
        [JsonProperty("IPv4Address")]
        public string[] IPv4Address{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Filter by billing mode
        /// <li>2: Monthly subscription</li>
        /// <li>3: Pay-as-you-go</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "InstanceStatus.", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamArraySimple(map, prefix + "IPv4Address.", this.IPv4Address);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
        }
    }
}

