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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Migration task name.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Migration mode flag. Default value: 0. 0: Bucket migration; 1: Inventory migration.</p>
        /// </summary>
        [JsonProperty("MigrationType")]
        public ulong? MigrationType{ get; set; }

        /// <summary>
        /// <p>Migration mode. Default value: 0. 0: Full migration.</p>
        /// </summary>
        [JsonProperty("MigrationMode")]
        public ulong? MigrationMode{ get; set; }

        /// <summary>
        /// <p>SecretId of the data source account.</p>
        /// </summary>
        [JsonProperty("SrcSecretId")]
        public string SrcSecretId{ get; set; }

        /// <summary>
        /// <p>SecretKey of the data source account.</p>
        /// </summary>
        [JsonProperty("SrcSecretKey")]
        public string SrcSecretKey{ get; set; }

        /// <summary>
        /// <p>File system instance ID, which can be obtained through <a href="https://www.tencentcloud.com/document/product/582/38170?from_cn_redirect=1">DescribeCfsFileSystems</a>.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Directory path in the file system. It does not involve the actual mounted subdirectory or root directory, and does not need to be prefixed with /cfs/.</p>
        /// </summary>
        [JsonProperty("FsPath")]
        public string FsPath{ get; set; }

        /// <summary>
        /// <p>Overwrite policy for files with the same name during migration. Default value: 0. 0: The file with the latest modification time takes precedence; 1: Full overwrite; 2: No overwrite.</p>
        /// </summary>
        [JsonProperty("CoverType")]
        public ulong? CoverType{ get; set; }

        /// <summary>
        /// <p>Data source service provider.</p><p>Valid values:</p><ul><li>COS: Tencent Cloud COS</li><li>OSS: Alibaba Cloud OSS</li><li>OBS: Huawei Cloud OBS</li><li>BOS: Baidu Cloud BOS</li><li>TOS: Volcano Engine TOS</li></ul>
        /// </summary>
        [JsonProperty("SrcService")]
        public string SrcService{ get; set; }

        /// <summary>
        /// <p>Name of the data source bucket. For bucket migration, either BucketName or BucketAddress is required. For inventory migration, this parameter is not required.</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>Region of the data source bucket.</p>
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// <p>Address of the data source bucket. For bucket migration, either BucketName or BucketAddress is required. For inventory migration, this parameter is not required.</p>
        /// </summary>
        [JsonProperty("BucketAddress")]
        public string BucketAddress{ get; set; }

        /// <summary>
        /// <p>Inventory address. Required when the migration mode is inventory migration.</p>
        /// </summary>
        [JsonProperty("ListAddress")]
        public string ListAddress{ get; set; }

        /// <summary>
        /// <p>Name of the destination file system.</p>
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// <p>Source bucket path. Default value: /.</p>
        /// </summary>
        [JsonProperty("BucketPath")]
        public string BucketPath{ get; set; }

        /// <summary>
        /// <p>Migration direction. 0: Migrate from object storage to file system. 1: Migrate from file system to object storage. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamSimple(map, prefix + "MigrationMode", this.MigrationMode);
            this.SetParamSimple(map, prefix + "SrcSecretId", this.SrcSecretId);
            this.SetParamSimple(map, prefix + "SrcSecretKey", this.SrcSecretKey);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FsPath", this.FsPath);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "SrcService", this.SrcService);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketAddress", this.BucketAddress);
            this.SetParamSimple(map, prefix + "ListAddress", this.ListAddress);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "BucketPath", this.BucketPath);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

