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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodeDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Start time (Beijing time) in the format of `yyyy-mm-dd HH:MM`.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time (Beijing time) in the format of `yyyy-mm-dd HH:MM`.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Transcoding duration in minutes.
        /// Note: given the possible interruptions during push, duration here is the sum of actual duration of transcoding instead of the interval between the start time and end time.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Codec with modules,
        /// Example:
        /// liveprocessor_H264: LVB transcoding - H264,
        /// liveprocessor_H265: LVB transcoding - H265,
        /// topspeed_H264: top speed codec - H264,
        /// topspeed_H265: top speed codec - H265.
        /// </summary>
        [JsonProperty("ModuleCodec")]
        public string ModuleCodec{ get; set; }

        /// <summary>
        /// Bitrate.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Type. Valid values: Transcode, MixStream, WaterMark.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// Resolution.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ModuleCodec", this.ModuleCodec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

