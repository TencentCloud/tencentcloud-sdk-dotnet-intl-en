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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMCPTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Token expiration time</p><p>Value range: [0, 2592000]</p><p>Unit: seconds</p><p>Default value: 86400</p><p>If this parameter is not specified, the default timeout is 1 day. The expiration time is the current time + the timeout period.</p>
        /// </summary>
        [JsonProperty("ExpireSeconds")]
        public long? ExpireSeconds{ get; set; }

        /// <summary>
        /// <p>Token name (comment)</p><p>Format: Only a combination of Chinese characters, English letters, digits, and hyphens (&quot;-&quot;) is supported.</p><p>Maximum length: 16 characters</p>
        /// </summary>
        [JsonProperty("TokenName")]
        public string TokenName{ get; set; }

        /// <summary>
        /// <p>User Id</p><p>Format: Only a combination of letters (A-Za-z), digits (0-9), and underscores (_) is supported.</p><p>This UserId is always used to operate cloud rendering concurrent resources. Maximum length: 64 characters</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireSeconds", this.ExpireSeconds);
            this.SetParamSimple(map, prefix + "TokenName", this.TokenName);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

