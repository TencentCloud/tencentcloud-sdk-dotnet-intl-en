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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportAssetDatabaseListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filtering criteria
        /// <li>User- string - required: no - running user</li>
        /// <li>Ip - String - required: no - bound IP address</li>
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
        /// <li>OsType - String - required: no - operating system: Linux/Windows</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// Query the information on the host with the specified QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Sorting order: asc for ascending or desc for descending
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
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

