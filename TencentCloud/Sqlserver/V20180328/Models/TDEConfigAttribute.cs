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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TDEConfigAttribute : AbstractModel
    {
        
        /// <summary>
        /// TDE status. Valid values: `enable` (enabled), `disable` (disabled).
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// Certificate u200downership. Valid values: `self` (u200dcertificate of the this account), `others` (u200dcertificate of the other account), `none` (no certificate).
        /// </summary>
        [JsonProperty("CertificateAttribution")]
        public string CertificateAttribution{ get; set; }

        /// <summary>
        /// ID of the u200dother referenced root account when enabling TDE
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuoteUin")]
        public string QuoteUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "CertificateAttribution", this.CertificateAttribution);
            this.SetParamSimple(map, prefix + "QuoteUin", this.QuoteUin);
        }
    }
}

