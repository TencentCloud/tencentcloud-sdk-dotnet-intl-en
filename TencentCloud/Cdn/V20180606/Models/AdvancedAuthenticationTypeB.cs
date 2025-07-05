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

    public class AdvancedAuthenticationTypeB : AbstractModel
    {
        
        /// <summary>
        /// Alpha key name
        /// </summary>
        [JsonProperty("KeyAlpha")]
        public string KeyAlpha{ get; set; }

        /// <summary>
        /// Beta key name
        /// </summary>
        [JsonProperty("KeyBeta")]
        public string KeyBeta{ get; set; }

        /// <summary>
        /// Gamma key name
        /// </summary>
        [JsonProperty("KeyGamma")]
        public string KeyGamma{ get; set; }

        /// <summary>
        /// Signature field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// Time field name in the URI string, starting with a letter, and consisting of letters, digits, and underscores.
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// Expiration time in seconds
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// Time format. Valid values: dec (decimal), hex (hexadecimal).
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// Status code returned when the authentication failed
        /// </summary>
        [JsonProperty("FailCode")]
        public long? FailCode{ get; set; }

        /// <summary>
        /// Status code returned when the URL expired
        /// </summary>
        [JsonProperty("ExpireCode")]
        public long? ExpireCode{ get; set; }

        /// <summary>
        /// List of URLs to be authenticated
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyAlpha", this.KeyAlpha);
            this.SetParamSimple(map, prefix + "KeyBeta", this.KeyBeta);
            this.SetParamSimple(map, prefix + "KeyGamma", this.KeyGamma);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
            this.SetParamSimple(map, prefix + "ExpireCode", this.ExpireCode);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

