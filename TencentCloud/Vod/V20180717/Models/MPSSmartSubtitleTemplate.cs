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

    public class MPSSmartSubtitleTemplate : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleType")]
        public long? SubtitleType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoSrcLanguage")]
        public string VideoSrcLanguage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranslateSwitch")]
        public string TranslateSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranslateDstLanguage")]
        public string TranslateDstLanguage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProcessType")]
        public ulong? ProcessType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public MPSSelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SpeakerMode")]
        public long? SpeakerMode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SpeakerLabel")]
        public long? SpeakerLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SubtitleType", this.SubtitleType);
            this.SetParamSimple(map, prefix + "VideoSrcLanguage", this.VideoSrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "TranslateSwitch", this.TranslateSwitch);
            this.SetParamSimple(map, prefix + "TranslateDstLanguage", this.TranslateDstLanguage);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "SpeakerMode", this.SpeakerMode);
            this.SetParamSimple(map, prefix + "SpeakerLabel", this.SpeakerLabel);
        }
    }
}

