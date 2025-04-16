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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIConf : AbstractModel
    {
        
        /// <summary>
        /// Advertising Decision Server URL (ADS).
        /// </summary>
        [JsonProperty("AdsUrl")]
        public string AdsUrl{ get; set; }

        /// <summary>
        /// Parameter configuration.
        /// </summary>
        [JsonProperty("ConfigAliases")]
        public ConfigAliasesInfo[] ConfigAliases{ get; set; }

        /// <summary>
        /// Whether to enable transparent transmission of advertising tags.
        /// </summary>
        [JsonProperty("AdMarkerPassthrough")]
        public bool? AdMarkerPassthrough{ get; set; }

        /// <summary>
        /// How to process tags in advertisements, optional values: [1,2] 
        /// 1: Process all SCTE-35 type tags - all (default) 
        /// 2: SCTE-35enhanced, parse some types.
        /// </summary>
        [JsonProperty("SCTE35AdType")]
        public ulong? SCTE35AdType{ get; set; }

        /// <summary>
        /// Default advertising url.
        /// </summary>
        [JsonProperty("SlateAd")]
        public string SlateAd{ get; set; }

        /// <summary>
        /// Maximum unfilled duration, unit: seconds.
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// Whether to enable mpd location, true corresponds to enable, false corresponds to disable.
        /// </summary>
        [JsonProperty("DashMPDLocation")]
        public bool? DashMPDLocation{ get; set; }

        /// <summary>
        /// The type of tag that is regarded as an advertisement, optional values: [1,8]
        /// 1. Splice insert 
        /// 2. Provider advertisement 
        /// 3. Distributor advertisement 
        /// 4. Provider placement opportunity 
        /// 5. Distributor placement opportunity 
        /// 6. Break 
        /// 7. Provider overlay placement opportunity 
        /// 8. Distributor overlay placement opportunity.
        /// </summary>
        [JsonProperty("AdTriggers")]
        public ulong?[] AdTriggers{ get; set; }

        /// <summary>
        /// The type of distribution restriction that is considered an advertisement, optional values: [1,4]
        /// 1:None 
        /// 2:Restricted (default) 
        /// 3:Unrestricted 
        /// 4.Both.
        /// </summary>
        [JsonProperty("DeliveryRestrictions")]
        public ulong? DeliveryRestrictions{ get; set; }

        /// <summary>
        /// Source CDN prefix, needs to start with http:// or https://
        /// </summary>
        [JsonProperty("SourceCDNPrefix")]
        public string SourceCDNPrefix{ get; set; }

        /// <summary>
        /// Advertising CDN prefix needs to start with http:// or https://
        /// </summary>
        [JsonProperty("AdCDNPrefix")]
        public string AdCDNPrefix{ get; set; }

        /// <summary>
        /// Pre-roll ad decision service address.
        /// </summary>
        [JsonProperty("PreRollAdsUrl")]
        public string PreRollAdsUrl{ get; set; }

        /// <summary>
        /// The maximum allowed duration of pre-roll ads, (0, 3600].
        /// </summary>
        [JsonProperty("PreRollMaxAllowedDuration")]
        public long? PreRollMaxAllowedDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdsUrl", this.AdsUrl);
            this.SetParamArrayObj(map, prefix + "ConfigAliases.", this.ConfigAliases);
            this.SetParamSimple(map, prefix + "AdMarkerPassthrough", this.AdMarkerPassthrough);
            this.SetParamSimple(map, prefix + "SCTE35AdType", this.SCTE35AdType);
            this.SetParamSimple(map, prefix + "SlateAd", this.SlateAd);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "DashMPDLocation", this.DashMPDLocation);
            this.SetParamArraySimple(map, prefix + "AdTriggers.", this.AdTriggers);
            this.SetParamSimple(map, prefix + "DeliveryRestrictions", this.DeliveryRestrictions);
            this.SetParamSimple(map, prefix + "SourceCDNPrefix", this.SourceCDNPrefix);
            this.SetParamSimple(map, prefix + "AdCDNPrefix", this.AdCDNPrefix);
            this.SetParamSimple(map, prefix + "PreRollAdsUrl", this.PreRollAdsUrl);
            this.SetParamSimple(map, prefix + "PreRollMaxAllowedDuration", this.PreRollMaxAllowedDuration);
        }
    }
}

