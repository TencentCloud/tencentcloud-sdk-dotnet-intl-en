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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// AZ of the cluster instance. If this is not passed in, all AZs are used by default
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// List of cluster instance IDs
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// List of cluster instance names
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// Pagination start value. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of entries per page. Default value: 20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Sort by field <li>1: instance ID </li><li>2: instance name </li><li>3: AZ </li><li>4: creation time </li>If `orderKey` is not passed in, sort by creation time in descending order
        /// </summary>
        [JsonProperty("OrderByKey")]
        public ulong? OrderByKey{ get; set; }

        /// <summary>
        /// Sorting order <li>0: ascending </li><li>1: descending </li>If orderByKey is passed in but orderByType is not, ascending order is used by default
        /// </summary>
        [JsonProperty("OrderByType")]
        public ulong? OrderByType{ get; set; }

        /// <summary>
        /// Node tag information list
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// VPC VIP list
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }


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
        }
    }
}

