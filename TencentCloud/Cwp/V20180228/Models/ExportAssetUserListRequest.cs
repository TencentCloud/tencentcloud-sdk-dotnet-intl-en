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

    public class ExportAssetUserListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query information of a specified QUUID host
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        ///   Filtering conditions.<li>Name - String - required: no - account name.</li> <li>Uid - uint64 - required: no - UID.</li> <li>Guid - uint64 - required: no - GUID.</li> <li>LoginTimeStart - String - required: no - start time, such as 2021-01-11.</li> <li>LoginTimeEnd - String - required: no - end time, such as 2021-01-11.</li> <li>LoginType - uint64 - required: no - 0 - login not allowed; 1 - only key-based login allowed; 2 - only password-based login allowed; 3 - both key-based and password-based login allowed (Linux only).</li> <li>OsType - String - required: no - Windows or Linux.</li> <li>Status - uint64 - required: no - account status: 0 - disabled; 1 - enabled.</li> <li>Type - uint64 - required: no - account type: 0: guest user; 1: standard user; 2: administrator user (Windows Only).</li> <li>IsDomain - uint64 - required: no - whether a domain account: 0: no; 1: yes (Windows only).</li> <li>IsRoot - uint64 - required: no - whether there is root permission: 0: no; 1: yes (Linux only).</li> <li>IsSudo - uint64 - required: no - whether there is sudo permission: 0: no; 1: yes (Linux only).</li> <li>IsSshLogin - uint64 - required: no - whether to use SSH login: 0: no; 1: yes (Linux only).</li> <li>ShellLoginStatus - uint64 - required: no - whether shell login allowed: 0: no; 1: yes (Linux only).</li> <li>PasswordStatus - uint64 - required: no - password status: 1: normal; 2: expiring soon; 3: expired; 4: locked (Linux only).</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Optional sorting method: [FirstTime|LoginTime|ChangePasswordTime|PasswordDuaTime]
        /// PasswordLockDays
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

