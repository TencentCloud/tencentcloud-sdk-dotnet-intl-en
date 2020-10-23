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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Only `AttachedInputs.AudioSelectors.Name` can be selected. This parameter is required for RTP_PUSH and UDP_PUSH.
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public string AudioSelectorName{ get; set; }

        /// <summary>
        /// Audio transcoding template name, which can contain 1-20 letters and digits.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio codec. Valid value: AAC. Default value: AAC.
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Audio bitrate. If this parameter is left empty, the original value will be used.
        /// Valid values: 6000, 7000, 8000, 10000, 12000, 14000, 16000, 20000, 24000, 28000, 32000, 40000, 48000, 56000, 64000, 80000, 96000, 112000, 128000, 160000, 192000, 224000, 256000, 288000, 320000, 384000, 448000, 512000, 576000, 640000, 768000, 896000, 1024000
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Audio language code, whose length is always 3 characters.
        /// </summary>
        [JsonProperty("LanguageCode")]
        public string LanguageCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioSelectorName", this.AudioSelectorName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "LanguageCode", this.LanguageCode);
        }
    }
}

