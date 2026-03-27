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
        /// Recording screen width, defaults to 1280, value range [0, 1920]
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Recording screen height, defaults to 720, value range [0, 1080]
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Specify the output format, optional hls, mp4. When storing to VOD, this parameter is invalid; please use the MediaType setting within TencentVod (https://cloud.tencent.com/document/api/647/44055#TencentVod).
        ///  
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// If the file format is aac or mp4, the system will automatically split the video file when it exceeds the length limit. Unit: minutes. Default: 1440 min (24h), value range: 1-1440. [Single file size is limited to a maximum of 2G. Files will be automatically split if either condition is met: file size >2G or recording duration > 24h]
        /// This parameter does not take effect for Hls format recordings.
        /// Sample value: 1440
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

