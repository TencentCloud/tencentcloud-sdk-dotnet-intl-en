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
        /// Retweet recording mode. 
        /// 0/Leave blank: not currently supported; behavior is undefined.
        /// 1: disable recording.
        /// 2: enable recording (via console automatic recording template parameters, see: [redirection document](https://www.tencentcloud.comom/document/product/647/111748?from_cn_redirect=1#.E5.BD.95.E5.88.B6.E6.8E.A7.E5.88.B6.E6.96.B9.E6.A1.88));.
        /// 3: enable recording (use API to specify parameter).
        /// </summary>
        [JsonProperty("UniRecord")]
        public ulong? UniRecord{ get; set; }

        /// <summary>
        /// Recording task key, identifies a recording task. you can record multiple relay tasks into a file by specifying this parameter. if this parameter is not specified, only the current relay task is recorded.
        /// Limit length to 128 bytes, only allow a combination of uppercase and lowercase letters (a-zA-Z), digits (0-9), underscores (_), and hyphens (-).
        /// </summary>
        [JsonProperty("RecordKey")]
        public string RecordKey{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3.].
        /// Resume recording waiting time, corresponding to the "wait time for resumption" in the recording template, unit: seconds. the value must be greater than or equal to 5 and less than or equal to 86400 (24 hours), with a default value of 30. when resumption is enabled, the recording task ends automatically if idle for a duration exceeding RecordWaitTime.
        /// </summary>
        [JsonProperty("RecordWaitTime")]
        public ulong? RecordWaitTime{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3.].
        /// The list of output file formats for recording corresponds to the "file format" in the recording template. it supports three formats: "hls", "mp4", and "aac". the default value is "mp4". among them, "mp4" and "aac" formats cannot be specified simultaneously.
        /// Record only the mp4 format, example value: ["mp4"]. record both mp4 and HLS formats simultaneously, example value: ["mp4","HLS"].
        /// </summary>
        [JsonProperty("RecordFormat")]
        public string[] RecordFormat{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3.].
        /// Single file recording duration, corresponding to the "max recording time per file" in the recording template, unit: minutes. the value must be greater than or equal to 1 and less than or equal to 1440 (24 hours), with a default value of 1440. it only takes effect for "mp4" or "aac" format. the actual single file recording duration is also limited by the file size not exceeding 2G. if it exceeds 2G, the file will be forcibly split.
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public ulong? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3.].
        /// The audio and video type of the recording corresponds to the "recording format" in the recording template. valid values: 0 (audio and video), 1 (pure audio), 2 (video only). the final recording file content is the intersection of the specified type and the relayed content.
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// Recording file name prefix, no more than 64 characters. this parameter is valid only when store is vod.
        /// Limit length to 64 bytes, only allow a combination of uppercase and lowercase letters (a-zA-Z), digits (0-9), underscores (_), and hyphens (-).
        /// </summary>
        [JsonProperty("UserDefineRecordPrefix")]
        public string UserDefineRecordPrefix{ get; set; }

        /// <summary>
        /// [Valid only when UniRecord=3.].
        /// Recording files storage parameters, corresponding console "storage location" and related parameters. currently supports VOD and COS storage methods. only one can be filled.
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

