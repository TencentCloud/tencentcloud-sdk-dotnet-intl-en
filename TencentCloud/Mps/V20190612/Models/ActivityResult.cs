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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivityResult : AbstractModel
    {
        
        /// <summary>
        /// Atomic task type.
        /// <li>Transcode: transcoding.</li>
        /// <li>SampleSnapshot: sampled screenshot taking.</li>
        /// <li>AnimatedGraphics: animated image generating.</li>
        /// <li>SnapshotByTimeOffset: time point screenshot taking.</li>
        /// <li>ImageSprites: sprite image generating.</li>
        /// <li>AdaptiveDynamicStreaming: adaptive bitrate streaming.</li>
        /// <li>AiContentReview: content moderation.</li>
        /// <li>AIRecognition: intelligent identification.</li>
        /// <li>AIAnalysis: intelligent analysis.</li>
        /// 
        /// <li>AiQualityControl: media quality inspection.</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// The execution results of the subtasks of the scheme.
        /// </summary>
        [JsonProperty("ActivityResItem")]
        public ActivityResItem ActivityResItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamObj(map, prefix + "ActivityResItem.", this.ActivityResItem);
        }
    }
}

