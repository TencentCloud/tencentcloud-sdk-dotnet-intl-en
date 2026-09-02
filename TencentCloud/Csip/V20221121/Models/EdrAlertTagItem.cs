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

    public class EdrAlertTagItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Alarm ID</p>
        /// </summary>
        [JsonProperty("AlertId")]
        public string AlertId{ get; set; }

        /// <summary>
        /// <p>Tencent Cloud tag</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public TagItem[] CloudTags{ get; set; }

        /// <summary>
        /// <p>Security Center tag</p>
        /// </summary>
        [JsonProperty("CSIPTags")]
        public CSIPTag[] CSIPTags{ get; set; }

        /// <summary>
        /// <p>Intelligence tag.</p>
        /// </summary>
        [JsonProperty("ThreatTags")]
        public string[] ThreatTags{ get; set; }

        /// <summary>
        /// <p>IP intelligence information</p>
        /// </summary>
        [JsonProperty("IPIntel")]
        public IPIntelInfo IPIntel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlertId", this.AlertId);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamArrayObj(map, prefix + "CSIPTags.", this.CSIPTags);
            this.SetParamArraySimple(map, prefix + "ThreatTags.", this.ThreatTags);
            this.SetParamObj(map, prefix + "IPIntel.", this.IPIntel);
        }
    }
}

