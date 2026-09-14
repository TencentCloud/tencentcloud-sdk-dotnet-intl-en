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
        /// Can only be used for HLS. Format support: ts and mp4.
        /// Only slice mode can be used. singlefile mode cannot be used.
        /// 
        /// - fairplay:
        /// Can only be used for HLS. The segment format can only be mp4.
        /// Slice mode or singlefile mode can be used.
        /// 
        /// - widevine:
        /// Can be used for HLS and DASH. The segment format can only be mp4.
        /// Output HLS: The slicing or singlefile mode can be used.
        /// Output DASH: can only be in singlefile mode
        /// 
        /// - playready:
        /// Can be used for HLS and DASH. The segment format can only be mp4.
        /// Output HLS: The slicing or singlefile mode can be used.
        /// Output DASH: can only be in singlefile mode
        /// 
        /// - widevine+fairplay,playready+fairplay,widevine+playready+fairplay:
        /// Can only be used for HLS. The segment format can only be mp4.
        /// Slice mode or singlefile mode can be used.
        /// 
        /// - widevine+playready:
        /// Applicable to HLS and MPEG-DASH. The segment format can only be mp4.
        /// For HLS format, you can use the slicing mode or singlefile mode.
        /// For MPEG-DASH, only singlefile mode can be used.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
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

