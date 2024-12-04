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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceLogDeliveryRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Log type. Currently, only slowlog is supported, indicating the slow query log.
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Whether log shopping is enabled.
        /// - true: enabled.
        /// - false: disabled.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// ID of the shipped logset, which can be obtained through the sub-parameter **LogsetId** of the response parameter **SlowLog** of the API [DescribeInstanceLogDelivery](https://intl.cloud.tencent.com/document/product/239/110878?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// ID of the shipped log topic, which can be obtained through the sub-parameter **TopicId** of the response parameter **SlowLog** of the API [DescribeInstanceLogDelivery](https://intl.cloud.tencent.com/document/product/239/110878?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Logset name. If **LogsetId** is not specified, this parameter needs to be configured and the system will automatically create a logset with the specified name.
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// Log topic name. This parameter is required when TopicId is empty, and the system will automatically create a log topic.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Region where the logset is located. If it is not provided, the region where the instance is located will be used by default.
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// Log storage duration. Default value: 30 days. Value range: 1 to 3600 days.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Whether to create an index when creating a log topic.
        /// </summary>
        [JsonProperty("CreateIndex")]
        public bool? CreateIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "CreateIndex", this.CreateIndex);
        }
    }
}

