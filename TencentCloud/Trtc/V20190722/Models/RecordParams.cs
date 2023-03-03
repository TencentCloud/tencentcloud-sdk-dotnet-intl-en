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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParams : AbstractModel
    {
        
        /// <summary>
        /// The recording mode.
        /// 1: Single-stream recording. Records the audio and video of each subscribed user (`UserId`) in a room and saves the recording files to the cloud.
        /// 2: Mixed-stream recording. Mixes the audios and videos of subscribed users (`UserId`) in a room, records the mixed stream, and saves the recording files to the cloud.
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// The time period (seconds) to wait to automatically stop recording after there are no anchors (users who publish streams) in a room. Value range: 5-86400 (max 24 hours). Default value: 30.
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// The media type of the streams to record.
        /// 0: Audio and video streams (default)
        /// 1: Audio streams only
        /// 2: Video streams only
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// The allowlist/blocklist for stream subscription.
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// The output format. `0` (default): HLS; `1`: HLS + MP4; `2`: HLS + AAC. This parameter is invalid if you save recording files to VOD. To specify the format of files saved to VOD, use `MediaType` of `TencentVod`.
        /// </summary>
        [JsonProperty("OutputFormat")]
        public ulong? OutputFormat{ get; set; }

        /// <summary>
        /// Whether to merge the audio and video of a user in the single-stream recording mode. 0 (default): Do not mix the audio and video; 1: Mix the audio and video into one TS file. You don’t need to specify this parameter for mixed-stream recording, which merges audios and videos by default.
        /// </summary>
        [JsonProperty("AvMerge")]
        public ulong? AvMerge{ get; set; }

        /// <summary>
        /// The maximum file duration allowed (minutes). If the output format is AAC or MP4, and the maximum file duration is exceeded, the file will be segmented. Value range: 1-1440. Default value: 1440 (24 hours). The maximum file size allowed is 2 GB. If the file size exceeds 2 GB, or the file duration exceeds 24 hours, the file will also be segmented.
        /// This parameter is invalid if the output format is HLS.
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public ulong? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// The type of stream to record. `0`: The primary stream and substream; `1`: The primary stream; `2`: The substream.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaId")]
        public ulong? MediaId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordMode", this.RecordMode);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "AvMerge", this.AvMerge);
            this.SetParamSimple(map, prefix + "MaxMediaFileDuration", this.MaxMediaFileDuration);
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
        }
    }
}

