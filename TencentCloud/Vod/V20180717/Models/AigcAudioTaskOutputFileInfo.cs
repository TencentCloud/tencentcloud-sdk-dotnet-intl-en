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

    public class AigcAudioTaskOutputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Storage mode. Valid values: <li>Permanent: permanent storage;</li> <li>Temporary: temporary storage;</li><br>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output filename, up to 64 characters. By default, the system specifies the generated filename. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID through the <a href="https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1">Create Category</a> API. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Expiry date of the output file. The file will be deleted after this time. It is permanent with no expiration by default. The format is based on ISO 8601. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>File type, for example, mp4 and flv.</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>Media file playback address.</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>Media file ID. Valid when StorageMode is Permanent.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Meta-information of the output audio.</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// <p>Duration</p><p>Unit: second</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }


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
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

