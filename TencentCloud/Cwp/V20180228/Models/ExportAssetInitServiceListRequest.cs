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

    public class ExportAssetInitServiceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Server UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Server QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Name- string - required: no - package name</li>
        /// <li>User- string - required: no - user</li>
        /// <li>Status- string - required: no - default enabling status: 0 - unenabled; 1 - enabled (Linux only)</li>
        /// <li>Type- string - required: no - type: type (Windows only)
        /// 1: Encoder
        /// 2: IE plugin
        /// 3: Network provider
        /// 4: Mirror hijacking
        /// 5: LSA provider
        /// 6:KnownDLLs
        /// 7: Start execution
        /// 8:WMI
        /// 9: Scheduled task
        /// 10: Winsock provider
        /// 11: Printing monitor
        /// 12: Resource manager
        /// 13: Driver service
        /// 14: Log-in </li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

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
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

