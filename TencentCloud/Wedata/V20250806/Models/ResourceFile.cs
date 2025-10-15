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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceFile : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Resource file ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Resource file name.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Source file path.
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }

        /// <summary>
        /// Specifies the COS storage path of the resource object.
        /// </summary>
        [JsonProperty("RemotePath")]
        public string RemotePath{ get; set; }

        /// <summary>
        /// Specifies the resource file type.
        /// </summary>
        [JsonProperty("FileExtensionType")]
        public string FileExtensionType{ get; set; }

        /// <summary>
        /// Resource size
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Creator user ID 
        /// </summary>
        [JsonProperty("CreatorUserUin")]
        public string CreatorUserUin{ get; set; }

        /// <summary>
        /// Creator name
        /// </summary>
        [JsonProperty("CreatorUserName")]
        public string CreatorUserName{ get; set; }

        /// <summary>
        /// Last updated username.
        /// </summary>
        [JsonProperty("UpdateUserName")]
        public string UpdateUserName{ get; set; }

        /// <summary>
        /// Last updated user ID.
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// COS bucket.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// COS region
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// Specifies the resource source mode.
        /// </summary>
        [JsonProperty("ResourceSourceMode")]
        public string ResourceSourceMode{ get; set; }

        /// <summary>
        /// Local project ID.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Local project information.
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
            this.SetParamSimple(map, prefix + "RemotePath", this.RemotePath);
            this.SetParamSimple(map, prefix + "FileExtensionType", this.FileExtensionType);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "CreatorUserUin", this.CreatorUserUin);
            this.SetParamSimple(map, prefix + "CreatorUserName", this.CreatorUserName);
            this.SetParamSimple(map, prefix + "UpdateUserName", this.UpdateUserName);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "ResourceSourceMode", this.ResourceSourceMode);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

