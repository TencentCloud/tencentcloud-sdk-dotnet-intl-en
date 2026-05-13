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

    public class BatchModifyGroupOffsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Consumer group name</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>ckafka cluster instance Id</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40835?from_cn_redirect=1">DescribeInstances</a></p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>partition info</p>
        /// </summary>
        [JsonProperty("Partitions")]
        public Partitions[] Partitions{ get; set; }

        /// <summary>
        /// <p>Specify topic, default to all topics</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string[] TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamArraySimple(map, prefix + "TopicName.", this.TopicName);
        }
    }
}

