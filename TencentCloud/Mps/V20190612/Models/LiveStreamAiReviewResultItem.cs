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

    public class LiveStreamAiReviewResultItem : AbstractModel
    {
        
        /// <summary>
        /// The type of moderation result. Valid values:
        /// <li>ImagePorn</li>
        /// <li>ImageTerrorism</li>
        /// <li>ImagePolitical</li>
        /// <li>VoicePorn</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Result of porn information detection in image, which is valid when `Type` is `ImagePorn`.
        /// </summary>
        [JsonProperty("ImagePornResultSet")]
        public LiveStreamAiReviewImagePornResult[] ImagePornResultSet{ get; set; }

        /// <summary>
        /// The result of detecting sensitive information in images, which is valid if `Type` is `ImageTerrorism`.
        /// </summary>
        [JsonProperty("ImageTerrorismResultSet")]
        public LiveStreamAiReviewImageTerrorismResult[] ImageTerrorismResultSet{ get; set; }

        /// <summary>
        /// The result of detecting sensitive information in images, which is valid if `Type` is `ImagePolitical`.
        /// </summary>
        [JsonProperty("ImagePoliticalResultSet")]
        public LiveStreamAiReviewImagePoliticalResult[] ImagePoliticalResultSet{ get; set; }

        /// <summary>
        /// The result for moderation of pornographic content in audio. This parameter is valid if `Type` is `VoicePorn`.
        /// </summary>
        [JsonProperty("VoicePornResultSet")]
        public LiveStreamAiReviewVoicePornResult[] VoicePornResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "ImagePornResultSet.", this.ImagePornResultSet);
            this.SetParamArrayObj(map, prefix + "ImageTerrorismResultSet.", this.ImageTerrorismResultSet);
            this.SetParamArrayObj(map, prefix + "ImagePoliticalResultSet.", this.ImagePoliticalResultSet);
            this.SetParamArrayObj(map, prefix + "VoicePornResultSet.", this.VoicePornResultSet);
        }
    }
}

