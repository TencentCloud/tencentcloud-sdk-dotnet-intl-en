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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TurnDetection : AbstractModel
    {
        
        /// <summary>
        /// This parameter is valid only when TurnDetectionMode is 3, indicating the sensitivity of sentence segmentation.
        /// 
        /// 
        /// Feature description: determines whether the user has finished speaking to separate the audio.
        /// 
        /// 
        /// Optional: "low" | "medium" | "high" | "auto".
        /// 
        /// 
        /// auto is the default value, same as medium.
        /// low will give users sufficient time to speak.
        /// high will perform audio chunking as soon as possible.
        /// 
        /// 
        /// If you wish the model to respond more frequently in conversation mode, you can set SemanticEagerness to high.
        /// If you wish the AI to wait a moment when the user pauses, set SemanticEagerness to low.
        /// Regardless of the mode, it will eventually split and send to a large model for reply.
        /// </summary>
        [JsonProperty("SemanticEagerness")]
        public string SemanticEagerness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SemanticEagerness", this.SemanticEagerness);
        }
    }
}

