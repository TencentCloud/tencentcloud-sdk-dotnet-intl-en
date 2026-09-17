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

    public class PipSetting : AbstractModel
    {
        
        /// <summary>
        /// Audio selection: LIVE_SOURCE or AD_SOURCE
        /// </summary>
        [JsonProperty("AudioSelection")]
        public string AudioSelection{ get; set; }

        /// <summary>
        /// Live streaming source layout configuration
        /// </summary>
        [JsonProperty("LiveSourceLayout")]
        public SourceLayout LiveSourceLayout{ get; set; }

        /// <summary>
        /// Advertisement source layout configuration
        /// </summary>
        [JsonProperty("AdSourceLayout")]
        public SourceLayout AdSourceLayout{ get; set; }

        /// <summary>
        /// Background image URL, starting with http/https and ending in jpg/jpeg/png (only required for UPLOAD_CREATIVES)
        /// </summary>
        [JsonProperty("BackgroundImgUrl")]
        public string BackgroundImgUrl{ get; set; }

        /// <summary>
        /// Advertisement video URL, starting with http/https and ending in mp4 (only required for UPLOAD_CREATIVES)
        /// </summary>
        [JsonProperty("AdSourceUrl")]
        public string AdSourceUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioSelection", this.AudioSelection);
            this.SetParamObj(map, prefix + "LiveSourceLayout.", this.LiveSourceLayout);
            this.SetParamObj(map, prefix + "AdSourceLayout.", this.AdSourceLayout);
            this.SetParamSimple(map, prefix + "BackgroundImgUrl", this.BackgroundImgUrl);
            this.SetParamSimple(map, prefix + "AdSourceUrl", this.AdSourceUrl);
        }
    }
}

