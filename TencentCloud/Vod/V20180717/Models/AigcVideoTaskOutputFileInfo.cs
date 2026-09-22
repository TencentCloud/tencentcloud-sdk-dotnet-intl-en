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

    public class AigcVideoTaskOutputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Storage mode. Valid values: <li>Permanent: permanent storage;</li> <li>Temporary: temporary storage;</li><br>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output filename, up to 64 characters. By default, the system generates the filename. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID through the <a href="https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1">Create Category</a> API. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Expiry date of the output file. The file will be deleted after this time. It never expires by default. Format according to the ISO 8601 standard. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>File type, for example, mp4 or flv.</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>Media file playback address.</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>File content. A return value is returned when UsageType is position_info.</p>
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// <p>Media file ID. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Metadata of the output video.</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// <p>Purpose type of the file.</p><p>Enumeration values:</p><ul><li>scene_url: 3D scene file. The FileUrl field has a return value.</li><li>point_url: Point cloud file. The FileUrl field has a return value.</li><li>mesh_url: Original mesh model file. The FileUrl field has a return value.</li><li>mesh_simplified_url: Simplified mesh model file. The FileUrl field has a return value.</li><li>position_info: Scene spatial position information. The FileContent field has a return value.</li><li>image_url: Generated image. The FileUrl field has a return value.</li></ul>
        /// </summary>
        [JsonProperty("UsageType")]
        public string UsageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "UsageType", this.UsageType);
        }
    }
}

