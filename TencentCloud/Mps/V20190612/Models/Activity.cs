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

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// Atomic task type.
        /// <li>input: start node</li>
        /// <li>output: end node</li>
        /// <li>action-trans: transcoding</li>
        /// <li>action-samplesnapshot: sampled screenshot</li>
        /// <li>action-AIAnalysis: analysis</li>
        /// <li>action-AIRecognition: recognition</li>
        /// <li>action-aiReview: review</li>
        /// <li>action-animated-graphics: conversion to GIF</li>
        /// <li>action-image-sprite: image sprite</li>
        /// <li>action-snapshotByTimeOffset: time point screenshot</li>
        /// <li>action-adaptive-substream: adaptive bitrate stream</li>
        /// <li>action-AIQualityControl: media quality inspection</li>
        /// <li>action-SmartSubtitles: smart subtitle</li>
        /// 
        /// 
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// The indexes of the subsequent actions.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReardriveIndex")]
        public long?[] ReardriveIndex{ get; set; }

        /// <summary>
        /// The parameters of a subtask.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

