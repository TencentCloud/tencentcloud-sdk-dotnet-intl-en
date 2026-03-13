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
        /// Migration task name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Migration method flags, default is 0. 0: bucket migration; 1: inventory migration.
        /// </summary>
        [JsonProperty("MigrationType")]
        public ulong? MigrationType{ get; set; }

        /// <summary>
        /// Migration mode. Default value: `0` (full migration).
        /// </summary>
        [JsonProperty("MigrationMode")]
        public ulong? MigrationMode{ get; set; }

        /// <summary>
        /// SecretId of the data source account.
        /// </summary>
        [JsonProperty("SrcSecretId")]
        public string SrcSecretId{ get; set; }

        /// <summary>
        /// SecretKey of the data source account.
        /// </summary>
        [JsonProperty("SrcSecretKey")]
        public string SrcSecretKey{ get; set; }

        /// <summary>
        /// File system instance ID, which can be obtained by querying the file system through the [DescribeCfsFileSystems](https://www.tencentcloud.com/document/product/582/38170?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// File system path
        /// </summary>
        [JsonProperty("FsPath")]
        public string FsPath{ get; set; }

        /// <summary>
        /// Overwrite policy for files with the same name. Valid values: `0` (retain the file with the latest modified time), `1` (overwrite); and `2` (not overwrite). Default value: `0`.
        /// </summary>
        [JsonProperty("CoverType")]
        public ulong? CoverType{ get; set; }

        /// <summary>
        /// Data source service providers. COS: tencent cloud COS, OSS: alibaba cloud OSS, OBS: huawei cloud OBS.
        /// </summary>
        [JsonProperty("SrcService")]
        public string SrcService{ get; set; }

        /// <summary>
        /// Data source bucket name. specifies the bucket name for migration. either BucketName or BucketAddress is required for bucket migration. this parameter is not required for inventory migration.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Data source bucket region
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// Source bucket address. specifies the bucket address of the data source. for bucket migration, either BucketName or BucketAddress is required. this parameter is not required for inventory migration.
        /// </summary>
        [JsonProperty("BucketAddress")]
        public string BucketAddress{ get; set; }

        /// <summary>
        /// List address. This parameter is required if `MigrationType` is set to `1` (list).
        /// </summary>
        [JsonProperty("ListAddress")]
        public string ListAddress{ get; set; }

        /// <summary>
        /// Target file system name
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// Source bucket path, defaults to /.
        /// </summary>
        [JsonProperty("BucketPath")]
        public string BucketPath{ get; set; }

        /// <summary>
        /// Migration direction. valid values: 0 (cos migration to file system), 1 (file system migration to cos). default is 0.
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

