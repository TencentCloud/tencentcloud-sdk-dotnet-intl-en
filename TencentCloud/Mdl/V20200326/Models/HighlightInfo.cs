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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HighlightInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable input recognition 0: Disable 1 Enable Default value 0 Disable.
        /// </summary>
        [JsonProperty("HighlightEnabled")]
        public ulong? HighlightEnabled{ get; set; }

        /// <summary>
        /// The product where the results are saved, optional: COS. Currently, only Tencent Cloud COS is supported. In the future, it will be connected to AWS S3 and COS will be used by default.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Valid when Type is COS, the region where COS is stored.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Valid when Type is COS, the bucket name stored in COS.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Valid when Type is COS, the path where cos is stored.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Valid when Type is COS, the file name stored in cos.
        /// </summary>
        [JsonProperty("Filename")]
        public string Filename{ get; set; }

        /// <summary>
        /// Valid when Type is COS, the file name suffix stored in COS is automatically generated in the time format, optional values: unix, utc. Unix is the second-level timestamp and UTC is the year, month and day represented by the zero time zone.
        /// </summary>
        [JsonProperty("TimestampFormat")]
        public string TimestampFormat{ get; set; }

        /// <summary>
        /// Audio selector list is optional and can be empty. If not filled in, an audio will be used as the output of the recognition result by default.
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

