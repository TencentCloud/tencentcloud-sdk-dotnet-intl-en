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

    public class AiAnalysisTaskDubbingOutput : AbstractModel
    {
        
        /// <summary>
        /// Specifies the video path for translation.
        /// </summary>
        [JsonProperty("VideoPath")]
        public string VideoPath{ get; set; }

        /// <summary>
        /// Specifies the file path of the tag.
        /// </summary>
        [JsonProperty("SpeakerPath")]
        public string SpeakerPath{ get; set; }

        /// <summary>
        /// Specifies the storage location of the transcoded video.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoPath", this.VideoPath);
            this.SetParamSimple(map, prefix + "SpeakerPath", this.SpeakerPath);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
        }
    }
}

