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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSplunkDeliverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>log topic id</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Log Topic List</a>.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>The splunk delivery task name has the following restrictions: - Cannot be empty - Length not greater than 256 - Can only contain aA-zZ, underscore, -, 0-9</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Splunk delivery task - target configuration - network info</p>
        /// </summary>
        [JsonProperty("NetInfo")]
        public NetInfo NetInfo{ get; set; }

        /// <summary>
        /// <p>Splunk delivery task meta information</p>
        /// </summary>
        [JsonProperty("MetadataInfo")]
        public MetadataInfo MetadataInfo{ get; set; }

        /// <summary>
        /// <p>Whether service logs are enabled 1: Disabled; 2: Enabled; Enabled by default</p>
        /// </summary>
        [JsonProperty("HasServiceLog")]
        public long? HasServiceLog{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - Whether to enable the indexer; 1 - Disable; 2 - Enable;<br>Default: 1</p>
        /// </summary>
        [JsonProperty("IndexAck")]
        public long? IndexAck{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - data source; no more than 64 characters</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - data source type; no more than 64 characters</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - Indexes written to Splunk; no more than 64 characters</p>
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - Channel.<br>To meet the limitation: If the indexer is enabled, then Channel is required.</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>Log pre-filtering - filter out original data before writing to Splunk</p>
        /// </summary>
        [JsonProperty("DSLFilter")]
        public string DSLFilter{ get; set; }

        /// <summary>
        /// <p>Advanced configuration - Cross-account delivery user role authorization information</p><p>For reference: <a href="https://console.cloud.tencent.com/cam/role/create?payloadType=account">Create custom role</a></p>
        /// </summary>
        [JsonProperty("ExternalRole")]
        public ExternalRole ExternalRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "NetInfo.", this.NetInfo);
            this.SetParamObj(map, prefix + "MetadataInfo.", this.MetadataInfo);
            this.SetParamSimple(map, prefix + "HasServiceLog", this.HasServiceLog);
            this.SetParamSimple(map, prefix + "IndexAck", this.IndexAck);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "DSLFilter", this.DSLFilter);
            this.SetParamObj(map, prefix + "ExternalRole.", this.ExternalRole);
        }
    }
}

