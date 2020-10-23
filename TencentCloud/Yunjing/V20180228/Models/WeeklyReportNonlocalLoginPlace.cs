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

    public class WeeklyReportNonlocalLoginPlace : AbstractModel
    {
        
        /// <summary>
        /// Server IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Source IP.
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

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
        /// City ID.
        /// </summary>
        [JsonProperty("City")]
        public ulong? City{ get; set; }

        /// <summary>
        /// Login time.
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
        }
    }
}

