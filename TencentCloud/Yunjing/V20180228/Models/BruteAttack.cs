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

    public class BruteAttack : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Server IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Brute force attack event status
        /// <li>BRUTEATTACK_FAIL_ACCOUNT: brute force attack event - failure (the account exists)</li>
        /// <li>BRUTEATTACK_FAIL_NOACCOUNT: brute force attack event - failure (the account does not exist)</li>
        /// <li>BRUTEATTACK_SUCCESS: brute force attack event - success </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// City ID.
        /// </summary>
        [JsonProperty("City")]
        public ulong? City{ get; set; }

        /// <summary>
        /// Country/Region ID.
        /// </summary>
        [JsonProperty("Country")]
        public ulong? Country{ get; set; }

        /// <summary>
        /// Province/State ID.
        /// </summary>
        [JsonProperty("Province")]
        public ulong? Province{ get; set; }

        /// <summary>
        /// Source IP.
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// Number of attempts.
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Occurrence time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// CWP agent `UUID`.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Whether the server enables CWP Pro.
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// Whether the server is banned.
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// Server `UUID`
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
        }
    }
}

