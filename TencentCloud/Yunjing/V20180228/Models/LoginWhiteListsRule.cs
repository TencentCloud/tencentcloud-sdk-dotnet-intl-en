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

    public class LoginWhiteListsRule : AbstractModel
    {
        
        /// <summary>
        /// Whitelisted location
        /// </summary>
        [JsonProperty("Places")]
        public Place[] Places{ get; set; }

        /// <summary>
        /// Whitelisted IPs (separated by commas). This parameter can be an IP range.
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// Whitelisted usernames (separated by commas)
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Whether this rule is applied to all servers under the current account
        /// </summary>
        [JsonProperty("IsGlobal")]
        public bool? IsGlobal{ get; set; }

        /// <summary>
        /// Server for which the whitelist takes effect
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Rule ID, used for rule updating
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Places.", this.Places);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

