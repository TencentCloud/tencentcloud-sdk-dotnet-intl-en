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

    public class FileContent : AbstractModel
    {
        
        /// <summary>
        /// Object key.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Last modification time in ISO8601 format, such as 2019-05-24T10:56:40Z.
        /// </summary>
        [JsonProperty("LastModified")]
        public string LastModified{ get; set; }

        /// <summary>
        /// The Entity Tag of an object is an information Tag that identifies the object content when the object is created. It can be used to check whether the object content has changed.
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// Object size in bytes.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// For enumeration values, please refer to the storage type document (https://www.tencentcloud.com/document/product/436/33417?from_cn_redirect=1), such as STANDARD_IA and ARCHIVE.
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }

        /// <summary>
        /// Unique identifier of the media file for this file.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// File classification: <li>Video: video file</li> <li>Audio: audio file</li> <li>Image: image file</li> <li>Other: other files</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Optional values:
        /// -OriginalFiles: source file
        /// -TranscodeFiles: transcoded file
        /// -AdaptiveDynamicStreamingFiles: Convert to adaptive bitrate stream file.
        /// -SubtitleFiles: Subtitle file
        /// -SampleSnapshotFiles: sampled screenshot files.
        /// -ImageSpriteFiles: Sprite image screenshot files
        /// -SnapshotByTimeOffsetFiles: Time point screenshot files.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Video template ID. For template definition, please refer to transcoding template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Subtitle ID.
        /// Only valid when FileType=SubtitleFiles.
        /// </summary>
        [JsonProperty("SubtitleID")]
        public string SubtitleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "LastModified", this.LastModified);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubtitleID", this.SubtitleID);
        }
    }
}

