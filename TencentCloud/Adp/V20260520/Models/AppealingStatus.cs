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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppealingStatus : AbstractModel
    {
        
        /// <summary>
        /// Whether the avatar is under appeal
        /// </summary>
        [JsonProperty("AvatarInAppeal")]
        public bool? AvatarInAppeal{ get; set; }

        /// <summary>
        /// Is the fallback response included in the appeal?
        /// </summary>
        [JsonProperty("FallbackReplyInAppeal")]
        public bool? FallbackReplyInAppeal{ get; set; }

        /// <summary>
        /// Whether the welcome message is required in an appeal
        /// </summary>
        [JsonProperty("GreetingInAppeal")]
        public bool? GreetingInAppeal{ get; set; }

        /// <summary>
        /// Whether the application name is under appeal
        /// </summary>
        [JsonProperty("NameInAppeal")]
        public bool? NameInAppeal{ get; set; }

        /// <summary>
        /// Whether the role description is in the appeal
        /// </summary>
        [JsonProperty("RoleInAppeal")]
        public bool? RoleInAppeal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AvatarInAppeal", this.AvatarInAppeal);
            this.SetParamSimple(map, prefix + "FallbackReplyInAppeal", this.FallbackReplyInAppeal);
            this.SetParamSimple(map, prefix + "GreetingInAppeal", this.GreetingInAppeal);
            this.SetParamSimple(map, prefix + "NameInAppeal", this.NameInAppeal);
            this.SetParamSimple(map, prefix + "RoleInAppeal", this.RoleInAppeal);
        }
    }
}

