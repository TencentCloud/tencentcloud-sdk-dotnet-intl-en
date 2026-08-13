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

    public class FissionTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Video output duration</p><p>Range: [1, 15]</p><p>Unit: seconds</p><p>Default value: 15</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// <p>Model gearbox</p><p>Enumeration value:</p><ul><li>standard: Standard version</li><li>flagship: Flagship edition</li></ul>
        /// </summary>
        [JsonProperty("ModelTier")]
        public string ModelTier{ get; set; }

        /// <summary>
        /// <p>Video image ratio</p><p>Enumeration values:</p><ul><li>9:16: 9:16</li><li>16:9: 16:9</li><li>1:1: -1:1</li><li>3:4: 3:4</li><li>4:3: 4:3</li></ul>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>Output resolution</p><p>Enumeration values:</p><ul><li>720p: 720p</li><li>1080p: 1080p</li><li>2k: 2k</li><li>4k: 4k</li></ul>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>Target market</p><p>Enumeration values:</p><ul><li>north_america: North America</li><li>europe: Europe</li><li>china: China</li><li>japan: Japan</li><li>korea: South Korea</li><li>southeast_asia: Southeast Asia</li><li>brazil: Brazil</li><li>global: Global</li><li>other: Other</li></ul><p>Impacts the default model ethnicity and localized style. When CustomModel is not specified, the ethnicity is automatically determined by the market.</p>
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// <p>Voiceover/subtitle language</p><p>Enumeration value:</p><ul><li>english: English</li><li>chinese: Chinese</li><li>japanese: Japanese</li><li>korean: Korean</li><li>spanish: Spanish</li><li>portuguese: Portuguese</li><li>music_only: Music only, no voiceover</li></ul>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Video type</p><p>Enumeration value:</p><ul><li>ugc: UGC seeding</li><li>talk: Product talk</li><li>display: Product display (product only, no voice)</li><li>unboxing: Out-of-the-box sharing</li><li>reaction: Reaction show</li></ul>
        /// </summary>
        [JsonProperty("VideoType")]
        public string VideoType{ get; set; }

        /// <summary>
        /// <p>Fission count</p><p>Value ranges from 0 to 1</p><p>Unit: unit</p>
        /// </summary>
        [JsonProperty("SplitCount")]
        public ulong? SplitCount{ get; set; }

        /// <summary>
        /// <p>Customize an on-camera model</p>
        /// </summary>
        [JsonProperty("CustomModel")]
        public CustomModel CustomModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ModelTier", this.ModelTier);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "VideoType", this.VideoType);
            this.SetParamSimple(map, prefix + "SplitCount", this.SplitCount);
            this.SetParamObj(map, prefix + "CustomModel.", this.CustomModel);
        }
    }
}

