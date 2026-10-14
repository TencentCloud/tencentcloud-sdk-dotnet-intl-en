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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AZ to which the cluster instance belongs. All AZs are selected by default if this parameter is not specified.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Cluster instance ID list</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>Cluster instance name list.</p>
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// <p>Pagination starting value. Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Page size. Default value: 20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Sorting field<li>1: Instance ID</li><li>2: Instance name</li><li>3: Availability zone</li><li>4: Creation time</li>If orderByKey is not transmitted, sort by creation time in descending order</p>
        /// </summary>
        [JsonProperty("OrderByKey")]
        public ulong? OrderByKey{ get; set; }

        /// <summary>
        /// <p>Sorting method<li>0: ascending</li><li>1: descending</li>If orderByKey is passed but orderByType is not, ascending by default</p>
        /// </summary>
        [JsonProperty("OrderByType")]
        public ulong? OrderByType{ get; set; }

        /// <summary>
        /// <p>Node tag information list</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// <p>Private network vip list</p>
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// <p>IP list of cluster nodes</p>
        /// </summary>
        [JsonProperty("NodeIps")]
        public string[] NodeIps{ get; set; }

        /// <summary>
        /// <p>Availability zone list</p>
        /// </summary>
        [JsonProperty("ZoneList")]
        public string[] ZoneList{ get; set; }

        /// <summary>
        /// <p>Health status filter list: 0 represents green, 1 represents yellow, 2 represents red, -1 represents unknown</p>
        /// </summary>
        [JsonProperty("HealthStatus")]
        public long?[] HealthStatus{ get; set; }

        /// <summary>
        /// <p>Vpc list filter item</p>
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// <p>cdc cluster id</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByKey", this.OrderByKey);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamArraySimple(map, prefix + "NodeIps.", this.NodeIps);
            this.SetParamArraySimple(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamArraySimple(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

