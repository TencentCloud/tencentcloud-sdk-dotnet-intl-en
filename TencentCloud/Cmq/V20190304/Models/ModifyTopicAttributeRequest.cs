/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cmq.V20190304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTopicAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Topic name, which is unique under the same account in an individual region. It is a string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`).
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Maximum message length. Value range: 1024–65536 bytes (i.e., 1–64 KB). Default value: 65536.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Message retention period. Value range: 60–86400 seconds (i.e., 1 minute–1 day). Default value: 86400.
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Whether to enable message trace. true: yes, false: no. If this field is left empty, the feature will not be enabled.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
        }
    }
}

