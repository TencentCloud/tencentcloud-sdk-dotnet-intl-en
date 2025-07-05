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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmAttributeResponse : AbstractModel
    {
        
        /// <summary>
        /// CWP deactivation alarm status:
        /// <li>OPEN: alarm enabled</li>
        /// <li>CLOSE: alarm disabled</li>
        /// </summary>
        [JsonProperty("Offline")]
        public string Offline{ get; set; }

        /// <summary>
        /// Trojan discovery alarm status:
        /// <li>OPEN: alarm enabled</li>
        /// <li>CLOSE: alarm disabled</li>
        /// </summary>
        [JsonProperty("Malware")]
        public string Malware{ get; set; }

        /// <summary>
        /// Unusual login location discovery alarm status:
        /// <li>OPEN: alarm enabled</li>
        /// <li>CLOSE: alarm disabled</li>
        /// </summary>
        [JsonProperty("NonlocalLogin")]
        public string NonlocalLogin{ get; set; }

        /// <summary>
        /// Brute force attack success alarm status:
        /// <li>OPEN: alarm enabled</li>
        /// <li>CLOSE: alarm disabled</li>
        /// </summary>
        [JsonProperty("CrackSuccess")]
        public string CrackSuccess{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offline", this.Offline);
            this.SetParamSimple(map, prefix + "Malware", this.Malware);
            this.SetParamSimple(map, prefix + "NonlocalLogin", this.NonlocalLogin);
            this.SetParamSimple(map, prefix + "CrackSuccess", this.CrackSuccess);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

