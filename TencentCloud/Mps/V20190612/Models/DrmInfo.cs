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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrmInfo : AbstractModel
    {
        
        /// <summary>
        /// Encryption type.
        /// 
        /// - simpleaes
        /// Can only be used for HLS. format support: ts and mp4.
        /// Only can be used in slice mode. cannot be used in singlefile mode.
        /// 
        /// - fairplay:
        /// Can only be used for HLS. the segment format can only be mp4.
        /// Supports slice mode or singlefile mode.
        /// 
        /// - widevine:
        /// Can be used for HLS and DASH. the slice format can only be mp4.
        /// Output HLS: specifies the slicing or singlefile mode can be used.
        /// OutputOutput DASH]: can only be in singlefile mode.
        /// 
        /// - playready:
        /// Can be used for HLS and DASH. the slice format can only be mp4.
        /// Output HLS: specifies the slicing or singlefile mode can be used.
        /// Output DASH: can only be in singlefile mode.
        /// 
        /// - widevine+fairplay,playready+fairplay,widevine+playready+fairplay:
        /// Can only be used for HLS. valid values: mp4.
        /// Supports slice mode or single file mode.
        /// 
        /// - widevine+playready:
        /// Applicable to HLS and MPEG-DASH. the format can only be mp4.
        /// HLS format can use slice mode or single file mode.
        /// Specifies that only singlefile mode can be used for MPEG-DASH.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The AES-128 encryption details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SimpleAesDrm")]
        public SimpleAesDrm SimpleAesDrm{ get; set; }

        /// <summary>
        /// Information about FairPlay, WideVine, and PlayReady encryption.
        /// </summary>
        [JsonProperty("SpekeDrm")]
        public SpekeDrm SpekeDrm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "SimpleAesDrm.", this.SimpleAesDrm);
            this.SetParamObj(map, prefix + "SpekeDrm.", this.SpekeDrm);
        }
    }
}

