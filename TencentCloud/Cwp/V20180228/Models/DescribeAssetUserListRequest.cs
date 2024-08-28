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

    public class DescribeAssetUserListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query the information on the host with the specified QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>IP - String - required: no - host IP address</li>
        /// <li>MachineName - String - required: no - host name</li>
        /// <li>InstanceID - string - required: no - instance ID<li>
        /// <li>Name - String - required: no - account name (fuzzy match)</li>
        /// <li>NameStrict - String - required: no - account name (strict match)</li>
        /// <li>Uid - uint64 - required: no - UID</li>
        /// <li>Guid - uint64 - required: no - GUID</li>
        /// <li>LoginTimeStart - String - required: no - start time, such as 2021-01-11</li>
        /// <li>LoginTimeEnd - String - required: no - end time, such as 2021-01-11</li>
        /// <li>LoginType - uint64 - required: no - 0 - not allowed to log in; 1 - only key-based log-in allowed; 2 - only password-based log-in allowed; 3 - both key-based and password-based log-in allowed (Linux only)</li>
        /// <li>OsType - String - required: no - Windows or Linux</li>
        /// <li>Status - uint64 - required: no - account status: 0 - disabled; 1 - enabled</li>
        /// <li>UserType - uint64 - required: no - account type: 0 - guest user; 1 - standard user; 2 - administrator user (Windows Only)</li>
        /// <li>IsDomain - uint64 - required: no - whether a domain account: 0 - no; 1 - yes (Windows only)</li>
        /// <li>IsRoot - uint64 - required: no - whether there is root permission: 0 - no; 1 - yes (Linux only)</li>
        /// <li>IsSudo - uint64 - required: no - whether there is sudo permission: 0 - no; 1 - yes (Linux only)</li>
        /// <li>IsSshLogin - uint64 - required: no - whether to use SSH log-in: 0 - no; 1 - yes (Linux only)</li>
        /// <li>ShellLoginStatus - uint64 - required: no - whether to use Shell log-in: 0 - no; 1 - yes (Linux only)</li>
        /// <li>PasswordStatus - uint64 - required: no - password status: 1 - normal; 2 - expiring soon; 3 - expired; 4 - locked (Linux only)</li>
        /// <li>Os -String required: no - operating system (the value of DescribeMachineOsList API)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of items to be returned. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset, which is 0 by default.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Optional sorting method: [FirstTime|LoginTime|PasswordChangeTime|PasswordDuaTime|PasswordLockDays]
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

