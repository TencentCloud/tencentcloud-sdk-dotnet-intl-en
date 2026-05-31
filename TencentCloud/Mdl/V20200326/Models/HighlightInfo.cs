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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HighlightInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable input recognition  0: disabled  1: enabled  Default value: 0.
        /// </summary>
        [JsonProperty("HighlightEnabled")]
        public ulong? HighlightEnabled{ get; set; }

        /// <summary>
        /// Products to save results. Option: COS.
        /// Currently supports Tencent Cloud COS only. AWS S3 integration will be supported later. Default is COS.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Valid when Type is COS. Region of COS storage.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Valid when Type is COS. Bucket name of COS storage.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Valid when Type is COS. Path of COS storage.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Valid when Type is COS. Name of the stored file in COS.
        /// </summary>
        [JsonProperty("Filename")]
        public string Filename{ get; set; }

        /// <summary>
        /// Valid when Type is COS. The file extension of COS storage is automatically generated in time format. Available values: unix, utc.
        /// unix is a second-level timestamp. utc 0 represents the year, month, day.
        /// </summary>
        [JsonProperty("TimestampFormat")]
        public string TimestampFormat{ get; set; }

        /// <summary>
        /// Audio selector list, selectable, can be left blank. By default, an audio is used as the output of the recognition result.
        /// </summary>
        [JsonProperty("AudioSelectorNames")]
        public string[] AudioSelectorNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighlightEnabled", this.HighlightEnabled);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Filename", this.Filename);
            this.SetParamSimple(map, prefix + "TimestampFormat", this.TimestampFormat);
            this.SetParamArraySimple(map, prefix + "AudioSelectorNames.", this.AudioSelectorNames);
        }
    }
}

