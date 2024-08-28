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

    public class ExportAssetProcessInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query information of a specified QUUID host
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Name - String - whether required: no - process name</li>
        /// <li>User - String - whether required: no - Process user</li>
        /// <li>Group - String - whether required: no - Process user group</li>
        /// <li>Pid - uint64 - whether required: no - process ID</li>
        /// <li>Ppid - uint64 - whether required: no - parent process ID</li>
        /// <li>OsType - uint64 - whether required: no - windows/Linux</li>
        /// <li>Status - string - whether required: no - process status:
        /// 0: all
        /// 1: R executable
        /// 2: S interruptible
        /// 3: Uninterruptible</li>
        /// <li>RunTimeStart - String - whether required: no - start time of running</li>
        /// <li>RunTimeEnd - String - whether required: no - end time of running</li>
        /// <li>InstallByPackage - uint64 - whether required: no - whether to install via a package: 0 - no; 1 - yes</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

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
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

