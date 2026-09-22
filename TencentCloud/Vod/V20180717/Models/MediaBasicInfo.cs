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

    public class MediaBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// Media file name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Media file description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Media file creation time. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest update time of the media file (operations such as modifying video attributes and initiating video processing will trigger updates to the media file information), in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Expiry date of the media file in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I). After expiry, the media file and its related resources (transcoding results, sprites) will be permanently deleted. "9999-12-31T23:59:59Z" means it never expires.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Category ID of the media file.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Category name of the media file.
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// Category path of the media file. Categories are separated by "-", for example "new first-level category - new sub-category".
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// Thumbnail URL of the media file.
        /// </summary>
        [JsonProperty("CoverUrl")]
        public string CoverUrl{ get; set; }

        /// <summary>
        /// Muxing format of the media file, for example, mp4 and flv.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// URL address of the original media file.
        /// </summary>
        [JsonProperty("MediaUrl")]
        public string MediaUrl{ get; set; }

        /// <summary>
        /// Source information of the media file.
        /// </summary>
        [JsonProperty("SourceInfo")]
        public MediaSourceData SourceInfo{ get; set; }

        /// <summary>
        /// Media file storage region, such as ap-chongqing. See region list (https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E5.B7.B2.E6.94.AF.E6.8C.81.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8).
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// Media storage path.
        /// </summary>
        [JsonProperty("StoragePath")]
        public string StoragePath{ get; set; }

        /// <summary>
        /// Tag information of the media file.
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }

        /// <summary>
        /// Unique identifier of the live streaming recording file.
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// File type:
        /// <li>Video: video file</li>
        /// <li>Audio: audio file</li>
        /// <li>Image: image file</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// File status: Normal: normal, Forbidden: blocked.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Storage class of a media file
        /// <li> STANDARD: standard storage.</li>
        /// <li> STANDARD_IA: Infrequent storage.</li>
        /// <li> ARCHIVE: Archive storage.</li>
        /// <li> DEEP_ARCHIVE: deep archive storage.</li>
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamSimple(map, prefix + "CoverUrl", this.CoverUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MediaUrl", this.MediaUrl);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "StoragePath", this.StoragePath);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
        }
    }
}

