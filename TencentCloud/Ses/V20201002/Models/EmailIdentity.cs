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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmailIdentity : AbstractModel
    {
        
        /// <summary>
        /// <p>Sender domain name</p>
        /// </summary>
        [JsonProperty("IdentityName")]
        public string IdentityName{ get; set; }

        /// <summary>
        /// <p>Validation type, fixed as DOMAIN</p>
        /// </summary>
        [JsonProperty("IdentityType")]
        public string IdentityType{ get; set; }

        /// <summary>
        /// <p>Whether verified</p>
        /// </summary>
        [JsonProperty("SendingEnabled")]
        public bool? SendingEnabled{ get; set; }

        /// <summary>
        /// <p>Current reputation level</p>
        /// </summary>
        [JsonProperty("CurrentReputationLevel")]
        public ulong? CurrentReputationLevel{ get; set; }

        /// <summary>
        /// <p>Maximum message sending capacity of the current day</p>
        /// </summary>
        [JsonProperty("DailyQuota")]
        public ulong? DailyQuota{ get; set; }

        /// <summary>
        /// <p>Independent ip for domain configuration</p>
        /// </summary>
        [JsonProperty("SendIp")]
        public string[] SendIp{ get; set; }

        /// <summary>
        /// <p>tag</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagList[] TagList{ get; set; }

        /// <summary>
        /// <p>dkim bit number</p><p>Enumeration value:</p><ul><li>0: 1024</li><li>1: 2048</li><li>2: Dual signature</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("DKIMOption")]
        public ulong? DKIMOption{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "SendIp.", this.SendIp);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "DKIMOption", this.DKIMOption);
        }
    }
}

