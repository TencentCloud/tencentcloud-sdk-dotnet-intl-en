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

    public class DescribeVideoDownloadUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Download start time in UTC seconds. The longest period between the start and end times is 60 minutes and cannot span across days.
        /// Note: The actual downloaded file duration may be longer than this period. You can obtain the actual download start time and end time by specifying the IsRespActualTime parameter. This is because downloads are aligned by TS segments to ensure data integrity and include the entire specified period.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Download end time in UTC seconds. The longest period between the start and end times is 60 minutes and cannot span across days.
        /// Note: The actual downloaded file duration may be longer than this period. You can obtain the actual download start time and end time by specifying the IsRespActualTime parameter. This is because downloads are aligned by TS segments to ensure data integrity and include the entire specified period.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// File format. "mp4": MP4 format. "ts": TS file format.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// data carries the actual download video recording start time and end time required or not
        /// </summary>
        [JsonProperty("IsRespActualTime")]
        public bool? IsRespActualTime{ get; set; }

        /// <summary>
        /// Whether to return the private network download URL. Default false: the public network download URL is returned. If true, the private network download URL is returned.
        /// </summary>
        [JsonProperty("IsInternal")]
        public bool? IsInternal{ get; set; }

        /// <summary>
        /// Set the valid period of the URL. The minimum value is 1 second and the maximum value is 86400 seconds. If not set, the default is 600 seconds.
        /// </summary>
        [JsonProperty("Expires")]
        public long? Expires{ get; set; }

        /// <summary>
        /// Whether the downloaded MP4 file supports G711 audio encoding. 
        /// Note: If the audio encoding in cloud recording is AAC, then the downloaded MP4 supports AAC encoding by default.
        /// If the audio encoding in the cloud recording is G711 and IsSupportG711 is set to true, the downloaded MP4 supports G711 audio encoding.
        /// If the audio encoding in the cloud recording is G711 and IsSupportG711 is set to false, the downloaded MP4 does not support G711 audio encoding.
        /// This parameter is valid only when FileType is mp4. If left unset, it defaults to false.
        /// </summary>
        [JsonProperty("IsSupportG711")]
        public bool? IsSupportG711{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "IsRespActualTime", this.IsRespActualTime);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
            this.SetParamSimple(map, prefix + "Expires", this.Expires);
            this.SetParamSimple(map, prefix + "IsSupportG711", this.IsSupportG711);
        }
    }
}

