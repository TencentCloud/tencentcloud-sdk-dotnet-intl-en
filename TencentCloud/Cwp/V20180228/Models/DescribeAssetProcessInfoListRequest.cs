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

    public class DescribeAssetProcessInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query the information on the host with the specified QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filtering criteria
        /// <li>IP - String - required: no - host IP address</li>
        /// <li>MachineName - String - required: no - host name</li>
        /// <li>InstanceID - string - required: no - instance ID</li>
        /// <li>Name - String - required: no - process name</li>
        /// <li>User - String - required: no - process user</li>
        /// <li>Group - String - required: no - process user group</li>
        /// <li>Pid - uint64 - required: no - process ID</li>
        /// <li>Ppid - uint64 - required: no - parent process ID</li>
        /// <li>OsType - uint64 - required: no - Windows/Linux</li>
        /// <li>Status - string - required: no - process status:
        /// 1: R, runnable
        /// 2: S, interruptible
        /// 3: D, uninterruptible
        /// 4: T, stopped or traced
        /// 5: Z, zombie
        /// 6: X, to be terminated</li>
        /// <li>RunTimeStart - String - required: no - running start time</li>
        /// <li>RunTimeEnd - String - required: no - running end time</li>
        /// <li>InstallByPackage - uint64 - required: no - whether to install by package: 0: no; 1: yes</li>
        /// <li>Os - String required: no - operating system (value of DescribeMachineOsList)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of items to be returned. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting method: [FirstTime|StartTime]
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
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

