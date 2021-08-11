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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginActionFlagIntl : AbstractModel
    {
        
        /// <summary>
        /// Mobile number
        /// </summary>
        [JsonProperty("Phone")]
        public ulong? Phone{ get; set; }

        /// <summary>
        /// Hard token
        /// </summary>
        [JsonProperty("Token")]
        public ulong? Token{ get; set; }

        /// <summary>
        /// Soft token
        /// </summary>
        [JsonProperty("Stoken")]
        public ulong? Stoken{ get; set; }

        /// <summary>
        /// WeChat
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// Custom
        /// </summary>
        [JsonProperty("Custom")]
        public ulong? Custom{ get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("Mail")]
        public ulong? Mail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Stoken", this.Stoken);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Custom", this.Custom);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
        }
    }
}
