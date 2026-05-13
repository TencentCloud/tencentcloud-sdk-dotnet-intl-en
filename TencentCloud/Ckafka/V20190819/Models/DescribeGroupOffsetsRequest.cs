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

    public class DescribeGroupOffsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40835?from_cn_redirect=1">DescribeInstances</a></p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Kafka consumption group</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40840?from_cn_redirect=1">DescribeGroup</a></p>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>Name array of the subscribed topics for the group. If there is no array, it means all topic info under the designated group.</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40847?from_cn_redirect=1">DescribeTopic</a></p>
        /// </summary>
        [JsonProperty("Topics")]
        public string[] Topics{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching topicName</p>
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// <p>Offset position of this query, defaults to 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Maximum number of returned results this time. Default value: 50. Maximum value: 50.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamArraySimple(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

