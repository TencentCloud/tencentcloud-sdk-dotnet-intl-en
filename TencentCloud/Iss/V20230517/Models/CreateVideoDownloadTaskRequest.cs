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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVideoDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Default: 1x. Supports 1x, 2x, 4x, and 8x playback speeds.
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// Expiration time of the transcoded mp4 file (7, 15, 30, 60, 90, 180, and 365 are supported)
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }

        /// <summary>
        /// Download file format. Currently only supports (1: mp4)
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// Completion policy (0: The task fails and no MP4 is generated if the stream pull fails but the video recording is incomplete. 1: The task succeeds and an MP4 is generated if the stream pull fails but the video recording is incomplete.)
        /// </summary>
        [JsonProperty("CompletionPolicy")]
        public long? CompletionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CompletionPolicy", this.CompletionPolicy);
        }
    }
}

