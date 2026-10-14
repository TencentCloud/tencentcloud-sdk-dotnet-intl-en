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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexMetaField : AbstractModel
    {
        
        /// <summary>
        /// Index type
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// Index name
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// JSON-formatted index metadata
        /// </summary>
        [JsonProperty("IndexMetaJson")]
        public string IndexMetaJson{ get; set; }

        /// <summary>
        /// Index status
        /// </summary>
        [JsonProperty("IndexStatus")]
        public string IndexStatus{ get; set; }

        /// <summary>
        /// Index storage size in bytes
        /// </summary>
        [JsonProperty("IndexStorage")]
        public long? IndexStorage{ get; set; }

        /// <summary>
        /// Index creation time
        /// </summary>
        [JsonProperty("IndexCreateTime")]
        public string IndexCreateTime{ get; set; }

        /// <summary>
        /// Backup index
        /// </summary>
        [JsonProperty("BackingIndices")]
        public BackingIndexMetaField[] BackingIndices{ get; set; }

        /// <summary>
        /// Cluster ID of the index
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster name of the index
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Version number of the cluster to which the index belongs
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Index lifecycle field
        /// </summary>
        [JsonProperty("IndexPolicyField")]
        public IndexPolicyField IndexPolicyField{ get; set; }

        /// <summary>
        /// Index autonomous field
        /// </summary>
        [JsonProperty("IndexOptionsField")]
        public IndexOptionsField IndexOptionsField{ get; set; }

        /// <summary>
        /// Index configuration field
        /// </summary>
        [JsonProperty("IndexSettingsField")]
        public IndexSettingsField IndexSettingsField{ get; set; }

        /// <summary>
        /// Index alias field
        /// </summary>
        [JsonProperty("IndexAliasesField")]
        public string[] IndexAliasesField{ get; set; }

        /// <summary>
        /// APP ID of the cluster to which the index belongs
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Number of indexed documents
        /// </summary>
        [JsonProperty("IndexDocs")]
        public ulong? IndexDocs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "IndexMetaJson", this.IndexMetaJson);
            this.SetParamSimple(map, prefix + "IndexStatus", this.IndexStatus);
            this.SetParamSimple(map, prefix + "IndexStorage", this.IndexStorage);
            this.SetParamSimple(map, prefix + "IndexCreateTime", this.IndexCreateTime);
            this.SetParamArrayObj(map, prefix + "BackingIndices.", this.BackingIndices);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamObj(map, prefix + "IndexPolicyField.", this.IndexPolicyField);
            this.SetParamObj(map, prefix + "IndexOptionsField.", this.IndexOptionsField);
            this.SetParamObj(map, prefix + "IndexSettingsField.", this.IndexSettingsField);
            this.SetParamArraySimple(map, prefix + "IndexAliasesField.", this.IndexAliasesField);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IndexDocs", this.IndexDocs);
        }
    }
}

