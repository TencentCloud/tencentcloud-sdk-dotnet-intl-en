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

    public class CreateResourceFileRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Resource file name. should be consistent with the uploaded file name.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Bucket name. can be obtained from the GetResourceCosPath api.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// BucketName specifies the cos storage bucket region.
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// Upload path for resource files in the project. value example: /wedata/qxxxm/. root directory, please use /.
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// -Upload file and manual entry are two methods, choose one. if both are provided, the sequence is file > manual entry.
        /// -The manually entered value must be an existing cos path. /datastudio/resource/ is the fixed prefix. projectId is the project ID. import a specific value. parentFolderPath is the folder path. name is the file name. value example: /datastudio/resource/projectId/parentFolderPath/name. 
        /// </summary>
        [JsonProperty("ResourceFile")]
        public string ResourceFile{ get; set; }

        /// <summary>
        /// Bundle Client ID.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// bundle client info.
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "ResourceFile", this.ResourceFile);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

