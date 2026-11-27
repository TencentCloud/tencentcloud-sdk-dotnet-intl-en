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

    public class CreateDataFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>File system ID, which can be obtained through the API for querying file systems <a href="https://www.tencentcloud.com/document/product/582/38170?from_cn_redirect=1">DescribeCfsFileSystems</a>.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Source data type. Valid values: S3_COS and S3_L5.</p>
        /// </summary>
        [JsonProperty("SourceStorageType")]
        public string SourceStorageType{ get; set; }

        /// <summary>
        /// <p>Source storage address</p>
        /// </summary>
        [JsonProperty("SourceStorageAddress")]
        public string SourceStorageAddress{ get; set; }

        /// <summary>
        /// <p>Source path</p>
        /// </summary>
        [JsonProperty("SourcePath")]
        public string SourcePath{ get; set; }

        /// <summary>
        /// <p>Target path in the file system specified when setting data flow. It must start with /cfs/ and represents a logical path inside the file storage instance, not a local mount point path.<br>Example:</p><ul><li>If the CFS root directory / is mounted, and you need to map the source directory on object storage to test1/test2 under the mount path, the value of this parameter is /cfs/test1/test2.</li><li>If the CFS subdirectory /subdir is mounted, and you need to map the source directory on object storage to test1/test2 under the mount path, the value of this parameter is /cfs/subdir/test1/test2.</li></ul>
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// <p>Secret ID</p>
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// <p>Secret key</p>
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// <p>Data flow name. It supports up to 64 characters, including Chinese characters, digits, underscores (_), and hyphens (-).</p>
        /// </summary>
        [JsonProperty("DataFlowName")]
        public string DataFlowName{ get; set; }

        /// <summary>
        /// <p>0: Automatic update disabled. 1: Automatic update enabled.</p>
        /// </summary>
        [JsonProperty("AutoRefresh")]
        public ulong? AutoRefresh{ get; set; }

        /// <summary>
        /// <p>Topic parameter used by KafkaConsumer for consumption</p>
        /// </summary>
        [JsonProperty("UserKafkaTopic")]
        public string UserKafkaTopic{ get; set; }

        /// <summary>
        /// <p>Service address. Example: kafkaconsumer-ap-beijing.cls.tencentyun.com:9095</p>
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// <p>Kafka consumer username. Example: name</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Kafka consumer password. Default value: ${SecretId}#${SecretKey}.</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "SourceStorageType", this.SourceStorageType);
            this.SetParamSimple(map, prefix + "SourceStorageAddress", this.SourceStorageAddress);
            this.SetParamSimple(map, prefix + "SourcePath", this.SourcePath);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "DataFlowName", this.DataFlowName);
            this.SetParamSimple(map, prefix + "AutoRefresh", this.AutoRefresh);
            this.SetParamSimple(map, prefix + "UserKafkaTopic", this.UserKafkaTopic);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

