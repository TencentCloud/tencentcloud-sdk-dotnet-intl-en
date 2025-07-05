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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// Issuer.
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// Issued to.
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Certificate fingerprint.
        /// </summary>
        [JsonProperty("Fingerprint")]
        public string Fingerprint{ get; set; }

        /// <summary>
        /// Certificate valid period start time.
        /// </summary>
        [JsonProperty("ValidFrom")]
        public string ValidFrom{ get; set; }

        /// <summary>
        /// Certificate valid period end time.
        /// </summary>
        [JsonProperty("ValidTo")]
        public string ValidTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "Fingerprint", this.Fingerprint);
            this.SetParamSimple(map, prefix + "ValidFrom", this.ValidFrom);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
        }
    }
}

