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
        /// File system ID, which can be obtained by querying the file system through the [DescribeCfsFileSystems](https://www.tencentcloud.com/document/product/582/38170?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// Source data type; includes S3_COS, S3_L5.
        /// </summary>
        [JsonProperty("SourceStorageType")]
        public string SourceStorageType{ get; set; }

        /// <summary>
        /// Source storage address.
        /// </summary>
        [JsonProperty("SourceStorageAddress")]
        public string SourceStorageAddress{ get; set; }

        /// <summary>
        /// Source path.
        /// </summary>
        [JsonProperty("SourcePath")]
        public string SourcePath{ get; set; }

        /// <summary>
        /// Target path in the file system.
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// Key ID.
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// key.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Data flow name, supports no more than 64 characters in length, supports chinese, numbers, _, and -.
        /// </summary>
        [JsonProperty("DataFlowName")]
        public string DataFlowName{ get; set; }

        /// <summary>
        /// 0: disable auto-update  1: enable auto-update.
        /// </summary>
        [JsonProperty("AutoRefresh")]
        public ulong? AutoRefresh{ get; set; }

        /// <summary>
        /// Topic Parameter used by KafkaConsumer during consumption
        /// </summary>
        [JsonProperty("UserKafkaTopic")]
        public string UserKafkaTopic{ get; set; }

        /// <summary>
        /// 	Service address example value: kafkaconsumer-ap-beijing.cls.tencentyun.com:9095.
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// Kafka consuming user name. example value: name.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Kafka consuming user password. default ${SecretId}#${SecretKey}.
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

