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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSOutputFile : AbstractModel
    {
        
        /// <summary>
        /// File type. Used to identify the specific return file in the execution results of MPS video processing tasks.
        /// Parameter Value: <li>AiAnalysis.DeLogo.Video: Video file generated after removal in an intelligent erasure task. Stored in the original file type by default.</li><li>AiAnalysis.DeLogo.OriginSubtitle: Subtitle file extracted from video in an intelligent erasure task.</li><li>AiAnalysis.DeLogo.TranslateSubtitle: Translation file of the subtitle extracted from video in an intelligent erasure task.</li><li>MediaProcess.Transcode.Video: Enhanced audio/video file in an audio and video enhancement task. Stored as a transcoded file type by default.</li>
        /// <li>AiAnalysis.HorizontalToVerticalTask.Video: Video file generated in the horizontal to vertical task, stored as an intelligent media type by default.</li>
        /// <li>AiAnalysis.VideoRemakeTaskk.Video: Video file generated in the intelligent deduplication task, stored as an intelligent media type by default.</li>
        /// <li>AiAnalysis.SegmentTask.Video: Video file generated in the intelligent splitting task, stored as an intelligent media type by default.</li>
        /// <li>SmartErase.Video: Video file generated in the intelligent erasure task. It is stored as an intelligent media type by default.</li>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Storage format. It is used to represent the storage format of the result file. Valid values: <li> Permanent: retained permanently;</li><li> Temporary: temporary storage.</li>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// Media file ID. Valid when Type is Permanent. It means the result file is stored in the VOD platform as a media asset, and the field value is the FileId of the media asset.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Downloadable Url of the result file.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Transcoding specification ID. Valid when FileType is equal to MediaProcess.Transcode.Video. A value of 0 represents the original file.
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }

        /// <summary>
        /// Expiration time. Valid when StorageMode is Temporary. It indicates the expiration time of the Url, in seconds.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public ulong? ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

