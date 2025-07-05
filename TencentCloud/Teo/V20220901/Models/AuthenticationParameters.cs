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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticationParameters : AbstractModel
    {
        
        /// <summary>
        /// Authentication type. valid values:.
        /// 
        /// <Li>TypeA: authentication method a type, for specific meaning please refer to [authentication method a](https://intl.cloud.tencent.com/document/product/1552/109329?from_cn_redirect=1);</li>.
        /// <Li>TypeB: authentication method b type, for specific meaning please refer to [authentication method b](https://intl.cloud.tencent.com/document/product/1552/109330?from_cn_redirect=1);</li>.
        /// <Li>TypeC: authentication method c type, for specific meaning please refer to [authentication method c](https://intl.cloud.tencent.com/document/product/1552/109331?from_cn_redirect=1);</li>.
        /// <Li>TypeD: authentication method d type, for specific meaning please refer to [authentication method d](https://intl.cloud.tencent.com/document/product/1552/109332?from_cn_redirect=1);</li>.
        /// <Li>TypeVOD: authentication method v type, for specific meaning please refer to [authentication method v](https://intl.cloud.tencent.com/document/product/1552/109333?from_cn_redirect=1).</li>.
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// The primary authentication key consists of 6–40 uppercase and lowercase english letters or digits, and cannot contain " and $.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Validity period of the authentication url, in seconds, value range: 1–630720000. used to determine if the client access request has expired:.
        /// <Li>If the current time exceeds "timestamp + validity period", it is an expired request, and a 403 is returned directly.</li>.
        /// <Li>If the current time does not exceed "timestamp + validity period", the request is not expired, and the md5 string is further validated.</li> note: when authtype is one of typea, typeb, typec, or typed, this field is required.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// The backup authentication key consists of 6–40 uppercase and lowercase english letters or digits, and cannot contain " and $.
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }

        /// <summary>
        /// Authentication parameters name. the node will validate the value corresponding to this parameter name. consists of 1-100 uppercase and lowercase letters, numbers, or underscores.<br>note: this field is required when authtype is either typea or typed.
        /// </summary>
        [JsonProperty("AuthParam")]
        public string AuthParam{ get; set; }

        /// <summary>
        /// Authentication timestamp. it cannot be the same as the value of the authparam field.<br>note: this field is required when authtype is typed.
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// Authentication time format. values:.
        /// <Li>Dec: decimal;</li>.
        /// <Li>Hex: hexadecimal.</li>note: this field is required when authtype is typed. the default is hex.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
            this.SetParamSimple(map, prefix + "AuthParam", this.AuthParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

