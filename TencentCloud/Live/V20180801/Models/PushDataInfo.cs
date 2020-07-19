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

    public class PushDataInfo : AbstractModel
    {
        
        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

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
        /// IP of the server that receives the stream.
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// Pushed video frame rate in Hz.
        /// </summary>
        [JsonProperty("VideoFps")]
        public ulong? VideoFps{ get; set; }

        /// <summary>
        /// Pushed video bitrate in bps.
        /// </summary>
        [JsonProperty("VideoSpeed")]
        public ulong? VideoSpeed{ get; set; }

        /// <summary>
        /// Pushed audio frame rate in Hz.
        /// </summary>
        [JsonProperty("AudioFps")]
        public ulong? AudioFps{ get; set; }

        /// <summary>
        /// Pushed audio bitrate in bps.
        /// </summary>
        [JsonProperty("AudioSpeed")]
        public ulong? AudioSpeed{ get; set; }

        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// Push start time.
        /// </summary>
        [JsonProperty("BeginPushTime")]
        public string BeginPushTime{ get; set; }

        /// <summary>
        /// Audio codec,
        /// Example: AAC.
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Video codec,
        /// Example: H.264.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Resolution.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Sample rate.
        /// </summary>
        [JsonProperty("AsampleRate")]
        public ulong? AsampleRate{ get; set; }

        /// <summary>
        /// Audio bitrate in `metadata` in Kbps.
        /// </summary>
        [JsonProperty("MetaAudioSpeed")]
        public ulong? MetaAudioSpeed{ get; set; }

        /// <summary>
        /// Video bitrate in `metadata` in Kbps.
        /// </summary>
        [JsonProperty("MetaVideoSpeed")]
        public ulong? MetaVideoSpeed{ get; set; }

        /// <summary>
        /// Frame rate in `metadata`.
        /// </summary>
        [JsonProperty("MetaFps")]
        public ulong? MetaFps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "VideoFps", this.VideoFps);
            this.SetParamSimple(map, prefix + "VideoSpeed", this.VideoSpeed);
            this.SetParamSimple(map, prefix + "AudioFps", this.AudioFps);
            this.SetParamSimple(map, prefix + "AudioSpeed", this.AudioSpeed);
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "BeginPushTime", this.BeginPushTime);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AsampleRate", this.AsampleRate);
            this.SetParamSimple(map, prefix + "MetaAudioSpeed", this.MetaAudioSpeed);
            this.SetParamSimple(map, prefix + "MetaVideoSpeed", this.MetaVideoSpeed);
            this.SetParamSimple(map, prefix + "MetaFps", this.MetaFps);
        }
    }
}

