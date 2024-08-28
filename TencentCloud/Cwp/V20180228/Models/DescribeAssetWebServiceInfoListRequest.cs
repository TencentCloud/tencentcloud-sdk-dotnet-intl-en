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

    public class DescribeAssetWebServiceInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query the information on the host with the specified QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>User - string - required: no - running user</li>
        /// <li>Name - string - required: no - Web service name:</li>
        /// 1:Tomcat
        /// 2:Apache
        /// 3:Nginx
        /// 4:WebLogic
        /// 5:Websphere
        /// 6:JBoss
        /// 7:WildFly
        /// 8:Jetty
        /// 9:IHS
        /// 10:Tengine</li>
        /// <li>OsType - string - required: no - Windows/Linux</li>
        /// <li>Os -String required: no - operating system (the value of DescribeMachineOsList API)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// Offset, which is 0 by default.
        /// <li>IpOrAlias - String - required: no - filter by host IP or alias</li>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of items to be returned. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Optional sorting method: [FirstTime|ProcessCount]
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

