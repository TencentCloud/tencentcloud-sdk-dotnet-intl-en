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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Library : AbstractModel
    {
        
        /// <summary>
        /// Media library ID.
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// Specifies the friendly name of the media library.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies the COS storage bucket bound to the media library.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Specifies the region where the COS bucket bound to the media library is located.
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// Specifies the access domain of the business API for the media library.
        /// </summary>
        [JsonProperty("AccessDomain")]
        public string AccessDomain{ get; set; }

        /// <summary>
        /// Creation time of the media library.
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Media library configuration item.
        /// </summary>
        [JsonProperty("LibraryExtension")]
        public LibraryExtension LibraryExtension{ get; set; }

        /// <summary>
        /// Media library amount in Bytes. since the number type has precision limitations, this field is a String type.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Number of media library directories. since the String type is used due to precision limitations of the number type, this field is of String type.
        /// </summary>
        [JsonProperty("DirNum")]
        public string DirNum{ get; set; }

        /// <summary>
        /// Number of files in the media library. since the String type is used due to precision limitations of the number type, this field is of String type.
        /// </summary>
        [JsonProperty("FileNum")]
        public string FileNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "AccessDomain", this.AccessDomain);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamObj(map, prefix + "LibraryExtension.", this.LibraryExtension);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "DirNum", this.DirNum);
            this.SetParamSimple(map, prefix + "FileNum", this.FileNum);
        }
    }
}

