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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetDatabaseListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query information of a specified QUUID host
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>MachineName - String - required: no - host alias for filtering</li>
        /// <li>IP - String - required: no - host IP address for filtering</li>
        /// <li>InstanceID - String - required: no - host instance ID for filtering</li>
        /// <li>User- string - required: no - running user</li>
        /// <li>Port - Int - required: no - port</li>
        /// <li>Name - Int - required: no - database name
        /// 0: all
        /// 1:MySQL
        /// 2:Redis
        /// 3:Oracle
        /// 4:MongoDB
        /// 5:MemCache
        /// 6:PostgreSQL
        /// 7:HBase
        /// 8:DB2
        /// 9:Sybase
        /// 10:TiDB</li>
        /// <li>Proto - String - required: no - protocol: 1: TCP; 2: UDP; 3: unknown</li>
        /// <li>OsType - String - required: no - operating system: linux/windows</li>
        /// <li>Os - String required: no - operating system (value of DescribeMachineOsList)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting method: [FirstTime]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

