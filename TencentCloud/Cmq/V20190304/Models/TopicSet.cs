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

    public class TopicSet : AbstractModel
    {
        
        /// <summary>
        /// TopicId
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// TopicName
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// MsgRetentionSeconds
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// MaxMsgSize
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Qps
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// FilterType
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilterType")]
        public ulong? FilterType{ get; set; }

        /// <summary>
        /// CreateTime
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// LastModifyTime
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// MsgCount
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// CreateUin
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// Tags
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether to enable message trace for a topic. true: yes, false: no
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
        }
    }
}

