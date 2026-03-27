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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSLConfig : AbstractModel
    {
        
        /// <summary>
        /// SSL Encryption Status
        /// enable - Enabled
        /// disable - Disabled
        /// enable_doing - Enabling
        /// disable_doing - Disabling
        /// renew_doing - Updating
        /// wait_doing - Waiting to be executed during maintenance window
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// SSL Certificates Validity Period, Time Format YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("SSLValidityPeriod")]
        public string SSLValidityPeriod{ get; set; }

        /// <summary>
        /// SSL Certificates Validity: 0 - Invalid, 1 - Valid
        /// </summary>
        [JsonProperty("SSLValidity")]
        public ulong? SSLValidity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "SSLValidityPeriod", this.SSLValidityPeriod);
            this.SetParamSimple(map, prefix + "SSLValidity", this.SSLValidity);
        }
    }
}

