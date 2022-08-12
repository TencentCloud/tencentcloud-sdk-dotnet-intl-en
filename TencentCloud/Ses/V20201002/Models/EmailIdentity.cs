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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmailIdentity : AbstractModel
    {
        
        /// <summary>
        /// Sender domain.
        /// </summary>
        [JsonProperty("IdentityName")]
        public string IdentityName{ get; set; }

        /// <summary>
        /// Verification type. The value is fixed to `DOMAIN`.
        /// </summary>
        [JsonProperty("IdentityType")]
        public string IdentityType{ get; set; }

        /// <summary>
        /// Verification passed or not.
        /// </summary>
        [JsonProperty("SendingEnabled")]
        public bool? SendingEnabled{ get; set; }

        /// <summary>
        /// Current reputation level
        /// </summary>
        [JsonProperty("CurrentReputationLevel")]
        public ulong? CurrentReputationLevel{ get; set; }

        /// <summary>
        /// Maximum number of messages sent per day
        /// </summary>
        [JsonProperty("DailyQuota")]
        public ulong? DailyQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityName", this.IdentityName);
            this.SetParamSimple(map, prefix + "IdentityType", this.IdentityType);
            this.SetParamSimple(map, prefix + "SendingEnabled", this.SendingEnabled);
            this.SetParamSimple(map, prefix + "CurrentReputationLevel", this.CurrentReputationLevel);
            this.SetParamSimple(map, prefix + "DailyQuota", this.DailyQuota);
        }
    }
}

