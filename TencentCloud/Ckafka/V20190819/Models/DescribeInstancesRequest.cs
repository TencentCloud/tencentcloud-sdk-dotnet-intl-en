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

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>(Query Conditions) Filter by cluster instance Id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Search term  ex: (Query condition) Filter by instance name. Fuzzy query is supported.</p>
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// <p>(Query condition) Instance status. Returns all by default if left blank.</p><p>Enumeration value:</p><ul><li>-1: Creation failed</li><li>0:Creating</li><li>1:Running</li><li>2:Deleting</li><li>3:Deleted</li><li>4:Deletion failure</li><li>5:Isolated</li><li>7:Upgrading</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// <p>Offset, which is 0 by default</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned results. Default value: 10. Maximum value: 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Abandoned. Match the tag key.</p>
        /// </summary>
        [JsonProperty("TagKey")]
        [System.Obsolete]
        public string TagKey{ get; set; }

        /// <summary>
        /// <p>(Query condition) VPC Id</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

