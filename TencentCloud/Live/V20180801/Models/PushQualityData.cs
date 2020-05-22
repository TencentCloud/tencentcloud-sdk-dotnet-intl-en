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

    public class PushQualityData : AbstractModel
    {
        
        /// <summary>
        /// Data time in the format of `%Y-%m-%d %H:%M:%S.%ms` and accurate down to the millisecond level.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// Push path.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Push client IP.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Push start time in the format of `%Y-%m-%d %H:%M:%S.%ms` and accurate down to the millisecond level.
        /// </summary>
        [JsonProperty("BeginPushTime")]
        public string BeginPushTime{ get; set; }

        /// <summary>
        /// Resolution information.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Video codec.
        /// </summary>
        [JsonProperty("VCodec")]
        public string VCodec{ get; set; }

        /// <summary>
        /// Audio codec.
        /// </summary>
        [JsonProperty("ACodec")]
        public string ACodec{ get; set; }

        /// <summary>
        /// Push serial number, which uniquely identifies a push.
        /// </summary>
        [JsonProperty("Sequence")]
        public string Sequence{ get; set; }

        /// <summary>
        /// Video frame rate.
        /// </summary>
        [JsonProperty("VideoFps")]
        public ulong? VideoFps{ get; set; }

        /// <summary>
        /// Video bitrate in bps.
        /// </summary>
        [JsonProperty("VideoRate")]
        public ulong? VideoRate{ get; set; }

        /// <summary>
        /// Audio frame rate.
        /// </summary>
        [JsonProperty("AudioFps")]
        public ulong? AudioFps{ get; set; }

        /// <summary>
        /// Audio bitrate in bps.
        /// </summary>
        [JsonProperty("AudioRate")]
        public ulong? AudioRate{ get; set; }

        /// <summary>
        /// Local elapsed time in milliseconds. The greater the difference between audio/video elapsed time and local elapsed time, the poorer the push quality and the more serious the upstream lag.
        /// </summary>
        [JsonProperty("LocalTs")]
        public ulong? LocalTs{ get; set; }

        /// <summary>
        /// Video elapsed time in milliseconds.
        /// </summary>
        [JsonProperty("VideoTs")]
        public ulong? VideoTs{ get; set; }

        /// <summary>
        /// Audio elapsed time in milliseconds.
        /// </summary>
        [JsonProperty("AudioTs")]
        public ulong? AudioTs{ get; set; }

        /// <summary>
        /// Video bitrate in `metadata` in Kbps.
        /// </summary>
        [JsonProperty("MetaVideoRate")]
        public ulong? MetaVideoRate{ get; set; }

        /// <summary>
        /// Audio bitrate in `metadata` in Kbps.
        /// </summary>
        [JsonProperty("MetaAudioRate")]
        public ulong? MetaAudioRate{ get; set; }

        /// <summary>
        /// Frame rate in `metadata`.
        /// </summary>
        [JsonProperty("MateFps")]
        public ulong? MateFps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "BeginPushTime", this.BeginPushTime);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "VCodec", this.VCodec);
            this.SetParamSimple(map, prefix + "ACodec", this.ACodec);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "VideoFps", this.VideoFps);
            this.SetParamSimple(map, prefix + "VideoRate", this.VideoRate);
            this.SetParamSimple(map, prefix + "AudioFps", this.AudioFps);
            this.SetParamSimple(map, prefix + "AudioRate", this.AudioRate);
            this.SetParamSimple(map, prefix + "LocalTs", this.LocalTs);
            this.SetParamSimple(map, prefix + "VideoTs", this.VideoTs);
            this.SetParamSimple(map, prefix + "AudioTs", this.AudioTs);
            this.SetParamSimple(map, prefix + "MetaVideoRate", this.MetaVideoRate);
            this.SetParamSimple(map, prefix + "MetaAudioRate", this.MetaAudioRate);
            this.SetParamSimple(map, prefix + "MateFps", this.MateFps);
        }
    }
}

