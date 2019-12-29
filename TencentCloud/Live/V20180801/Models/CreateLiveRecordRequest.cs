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

    public class CreateLiveRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Push path, which is the same as the AppName in push and playback addresses and is "live" by default.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Push domain name. This parameter must be set for multi-domain name push.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Recording start time, which is China standard time and should be URL-encoded (RFC3986). For example, the encoding of 2017-01-01 10:10:01 is 2017-01-01+10%3a10%3a01.
        /// In scheduled recording mode, this field must be set; in real-time video recording mode, this field is ignored.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Recording end time, which is China standard time and should be URL-encoded (RFC3986). For example, the encoding of 2017-01-01 10:30:01 is 2017-01-01+10%3a30%3a01.
        /// In scheduled recording mode, this field must be set; in real-time video recording mode, this field is optional. If the recording is set to real-time video recording mode through the Highlight parameter, the end time set should not be more than 30 minutes after the current time. If the set end time is more than 30 minutes after the current time, earlier than the current time or left blank, the actual end time will be 30 minutes after the current time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Recording type.
        /// "video": Audio-video recording **(default)**.
        /// "audio": audio recording.
        /// In both scheduled and real-time video recording modes, this parameter is valid and is not case sensitive.
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// Recording file format. Value range:
        /// "flv" **(default)**, "hls", "mp4", "aac", "mp3".
        /// In both scheduled and real-time video recording modes, this parameter is valid and is not case sensitive.
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// Mark for enabling real-time video recording mode.
        /// 0: Real-time video recording mode is not enabled, i.e., the scheduled recording mode is used **(default)**. See [Sample 1](#.E7.A4.BA.E4.BE.8B1-.E5.88.9B.E5.BB.BA.E5.AE.9A.E6.97.B6.E5.BD.95.E5.88.B6.E4.BB.BB.E5.8A.A1).
        /// 1: Real-time video recording mode is enabled. See [Sample 2](#.E7.A4.BA.E4.BE.8B2-.E5.88.9B.E5.BB.BA.E5.AE.9E.E6.97.B6.E5.BD.95.E5.88.B6.E4.BB.BB.E5.8A.A1).
        /// </summary>
        [JsonProperty("Highlight")]
        public long? Highlight{ get; set; }

        /// <summary>
        /// Mark for enabling A+B=C mixed stream recording.
        /// 0: A+B=C mixed stream recording is not enabled **(default)**.
        /// 1: A+B=C mixed stream recording is enabled.
        /// In both scheduled and real-time video recording modes, this parameter is valid.
        /// </summary>
        [JsonProperty("MixStream")]
        public long? MixStream{ get; set; }

        /// <summary>
        /// Recording stream parameter. The following parameters are supported currently:
        /// record_interval: Recording interval in seconds. Value range: 1,800-7,200
        /// storage_time: Recording file duration in seconds
        /// eg. record_interval=3600&storage_time=2592000
        /// Note: The parameter needs url encode.
        /// In both scheduled and real-time video recording modes, this parameter is valid.
        /// </summary>
        [JsonProperty("StreamParam")]
        public string StreamParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "Highlight", this.Highlight);
            this.SetParamSimple(map, prefix + "MixStream", this.MixStream);
            this.SetParamSimple(map, prefix + "StreamParam", this.StreamParam);
        }
    }
}

