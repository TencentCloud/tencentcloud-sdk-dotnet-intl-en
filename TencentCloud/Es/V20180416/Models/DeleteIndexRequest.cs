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

    public class DeleteIndexRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ES cluster ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Deleted index type. auto: autonomous index; normal: general index</p>
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// <p>Name of the deleted index</p>
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>Cluster access username.</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Cluster access password</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Backing index name</p>
        /// </summary>
        [JsonProperty("BackingIndexName")]
        public string BackingIndexName{ get; set; }

        /// <summary>
        /// <p>Index life cycle</p>
        /// </summary>
        [JsonProperty("IndexPhrase")]
        public string IndexPhrase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "BackingIndexName", this.BackingIndexName);
            this.SetParamSimple(map, prefix + "IndexPhrase", this.IndexPhrase);
        }
    }
}

