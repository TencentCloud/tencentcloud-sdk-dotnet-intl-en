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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuUserInfoParams : AbstractModel
    {
        
        /// <summary>
        /// The user information.
        /// </summary>
        [JsonProperty("UserInfo")]
        public MixUserInfo UserInfo{ get; set; }

        /// <summary>
        /// Audio mix volume adjustment. value ranges from 0 to 100. 100 indicates the original uplink volume. the default value is 100 if left blank. a lower value results in a lower volume.
        /// Note: this parameter takes effect only when configured in the volume allowlist and is unavailable in other scenarios.
        /// </summary>
        [JsonProperty("SoundLevel")]
        public ulong? SoundLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "SoundLevel", this.SoundLevel);
        }
    }
}

