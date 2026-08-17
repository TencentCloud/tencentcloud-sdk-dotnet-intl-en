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

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// Atomic task type.
        /// <li>input: start node.</li>
        /// <li>output: termination node.</li>
        /// <li>action-trans: transcoding.</li>
        /// <li>action-samplesnapshot: sampled screenshot taking.</li>
        /// <li>action-AIAnalysis: analysis</li>
        /// <li>action-AIRecognition: recognition.</li>
        /// <li>action-aiReview: review</li>
        /// <li>action-animated-graphics: animated image</li>
        /// <li>action-image-sprite: sprite sheet</li>
        /// <li>action-snapshotByTimeOffset: time point screenshot taking</li>
        /// <li>action-adaptive-substream: adaptive bitrate streaming.</li>
        /// <li>action-AIQualityControl: media quality inspection.</li>
        /// <li>action-SmartSubtitles: smart subtitle</li>
        /// <li>action-exec-rules: judgment rule</li>
        /// <li>action-SmartErase: intelligent removal.</li>
        /// 
        /// 
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// Rear drive node index array
        /// </summary>
        [JsonProperty("ReardriveIndex")]
        public long?[] ReardriveIndex{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ActivityPara")]
        public ActivityPara ActivityPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamArraySimple(map, prefix + "ReardriveIndex.", this.ReardriveIndex);
            this.SetParamObj(map, prefix + "ActivityPara.", this.ActivityPara);
        }
    }
}

