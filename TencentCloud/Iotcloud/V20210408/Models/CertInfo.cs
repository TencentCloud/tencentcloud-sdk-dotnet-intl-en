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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertInfo : AbstractModel
    {
        
        /// <summary>
        /// Certificate name
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// Hex sequence number of a certificate
        /// </summary>
        [JsonProperty("CertSN")]
        public string CertSN{ get; set; }

        /// <summary>
        /// Certificate issuer
        /// </summary>
        [JsonProperty("IssuerName")]
        public string IssuerName{ get; set; }

        /// <summary>
        /// Certificate subject
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Certificate creation time (timestamp in milliseconds)
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Certificate effective time (timestamp in milliseconds)
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public ulong? EffectiveTime{ get; set; }

        /// <summary>
        /// Certificate expiration time (timestamp in milliseconds)
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// X.509 certificate content
        /// </summary>
        [JsonProperty("CertText")]
        public string CertText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertSN", this.CertSN);
            this.SetParamSimple(map, prefix + "IssuerName", this.IssuerName);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CertText", this.CertText);
        }
    }
}

