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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Inviter : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the inviter</p>
        /// </summary>
        [JsonProperty("InviterUserId")]
        public string InviterUserId{ get; set; }

        /// <summary>
        /// <p>The phone number of the inviter</p><p>Parameter format: Complies with the E.164 standard format, which includes "+", region code, and number.</p>
        /// </summary>
        [JsonProperty("InviterPhone")]
        public string InviterPhone{ get; set; }

        /// <summary>
        /// <p>The code that the inviter sent to the user</p>
        /// </summary>
        [JsonProperty("InviteCode")]
        public string InviteCode{ get; set; }

        /// <summary>
        /// <p>The channel that inviter used to invite the user</p>
        /// </summary>
        [JsonProperty("InviteChannel")]
        public string InviteChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InviterUserId", this.InviterUserId);
            this.SetParamSimple(map, prefix + "InviterPhone", this.InviterPhone);
            this.SetParamSimple(map, prefix + "InviteCode", this.InviteCode);
            this.SetParamSimple(map, prefix + "InviteChannel", this.InviteChannel);
        }
    }
}

