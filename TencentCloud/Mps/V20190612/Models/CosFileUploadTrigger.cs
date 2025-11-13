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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosFileUploadTrigger : AbstractModel
    {
        
        /// <summary>
        /// Name of the COS bucket bound to a workflow, such as `TopRankVideo-125xxx88`.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Region of the COS bucket bound to a workflow, such as `ap-chongiqng`.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Input path directory bound to a workflow, such as `/movie/201907/`. If this parameter is left empty, the `/` root directory will be used.
        /// </summary>
        [JsonProperty("Dir")]
        public string Dir{ get; set; }

        /// <summary>
        /// All supported formats are as follows:
        /// - Video file extension. The following 15 options are supported:
        /// `.mp4`, `.avi`, `.mov`, `.wmv`, `.flv`, `.mkv`, `.mpg`, `.mpeg`, `.rm`, `.rmvb`, `.asf`, `.3gp`, `.webm`, `.ts`, and `.m4v`.
        /// - Audio file extension. The following 7 options are supported:
        /// `.mp3`, `.wav`, `.aac`, `.flac`, `.ogg`, `.m4a`, and `.amr`.
        /// - Subtitle file extension. The following 2 options are supported:
        /// `.vtt` and `.srt`.
        /// - `*`: any file format is supported.
        /// - Unspecified or input an empty list: the system supports the following preset file formats: video (`.mp4`, `.ts`, `.flv`, `.wmv`, `.asf`, `.rm`, `.rmvb`, `.mpg`, `.mpeg`, `.3gp`, `.mov`, `.webm`, `.mkv`, `.avi`, and `.m4v`); audio (`.mp3`, `.m4a`, `.flac`, `.ogg`, `.wav`, `.amr`, and `.aac`); subtitle (`.vtt` and `.srt`).
        /// **Note**:
        /// 1. If the input format list includes `*`, it indicates that any file format is supported.
        /// 2. File extensions can be provided with or without `.`, such as `.mp4` or `mp4`, both are supported.
        /// 3. Custom file extensions should consist of digits, letters, and characters, and have a length between 1 and 64 characters.
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Dir", this.Dir);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

