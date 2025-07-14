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

    public class McuRecordParams : AbstractModel
    {
        
        /// <summary>
        /// Relay Recording Mode
        /// 0/blank: Not currently supported, behavior undefined.
        /// 1: Disable recording.
        /// 2: Start recording (uses console's auto-recording template parameters. Reference: [Link to Documentation]).
        /// 3: Start recording (uses API-specified parameters).
        /// Example: 2
        /// </summary>
        [JsonProperty("UniRecord")]
        public ulong? UniRecord{ get; set; }

        /// <summary>
        /// Recording Task Key
        /// Identifies a recording task. This parameter allows merging multiple relay tasks into one recording file. If unspecified, only records the current relay task.
        /// [Format: Up to 128 bytes; only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-).]
        /// Example: test_record_key_a
        /// </summary>
        [JsonProperty("RecordKey")]
        public string RecordKey{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3]
        /// Recording Resume Wait Time
        /// Corresponds to template parameter "Resume Wait Duration." Unit: seconds.
        /// Range: 5-86400 (24 hours). Default: 30. Recording stops if idle longer than this value.
        /// Example: 30
        /// </summary>
        [JsonProperty("RecordWaitTime")]
        public ulong? RecordWaitTime{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3]
        /// Recording Output Formats
        /// Corresponds to template parameter "File Format." Supported values: hls, mp4, aac. Default: mp4.
        /// Note: mp4 and aac formats are mutually exclusive.
        /// Example (MP4 only): ["mp4"]
        /// Example (MP4 + HLS): ["mp4","hls"]
        /// </summary>
        [JsonProperty("RecordFormat")]
        public string[] RecordFormat{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3]
        /// Single File Duration
        /// Corresponds to template parameter "Max File Duration." Unit: minutes.
        /// Range: 1-1440 (24 hours). Default: 1440. Applies only to mp4/aac. Actual duration is capped at 2GB file size.
        /// Example: 1440
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public ulong? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3]
        /// Recording Media Type
        /// Corresponds to template parameter "Recording Format."
        /// 0: Audio+Video, 1: Audio only, 2: Video only. Output is the intersection of this setting and relay content.
        /// Example: 0
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// Recording Filename Prefix
        /// Filename prefix (<=64 bytes). Applies only to VOD storage.
        /// *Format: Letters (a-z, A-Z), numbers (0-9), underscores (_), hyphens (-).*
        /// Example: mcu_record_prefix
        /// </summary>
        [JsonProperty("UserDefineRecordPrefix")]
        public string UserDefineRecordPrefix{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3]
        /// Recording Storage Parameters
        /// Corresponds to console parameter "Storage Location." Supports Tencent VOD or COS (exclusively).
        /// Example: {"McuCloudVod":{"McuTencentVod":{"ExpireTime":86400}}}
        /// </summary>
        [JsonProperty("McuStorageParams")]
        public McuStorageParams McuStorageParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniRecord", this.UniRecord);
            this.SetParamSimple(map, prefix + "RecordKey", this.RecordKey);
            this.SetParamSimple(map, prefix + "RecordWaitTime", this.RecordWaitTime);
            this.SetParamArraySimple(map, prefix + "RecordFormat.", this.RecordFormat);
            this.SetParamSimple(map, prefix + "MaxMediaFileDuration", this.MaxMediaFileDuration);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamSimple(map, prefix + "UserDefineRecordPrefix", this.UserDefineRecordPrefix);
            this.SetParamObj(map, prefix + "McuStorageParams.", this.McuStorageParams);
        }
    }
}

