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

    public class VideoDownloadTask : AbstractModel
    {
        
        /// <summary>
        /// Download task ID
        /// </summary>
        [JsonProperty("DownloadTaskId")]
        public string DownloadTaskId{ get; set; }

        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Channel encoding
        /// </summary>
        [JsonProperty("ChannelCode")]
        public string ChannelCode{ get; set; }

        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Device code
        /// </summary>
        [JsonProperty("DeviceCode")]
        public string DeviceCode{ get; set; }

        /// <summary>
        /// Task status (0: pending; 1: executing; 2: task complete;
        /// 3: Task failure)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Download the recording time period
        /// </summary>
        [JsonProperty("VideoTimeSection")]
        public string VideoTimeSection{ get; set; }

        /// <summary>
        /// Playback speed
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// Download duration.
        /// </summary>
        [JsonProperty("DownloadTime")]
        public long? DownloadTime{ get; set; }

        /// <summary>
        /// Video recording size
        /// </summary>
        [JsonProperty("VideoSize")]
        public long? VideoSize{ get; set; }

        /// <summary>
        /// Task start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// File download address
        /// </summary>
        [JsonProperty("FileDownloadUrl")]
        public string FileDownloadUrl{ get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// Lifecycle rule, number of days in hot storage
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }

        /// <summary>
        /// mp4 preview address
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DownloadTaskId", this.DownloadTaskId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelCode", this.ChannelCode);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceCode", this.DeviceCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VideoTimeSection", this.VideoTimeSection);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "DownloadTime", this.DownloadTime);
            this.SetParamSimple(map, prefix + "VideoSize", this.VideoSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FileDownloadUrl", this.FileDownloadUrl);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
        }
    }
}

