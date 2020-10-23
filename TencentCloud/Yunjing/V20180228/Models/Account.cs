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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Account : AbstractModel
    {
        
        /// <summary>
        /// Unique ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// CWP agent `Uuid`
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Private IP of server.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Account group.
        /// </summary>
        [JsonProperty("Groups")]
        public string Groups{ get; set; }

        /// <summary>
        /// Account type.
        /// <li>ORDINARY: ordinary account</li>
        /// <li>SUPPER: super admin account</li>
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }

        /// <summary>
        /// Account creation time.
        /// </summary>
        [JsonProperty("AccountCreateTime")]
        public string AccountCreateTime{ get; set; }

        /// <summary>
        /// Account last login time.
        /// </summary>
        [JsonProperty("LastLoginTime")]
        public string LastLoginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Groups", this.Groups);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "AccountCreateTime", this.AccountCreateTime);
            this.SetParamSimple(map, prefix + "LastLoginTime", this.LastLoginTime);
        }
    }
}

