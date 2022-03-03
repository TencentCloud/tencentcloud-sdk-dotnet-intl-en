/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class AssumeRoleWithSAMLRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded SAML assertion
        /// </summary>
        [JsonProperty("SAMLAssertion")]
        public string SAMLAssertion{ get; set; }

        /// <summary>
        /// Principal access description name
        /// </summary>
        [JsonProperty("PrincipalArn")]
        public string PrincipalArn{ get; set; }

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
        /// The validity period of the temporary credentials in seconds. Default value: 7,200s. Maximum value: 43,200s.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public ulong? DurationSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SAMLAssertion", this.SAMLAssertion);
            this.SetParamSimple(map, prefix + "PrincipalArn", this.PrincipalArn);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "RoleSessionName", this.RoleSessionName);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
        }
    }
}

