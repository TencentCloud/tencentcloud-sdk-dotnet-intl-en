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

    public class RecordParams : AbstractModel
    {
        
        /// <summary>
        /// Recording mode:.
        /// 1: single stream recording, record the audio and video of the subscribed UserId in the room separately, and upload the recording files to cloud storage.
        /// 2: mixed-stream recording. mix the audio and video of the subscribed UserId in the room into an audio-video file and upload the recording file to cloud storage.
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// Recording stops automatically when there is no host inside the room for a duration exceeding MaxIdleTime. measurement unit: second. default value: 30 seconds. the value must be greater than or equal to 5 seconds and less than or equal to 86400 seconds (24 hours).
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Media stream type for recording.
        /// 0: recording audio and video streams (default).
        /// 1: record audio streams only.
        /// 2: record video stream only.
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// Specifies the allowlist or blocklist for the subscription stream.
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// Output file format (valid when stored in third-party storage such as COS). 0: (default) output file is in hls format. 1: output file format is hls+mp4. 2: output file format is hls+aac. 3: output file format is mp4. 4: output file format is aac.
        /// 
        /// This parameter is invalid when storing in VOD. when storing in VOD, set MediaType in TencentVod (https://www.tencentcloud.comom/document/api/647/44055?from_cn_redirect=1#TencentVod).
        /// </summary>
        [JsonProperty("OutputFormat")]
        public ulong? OutputFormat{ get; set; }

        /// <summary>
        /// In single-stream recording mode, determine whether to merge the user's audio and video. 0: do not merge the audio and video of a stream (default). 1: merge the audio and video of a stream into one ts. in mixed-stream recording, this parameter is not required, and the audio and video are merged by default.
        /// </summary>
        [JsonProperty("AvMerge")]
        public ulong? AvMerge{ get; set; }

        /// <summary>
        /// If the file format is aac or mp4, the system will automatically split the video file when the length limit is exceeded. measurement unit: minute. defaults to 1440 min (24h). value range: 1-1440. [single file limit is 2G. if file size exceeds 2G or recording duration exceeds 24h, the file will be automatically split.].
        /// Hls format recording. this parameter is not effective.
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public ulong? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// Specify recording streams. 0: mainstream + auxiliary stream (default); 1: mainstream; 2: auxiliary stream.
        /// </summary>
        [JsonProperty("MediaId")]
        public ulong? MediaId{ get; set; }

        /// <summary>
        /// Specifies the type of frame to fill when the upstream video stream stops:
        /// - 0: Fill with the last frame (freeze the last video frame)
        /// - 1: Fill with black frames
        /// </summary>
        [JsonProperty("FillType")]
        public ulong? FillType{ get; set; }

        /// <summary>
        /// Specifies whether the recording task subscribes to the stream published by the Mixed Stream Robot. 
        /// 
        /// - 1: Subscribe. 
        /// - 0: Do not subscribe (default).
        /// > Note: 
        /// When this option is enabled, it is recommended to use the "Subscription Allowlist." Avoid subscribing to both the stream published by the Mixed Stream Robot and the streams published by the hosts simultaneously; otherwise, it will result in audio echoing (duplicate audio) in the recorded file.
        /// </summary>
        [JsonProperty("SubscribeAbility")]
        public ulong? SubscribeAbility{ get; set; }


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
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "SubscribeAbility", this.SubscribeAbility);
        }
    }
}

