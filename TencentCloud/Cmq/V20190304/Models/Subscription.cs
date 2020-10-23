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

    public class Subscription : AbstractModel
    {
        
        /// <summary>
        /// SubscriptionName
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// SubscriptionId
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscriptionId")]
        public string SubscriptionId{ get; set; }

        /// <summary>
        /// TopicOwner
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicOwner")]
        public ulong? TopicOwner{ get; set; }

        /// <summary>
        /// MsgCount
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// LastModifyTime
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// CreateTime
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// BindingKey
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindingKey")]
        public string[] BindingKey{ get; set; }

        /// <summary>
        /// Endpoint
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// FilterTags
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilterTags")]
        public string[] FilterTags{ get; set; }

        /// <summary>
        /// Protocol
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// NotifyStrategy
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotifyStrategy")]
        public string NotifyStrategy{ get; set; }

        /// <summary>
        /// NotifyContentFormat
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotifyContentFormat")]
        public string NotifyContentFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "SubscriptionId", this.SubscriptionId);
            this.SetParamSimple(map, prefix + "TopicOwner", this.TopicOwner);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "BindingKey.", this.BindingKey);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamArraySimple(map, prefix + "FilterTags.", this.FilterTags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "NotifyStrategy", this.NotifyStrategy);
            this.SetParamSimple(map, prefix + "NotifyContentFormat", this.NotifyContentFormat);
        }
    }
}

