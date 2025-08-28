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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePublishSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. For example, mssql-j8kv137v.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Publish/subscribe instance ID, which is related to whether InstanceId is a publishing instance or a subscription instance. When the value of InstanceId is a publishing instance, filtering by subscription instance ID is performed for this field. When the value of InstanceId is a subscription instance, filtering by publishing instance ID is performed for this field.
        /// </summary>
        [JsonProperty("PubOrSubInstanceId")]
        public string PubOrSubInstanceId{ get; set; }

        /// <summary>
        /// Private address of the publish/subscribe instance, which is related to whether InstanceId is a publishing instance or a subscription instance. When the value of InstanceId is a publishing instance, filtering by private IP address of the subscription instance is performed for this field. When the value of InstanceId is a subscription instance, filtering by private IP address of the publishing instance is performed for this field.
        /// </summary>
        [JsonProperty("PubOrSubInstanceIp")]
        public string PubOrSubInstanceIp{ get; set; }

        /// <summary>
        /// Publish/subscribe ID, which is used for filtering.
        /// </summary>
        [JsonProperty("PublishSubscribeId")]
        public ulong? PublishSubscribeId{ get; set; }

        /// <summary>
        /// Publish/subscribe name, which is used for filtering.
        /// </summary>
        [JsonProperty("PublishSubscribeName")]
        public string PublishSubscribeName{ get; set; }

        /// <summary>
        /// Publishing database name, which is used for filtering.
        /// </summary>
        [JsonProperty("PublishDBName")]
        public string PublishDBName{ get; set; }

        /// <summary>
        /// Subscription database name, which is used for filtering.
        /// </summary>
        [JsonProperty("SubscribeDBName")]
        public string SubscribeDBName{ get; set; }

        /// <summary>
        /// Pagination number.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Pagination size.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PubOrSubInstanceId", this.PubOrSubInstanceId);
            this.SetParamSimple(map, prefix + "PubOrSubInstanceIp", this.PubOrSubInstanceIp);
            this.SetParamSimple(map, prefix + "PublishSubscribeId", this.PublishSubscribeId);
            this.SetParamSimple(map, prefix + "PublishSubscribeName", this.PublishSubscribeName);
            this.SetParamSimple(map, prefix + "PublishDBName", this.PublishDBName);
            this.SetParamSimple(map, prefix + "SubscribeDBName", this.SubscribeDBName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

