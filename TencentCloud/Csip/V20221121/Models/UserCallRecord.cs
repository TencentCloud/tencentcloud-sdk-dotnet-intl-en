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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserCallRecord : AbstractModel
    {
        
        /// <summary>
        /// Source IP of the call.
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// Invocation type.
        /// 0: console invocation.
        /// 1:API
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// Number of calls.
        /// </summary>
        [JsonProperty("CallCount")]
        public long? CallCount{ get; set; }

        /// <summary>
        /// Error code.
        /// 0: Successful
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// First time call time.
        /// </summary>
        [JsonProperty("FirstCallTime")]
        public string FirstCallTime{ get; set; }

        /// <summary>
        /// Call time.
        /// </summary>
        [JsonProperty("LastCallTime")]
        public string LastCallTime{ get; set; }

        /// <summary>
        /// Source IP of the call remark.
        /// </summary>
        [JsonProperty("SourceIPRemark")]
        public string SourceIPRemark{ get; set; }

        /// <summary>
        /// Source IP region of the call.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// User/Role name.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Aggregate date.
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// Carrier.
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "FirstCallTime", this.FirstCallTime);
            this.SetParamSimple(map, prefix + "LastCallTime", this.LastCallTime);
            this.SetParamSimple(map, prefix + "SourceIPRemark", this.SourceIPRemark);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
        }
    }
}

