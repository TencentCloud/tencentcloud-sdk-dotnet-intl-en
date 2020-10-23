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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskStatData : AbstractModel
    {
        
        /// <summary>
        /// Task type
        /// <li>Transcode: transcoding</li>
        /// <li>Snapshot: screencapturing</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task statistics overview.
        /// <li>Transcode: usage in seconds</li>
        /// </summary>
        [JsonProperty("Summary")]
        public TaskStatDataItem[] Summary{ get; set; }

        /// <summary>
        /// Detailed statistics of tasks with different specifications.
        /// Transcoding specification:
        /// <li>Remuxing: remuxing</li>
        /// <li>Audio: audio transcoding</li>
        /// <li>Standard.H264.SD: H.264 SD transcoding</li>
        /// <li>Standard.H264.HD: H.264 HD transcoding</li>
        /// <li>Standard.H264.FHD: H.264 FHD transcoding</li>
        /// <li>Standard.H264.2K: H.264 2K transcoding</li>
        /// <li>Standard.H264.4K: H.264 4K transcoding</li>
        /// <li>Standard.H265.SD: H.265 SD transcoding</li>
        /// <li>Standard.H265.HD: H.265 HD transcoding</li>
        /// <li>Standard.H265.FHD: H.265 FHD transcoding</li>
        /// <li>Standard.H265.2K: H.265 2K transcoding</li>
        /// <li>Standard.H265.4K: H.265 4K transcoding</li>
        /// <li>TESHD-10.H264.SD: H.264 SD TESHD transcoding</li>
        /// <li>TESHD-10.H264.HD: H.264 HD TESHD transcoding</li>
        /// <li>TESHD-10.H264.FHD: H.264 FHD TESHD transcoding</li>
        /// <li>TESHD-10.H264.2K: H.264 2K TESHD transcoding</li>
        /// <li>TESHD-10.H264.4K: H.264 4K TESHD transcoding</li>
        /// <li>TESHD-10.H265.SD: H.265 SD TESHD transcoding</li>
        /// <li>TESHD-10.H265.HD: H.265 HD TESHD transcoding</li>
        /// <li>TESHD-10.H265.FHD: H.265 FHD TESHD transcoding</li>
        /// <li>TESHD-10.H265.2K: H.265 2K TESHD transcoding</li>
        /// <li>TESHD-10.H265.4K: H.265 4K TESHD transcoding</li>
        /// <li>Edit.Audio: audio editing</li>
        /// <li>Edit.H264.SD: H.264 SD video editing</li>
        /// <li>Edit.H264.HD: H.264 HD video editing</li>
        /// <li>Edit.H264.FHD: H.264 FHD video editing</li>
        /// <li>Edit.H264.2K: H.264 2K video editing</li>
        /// <li>Edit.H264.4K: H.264 4K video editing</li>
        /// <li>Edit.H265.SD: H.265 SD video editing</li>
        /// <li>Edit.H265.HD: H.265 HD video editing</li>
        /// <li>Edit.H265.FHD: H.265 FHD video editing</li>
        /// <li>Edit.H265.2K: H.265 2K video editing</li>
        /// <li>Edit.H265.4K: H.265 4K video editing</li>
        /// </summary>
        [JsonProperty("Details")]
        public SpecificationDataItem[] Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "Summary.", this.Summary);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
        }
    }
}

