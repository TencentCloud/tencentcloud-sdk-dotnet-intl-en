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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCmqTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// Topic name, which must be unique under the same account in a single region. The name is a string of no more than 64 characters, starting with a letter, and the remaining part may include letters, numbers, and hyphens (-).
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Maximum message length. Value range: 1024–65536 bytes (i.e., 1–64 KB). Default value: 65536.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Used to specify the message match policy for the topic. 1: tag match policy (default value); 2: routing match policy.
        /// </summary>
        [JsonProperty("FilterType")]
        public ulong? FilterType{ get; set; }

        /// <summary>
        /// Message retention period. Value range: 60–86400 seconds (i.e., 1 minute–1 day). Default value: 86400.
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Whether to enable message trace. true: yes; false: no. If this field is left empty, the feature will not be enabled.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// Tag array.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

