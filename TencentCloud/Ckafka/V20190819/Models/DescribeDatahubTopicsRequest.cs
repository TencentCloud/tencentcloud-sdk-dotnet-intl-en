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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatahubTopicsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Search term</p><p>Performs fuzzy matching on the Name, TopicName, or TopicId field.</p>
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// <p>Offset position of this page, defaults to 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Maximum number of returned results this time</p><p>Value ranges from 1 to 100</p><p>Default value: 20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Whether to query the topic list from the connection query</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("QueryFromConnectResource")]
        public bool? QueryFromConnectResource{ get; set; }

        /// <summary>
        /// <p>Connection ID.</p>
        /// </summary>
        [JsonProperty("ConnectResourceId")]
        public string ConnectResourceId{ get; set; }

        /// <summary>
        /// <p>topic resource expression</p>
        /// </summary>
        [JsonProperty("TopicRegularExpression")]
        public string TopicRegularExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "QueryFromConnectResource", this.QueryFromConnectResource);
            this.SetParamSimple(map, prefix + "ConnectResourceId", this.ConnectResourceId);
            this.SetParamSimple(map, prefix + "TopicRegularExpression", this.TopicRegularExpression);
        }
    }
}

