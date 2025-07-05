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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssumeRoleWithWebIdentityRequest : AbstractModel
    {
        
        /// <summary>
        /// Identity provider name
        /// </summary>
        [JsonProperty("ProviderId")]
        public string ProviderId{ get; set; }

        /// <summary>
        /// OIDC token issued by the IdP
        /// </summary>
        [JsonProperty("WebIdentityToken")]
        public string WebIdentityToken{ get; set; }

        /// <summary>
        /// Role access description name
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// Session name
        /// </summary>
        [JsonProperty("RoleSessionName")]
        public string RoleSessionName{ get; set; }

        /// <summary>
        /// The validity period of the temporary credential in seconds. Default value: 7,200s. Maximum value: 43,200s.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public long? DurationSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProviderId", this.ProviderId);
            this.SetParamSimple(map, prefix + "WebIdentityToken", this.WebIdentityToken);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "RoleSessionName", this.RoleSessionName);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
        }
    }
}

