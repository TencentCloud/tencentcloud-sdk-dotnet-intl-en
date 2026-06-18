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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KeySandboxCredential : AbstractModel
    {
        
        /// <summary>
        /// Credential ID
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// Credential name
        /// </summary>
        [JsonProperty("CredentialName")]
        public string CredentialName{ get; set; }

        /// <summary>
        /// Credential Type
        /// Enumeration value:
        /// access: normal Key (Key-Value pair)
        /// sts: STS temporary key credential
        /// </summary>
        [JsonProperty("CredentialType")]
        public string CredentialType{ get; set; }

        /// <summary>
        /// Effective machine scope
        /// </summary>
        [JsonProperty("CredentialEffectScope")]
        public CredentialEffectScope CredentialEffectScope{ get; set; }

        /// <summary>
        /// Creation time.
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamSimple(map, prefix + "CredentialName", this.CredentialName);
            this.SetParamSimple(map, prefix + "CredentialType", this.CredentialType);
            this.SetParamObj(map, prefix + "CredentialEffectScope.", this.CredentialEffectScope);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

