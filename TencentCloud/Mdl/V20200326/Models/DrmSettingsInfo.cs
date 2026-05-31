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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrmSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether DRM encryption is enabled. Option: CLOSE/OPEN. Default: CLOSE.
        /// Currently only support HLS/DASH/HLS_ARCHIVE/DASH_ARCHIVE/HLS_MEDIAPACKAGE/DASH_MEDIAPACKAGE.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Optional [CustomDRMKeys|SDMCDRM], defaults to CustomDRMKeys.
        /// CustomDRMKeys refers to the custom encryption key.
        /// SDMCDRM refers to the DRM key management system using SMDC.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Scheme is CustomDRMKeys, required, filled in by the user.
        /// Scheme is SDMCDRM, optional, defaults to ChannelId. The format supports digits, upper- and lower-case letters, hyphens, and underscores, with a length of [1, 36].
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// Required when Scheme is CustomDRMKeys. The content is the key customized by users.
        /// </summary>
        [JsonProperty("Keys")]
        public DrmKey[] Keys{ get; set; }

        /// <summary>
        /// SDMC key configuration information, used when Scheme is SDMCDRM.
        /// </summary>
        [JsonProperty("SDMCSettings")]
        public SDMCSettingsInfo SDMCSettings{ get; set; }

        /// <summary>
        /// Optional type:
        /// `FAIRPLAY` `WIDEVINE` `PLAYREADY` `AES128`
        /// HLS-TS supports `FAIRPLAY` and `AES128`.
        /// HLS-FMP4 supports `FAIRPLAY`, `WIDEVINE`, `PLAYREADY`, `AES128`, and permutation and combination of two or three from `FAIRPLAY`, `WIDEVINE`, `PLAYREADY` (use commas to concatenate, such as "FAIRPLAY,WIDEVINE,PLAYREADY").
        /// DASH supports `WIDEVINE`, `PLAYREADY`, and the permutation and combination of `PLAYREADY` and `WIDEVINE` (use commas to concatenate, such as "PLAYREADY,WIDEVINE").
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamObj(map, prefix + "SDMCSettings.", this.SDMCSettings);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
        }
    }
}

