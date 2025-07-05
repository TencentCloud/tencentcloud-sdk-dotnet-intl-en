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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// The source text for synthesizing speech, which is encoded in UTF-8.
        /// It can contain up to 150 Chinese characters (a full-width punctuation as a Chinese character) or 500 letters ( a half-width punctuation as a letter).
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// The `SessionId` of a request, which will be returned as-is. We recommend that you pass characters like uuid to prevent repetition.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Volume range: [0, 10], corresponding to 11 volume levels. 0 is the default value, indicating the normal volume. There is no mute option.
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// Speed range: [-2, 6], corresponding to different speeds<li>-2 for 0.6 times</li><li>-1 for 0.8 times</li><li>0 for 1.0 time (default)</li><li>1 for 1.2 times</li><li>2 for 1.5 times</li><li>6 for 2.5 times</li>To set finer-grained speed levels, keep one decimal place, such as 0.5, 1.1, and 1.8.<br>
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// Project ID, which defaults to 0 and can be customized.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Model type, with `1` for the default model.
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// Standard voices <li>10510000-zhixiaoyao (Chinese)</li><li>1001-zhiyu (Chinese)</li><li>1002-zhiling (Chinese)</li><li>1003-zhimei (Chinese)</li><li>1004-zhiyun (Chinese)</li><li>1005-zhili (Chinese)</li><li>1007-zhina (Chinese)</li><li>1008-zhiqi (Chinese)</li><li>1009-zhiyun (Chinese)</li><li>1010-zhihua (Chinese)</li><li>1017-zhirong (Chinese)</li><li>1018-zhijing (Chinese)</li><li>1050-WeJack (English)</li><li>1051-WeRose (English)</li>Premium voices<br>Premium voices have higher fidelity and more natural-sounding quality than standard voices. For price details, see [Purchase Guide](https://www.tencentcloud.com/document/product/1154/47874).<br><li>100510000-zhixiaoyao (Chinese)</li><li>101001-zhiyu (Chinese)</li><li>101002-zhiling (Chinese)</li><li>101003-zhimei (Chinese)</li><li>101004-zhiyun (Chinese)</li><li>101005-zhili (Chinese)</li><li>101006-zhiyan (Chinese)</li><li>101007-zhina (Chinese)</li><li>101008-zhiqi (Chinese)</li><li>101009-zhiyun (Chinese)</li><li>101010-zhihua (Chinese)</li><li>101011-zhiyan (Chinese)</li><li>101012-zhidan (Chinese)</li><li>101013-zhihui (Chinese)</li><li>101014-zhining (Chinese)</li><li>101015-zhimeng (Chinese)</li><li>101016-zhitian (Chinese)</li><li>101017-zhirong (Chinese)</li><li>101018-zhijing (Chinese)</li><li>101019-zhitong (Cantonese)</li><li>101020-zhigang (Chinese)</li><li>101021-zhirui (Chinese)</li><li>101022-zhihong (Chinese)</li><li>101023-zhixuan (Chinese)</li><li>101024-zhihao (Chinese)</li><li>101025-zhiwei (Chinese)</li><li>101026-zhixi (Chinese)</li><li>101027-zhimei (Chinese)</li><li>101028-zhijie (Chinese)</li><li>101029-zhikai (Chinese)</li><li>101030-zhike (Chinese)</li><li>101031-zhikui (Chinese)</li><li>101032-zhifang (Chinese)</li><li>101033-zhibei (Chinese)</li><li>101034-zhilian (Chinese)</li><li>101035-zhiyi (Chinese)</li><li>101040-zhichuan (Sichuan dialect)</li><li>101050-WeJack (English)</li><li>101051-WeRose (English)</li><li>101052-zhiwei (Chinese)</li>
        /// <li>101053-zhifang (Chinese)</li>
        /// <li>101054-zhiyou (Chinese)</li>
        /// <li>101055-zhiyou (Chinese)</li>
        /// <li>101056-zhilin (Northeastern Mandarin)</li>
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// Primary language type: <li>1 - Chinese (default)</li><li>2 - English</li>
        /// </summary>
        [JsonProperty("PrimaryLanguage")]
        public long? PrimaryLanguage{ get; set; }

        /// <summary>
        /// Audio sample rate: <li>16000: 16k (default)</li><li>8000: 8k</li>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// Format of returned audio. Valid values: WAV (default), MP3, and PCM.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Whether to enable the timestamp feature. Default value: `false`.
        /// </summary>
        [JsonProperty("EnableSubtitle")]
        public bool? EnableSubtitle{ get; set; }

        /// <summary>
        /// The threshold of speech segmentation sensibility, which can be `0` (default), `1`, or `2`. A larger value indicates fewer segments, and the model tends to only segment sentences based on punctuation marks. We recommend you not change this parameter to avoid adverse effect on speech synthesis.
        /// </summary>
        [JsonProperty("SegmentRate")]
        public ulong? SegmentRate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EmotionCategory")]
        public string EmotionCategory{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EmotionIntensity")]
        public long? EmotionIntensity{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FastVoiceType")]
        public string FastVoiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "PrimaryLanguage", this.PrimaryLanguage);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "EnableSubtitle", this.EnableSubtitle);
            this.SetParamSimple(map, prefix + "SegmentRate", this.SegmentRate);
            this.SetParamSimple(map, prefix + "EmotionCategory", this.EmotionCategory);
            this.SetParamSimple(map, prefix + "EmotionIntensity", this.EmotionIntensity);
            this.SetParamSimple(map, prefix + "FastVoiceType", this.FastVoiceType);
        }
    }
}

