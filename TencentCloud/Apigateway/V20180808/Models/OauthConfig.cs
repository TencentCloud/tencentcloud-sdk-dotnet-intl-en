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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OauthConfig : AbstractModel
    {
        
        /// <summary>
        /// Public key for user token verification.
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// Token delivery location.
        /// </summary>
        [JsonProperty("TokenLocation")]
        public string TokenLocation{ get; set; }

        /// <summary>
        /// Redirect address, which is used to guide user logins.
        /// </summary>
        [JsonProperty("LoginRedirectUrl")]
        public string LoginRedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "TokenLocation", this.TokenLocation);
            this.SetParamSimple(map, prefix + "LoginRedirectUrl", this.LoginRedirectUrl);
        }
    }
}

