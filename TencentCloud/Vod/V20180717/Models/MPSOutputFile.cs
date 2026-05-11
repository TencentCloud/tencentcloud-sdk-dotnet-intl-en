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
        /// File type. Used to identify specific return files in the execution result of an MPS video processing task.
        /// Value: <li>AiAnalysis.DeLogo.Video: The erased video file generated in the intelligent erasure task, stored in the original file type by default;</li> <li>AiAnalysis.DeLogo.OriginSubtitle: The subtitle file extracted from video in the intelligent erasure task;</li> <li>AiAnalysis.DeLogo.TranslateSubtitle: The translation file of subtitles extracted from video in the intelligent erasure task.</li> <li>MediaProcess.Transcode.Video: The enhanced audio and video file in the audio and video enhancement task, stored in the transcoded file type by default.</li>
        /// <li>AiAnalysis.HorizontalToVerticalTask.Video: The generated video file in the horizontal to vertical task is stored as an intelligent media type by default.</li>
        /// <li>AiAnalysis.VideoRemakeTaskk.Video: The generated video file in the intelligent deduplication task, stored as an intelligent media type by default.</li>
        /// <li>AiAnalysis.SegmentTask.Video: Generated video file in the intelligent video splitting task, stored as intelligent media type by default.</li>
        /// <li>SmartErase.Video: Generated video file in the intelligent erasure task, stored as intelligent media type by default.</li>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Storage format. To represent the storage format of the result file. Valid values: <li>Permanent: permanent storage;</li> <li>Temporary: temporary storage.</li>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// Media file ID. Valid when Type is Permanent, indicating that the result file is stored as a media asset on the VOD platform, with the field value being the FileId of the media asset.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Downloadable Url of the result file.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Transcoding specification ID. Valid when FileType equals MediaProcess.Transcode.Video. A value of 0 means the original file.
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }

        /// <summary>
        /// Expiration time. Valid when StorageMode is Temporary, indicates the expiry date of the Url, in seconds.
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

