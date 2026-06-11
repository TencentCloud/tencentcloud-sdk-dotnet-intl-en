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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventPatchInfo : AbstractModel
    {
        
        /// <summary>
        /// Patch name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Patch Number
        /// </summary>
        [JsonProperty("KbNo")]
        public string KbNo{ get; set; }

        /// <summary>
        /// Disclosure time
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// Number of affected hosts.
        /// </summary>
        [JsonProperty("EffectHostCount")]
        public ulong? EffectHostCount{ get; set; }

        /// <summary>
        /// Number of associated vulnerabilities
        /// </summary>
        [JsonProperty("RelateVulCount")]
        public ulong? RelateVulCount{ get; set; }

        /// <summary>
        /// Associated vulnerability ID array
        /// </summary>
        [JsonProperty("RelateVulList")]
        public string[] RelateVulList{ get; set; }

        /// <summary>
        /// Whether it is the latest disclosure [0: no | 1: yes], no by default
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 0 pending, 1 ignored, 3 fixed
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Prerequisite for installing the kb is generally other KBs, and there may be multiple, with KBs separated by ", "
        /// </summary>
        [JsonProperty("KbPreCondition")]
        public string KbPreCondition{ get; set; }

        /// <summary>
        /// Name of the windows product associated with the kb
        /// </summary>
        [JsonProperty("RelatedProduct")]
        public string RelatedProduct{ get; set; }

        /// <summary>
        /// Patch ID
        /// </summary>
        [JsonProperty("KbId")]
        public ulong? KbId{ get; set; }

        /// <summary>
        /// Related kb event id collection
        /// </summary>
        [JsonProperty("Ids")]
        public string Ids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KbNo", this.KbNo);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "EffectHostCount", this.EffectHostCount);
            this.SetParamSimple(map, prefix + "RelateVulCount", this.RelateVulCount);
            this.SetParamArraySimple(map, prefix + "RelateVulList.", this.RelateVulList);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "KbPreCondition", this.KbPreCondition);
            this.SetParamSimple(map, prefix + "RelatedProduct", this.RelatedProduct);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "Ids", this.Ids);
        }
    }
}

