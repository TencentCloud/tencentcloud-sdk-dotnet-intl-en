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

    public class WebRecordVideoParams : AbstractModel
    {
        
        /// <summary>
        /// Recording image width defaults to 1280, with a value range of [0, 1920].
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Recording image height, defaults to 720, in the range of [0, 1080].
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Specify output format. valid values: hls, mp4. this parameter is invalid when storing in VOD. to store in VOD, set MediaType in TencentVod (https://www.tencentcloud.comom/document/api/647/44055?from_cn_redirect=1#TencentVod).
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// If the file format is aac or mp4, the system will automatically split the video file when the length limit is exceeded. measurement unit: minute. defaults to 1440 min (24h). value range: 1-1440. [single file limit is 2G. if file size exceeds 2G or recording duration exceeds 24h, the file will be automatically split.].
        /// Hls format recording. this parameter is not effective.
        /// Example value: 1440.
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public long? MaxMediaFileDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "MaxMediaFileDuration", this.MaxMediaFileDuration);
        }
    }
}

