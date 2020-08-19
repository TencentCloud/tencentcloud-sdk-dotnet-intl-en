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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodePlayInfo2017 : AbstractModel
    {
        
        /// <summary>
        /// Playback address.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Transcoding specification ID. For more information, please see [Transcoding Parameter Template](https://intl.cloud.tencent.com/document/product/266/33478?from_cn_redirect=1#.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Sum of the average bitrate of a video stream and that of an audio stream in bps.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Maximum value of the height of a video stream in px.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Maximum value of the width of a video stream in px.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
        }
    }
}

