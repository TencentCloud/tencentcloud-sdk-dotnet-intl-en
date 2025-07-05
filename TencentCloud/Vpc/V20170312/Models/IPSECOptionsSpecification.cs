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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPSECOptionsSpecification : AbstractModel
    {
        
        /// <summary>
        /// Encryption algorithm. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, and `NULL`; default value: `AES-CBC-128`.
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// Authentication algorithm. Valid values: `MD5`, `SHA1` and `SHA-256`; default value: `SHA1`.
        /// </summary>
        [JsonProperty("IntegrityAlgorith")]
        [System.Obsolete]
        public string IntegrityAlgorith{ get; set; }

        /// <summary>
        /// IPsec SA lifetime (in sec). Value range: 180-604800
        /// </summary>
        [JsonProperty("IPSECSaLifetimeSeconds")]
        public ulong? IPSECSaLifetimeSeconds{ get; set; }

        /// <summary>
        /// PFS. Available value: 'NULL', 'DH-GROUP1', 'DH-GROUP2', 'DH-GROUP5', 'DH-GROUP14', and 'DH-GROUP24'. Default is NULL.
        /// </summary>
        [JsonProperty("PfsDhGroup")]
        public string PfsDhGroup{ get; set; }

        /// <summary>
        /// IPsec SA lifetime (in KB). Value range: 2560-604800
        /// </summary>
        [JsonProperty("IPSECSaLifetimeTraffic")]
        public ulong? IPSECSaLifetimeTraffic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamSimple(map, prefix + "IntegrityAlgorith", this.IntegrityAlgorith);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeSeconds", this.IPSECSaLifetimeSeconds);
            this.SetParamSimple(map, prefix + "PfsDhGroup", this.PfsDhGroup);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeTraffic", this.IPSECSaLifetimeTraffic);
        }
    }
}

