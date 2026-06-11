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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ThirdPartyDrmInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Encryption type:</p><ul><li>FairPlay: Can only be used for HLS. The slice format can only be mp4.</li><li>Widevine: Can be used for HLS and DASH. The slice format can only be mp4.</li><li>PlayReady: Can be used for HLS and DASH. The slice format can only be mp4.</li><li>Widevine+FairPlay, PlayReady+FairPlay, Widevine PlayReady FairPlay composite: Can only be used for HLS. The slice format can only be mp4.</li><li>Widevine PlayReady composite: Can be used for HLS and MPEG-DASH. The slice format can only be mp4.</li></ul>
        /// </summary>
        [JsonProperty("DrmTypes")]
        public string[] DrmTypes{ get; set; }

        /// <summary>
        /// <p>External DRM vendor information.</p>
        /// </summary>
        [JsonProperty("SPEKEDrm")]
        public SPEKEDrm SPEKEDrm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DrmTypes.", this.DrmTypes);
            this.SetParamObj(map, prefix + "SPEKEDrm.", this.SPEKEDrm);
        }
    }
}

