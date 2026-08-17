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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PasswordPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to enable the instance-level password complexity policy.</p><ul><li>true: Enable. ALL password changes (create/reset) must pass the complexity verification defined below.</li><li>false: Disable. No complexity filtering is performed.</li></ul><p>Default value: false</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>Minimum number of uppercase and lowercase letters.</p><ul><li>Value ranges from 1 to 16.</li><li>Default value: 1.</li></ul>
        /// </summary>
        [JsonProperty("MinLetterCount")]
        public long? MinLetterCount{ get; set; }

        /// <summary>
        /// <p>Minimum number of numeric characters.</p><ul><li>Value ranges from 1 to 16.</li><li>Default value: 1.</li></ul>
        /// </summary>
        [JsonProperty("MinDigitCount")]
        public long? MinDigitCount{ get; set; }

        /// <summary>
        /// <p>Minimum number of special characters.</p><ul><li>Value ranges from 1 to 16.</li><li>Default value: 1.</li></ul>
        /// </summary>
        [JsonProperty("MinSpecialCount")]
        public long? MinSpecialCount{ get; set; }

        /// <summary>
        /// <p>Minimum total length of the password (number of characters).</p><ul><li>Value ranges from 8 to 64.</li><li>Default value: 8.</li><li>Constraints and limitations: The minimum total length of the password must be at least the sum of three parameters: MinLetterCount, MinDigitCount, and MinSpecialCount.</li></ul>
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "MinLetterCount", this.MinLetterCount);
            this.SetParamSimple(map, prefix + "MinDigitCount", this.MinDigitCount);
            this.SetParamSimple(map, prefix + "MinSpecialCount", this.MinSpecialCount);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
        }
    }
}

