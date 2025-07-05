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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthenticationTypeE : AbstractModel
    {
        
        /// <summary>
        /// Key used for signature calculation, allowing 6 to 32 bytes of letters and digits.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Signature field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// ACL signature field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AclSignParam")]
        public string AclSignParam{ get; set; }

        /// <summary>
        /// Start time field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTimeParam")]
        public string StartTimeParam{ get; set; }

        /// <summary>
        /// Expiration time field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTimeParam")]
        public string ExpireTimeParam{ get; set; }

        /// <summary>
        /// Time format (dec)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "AclSignParam", this.AclSignParam);
            this.SetParamSimple(map, prefix + "StartTimeParam", this.StartTimeParam);
            this.SetParamSimple(map, prefix + "ExpireTimeParam", this.ExpireTimeParam);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

