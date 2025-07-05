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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OffsiteFlag : AbstractModel
    {
        
        /// <summary>
        /// Verification flag
        /// </summary>
        [JsonProperty("VerifyFlag")]
        public ulong? VerifyFlag{ get; set; }

        /// <summary>
        /// Phone notification
        /// </summary>
        [JsonProperty("NotifyPhone")]
        public ulong? NotifyPhone{ get; set; }

        /// <summary>
        /// Email notification
        /// </summary>
        [JsonProperty("NotifyEmail")]
        public long? NotifyEmail{ get; set; }

        /// <summary>
        /// WeChat notification
        /// </summary>
        [JsonProperty("NotifyWechat")]
        public ulong? NotifyWechat{ get; set; }

        /// <summary>
        /// Alert
        /// </summary>
        [JsonProperty("Tips")]
        public ulong? Tips{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyFlag", this.VerifyFlag);
            this.SetParamSimple(map, prefix + "NotifyPhone", this.NotifyPhone);
            this.SetParamSimple(map, prefix + "NotifyEmail", this.NotifyEmail);
            this.SetParamSimple(map, prefix + "NotifyWechat", this.NotifyWechat);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
        }
    }
}

