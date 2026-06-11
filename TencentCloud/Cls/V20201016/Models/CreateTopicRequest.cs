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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Logset ID</p><ul><li>Obtain the logset Id through <a href="https://www.tencentcloud.com/document/product/614/58624?from_cn_redirect=1">Get Logset List</a>.</li></ul>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>Topic name<br>Name limitation</p><ul><li>Cannot be an empty string</li><li>Cannot contain character '|'</li><li>Cannot use the following names ["cls_service_log","loglistener_status","loglistener_alarm","loglistener_business","cls_service_metric"]</li></ul>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>Topic partition count. Default creation is 1 partition. Supports a maximum of 10 partitions.</p>
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// <p>Tag description list, by specifying this parameter, you can simultaneously bind a tag to the corresponding topic. Up to 10 tag key-value pairs are supported, and the same resource can only be bound to the same tag key.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Whether to enable auto-split, true by default</p>
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// <p>When auto-split is enabled, the maximum number of partitions allowed for each topic is 50 by default.</p>
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// <p>Log topic storage type. Available values: hot (standard storage), cold (infrequent storage). Default hot. This configuration is not supported for metric topics.</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Storage time, in days.</p><ul><li>Log topic: When logs are collected to standard storage, the supported range is 1 to 3600 days. A value of 3640 indicates permanent retention.</li><li>Log topic: When logs are collected to infrequently accessed storage, the supported range is 7 to 3600 days. A value of 3640 indicates permanent retention.</li><li>Metric topic: The supported range is 1 to 3600 days. A value of 3640 indicates permanent retention.</li></ul>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>Topic description</p>
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// <p>0: Log topic disables log settlement.<br>Non-0: Number of days for standard storage after log settlement is enabled in the log topic. HotPeriod needs to be greater than or equal to 7 and less than Period.<br>Effective only when StorageType is hot. This configuration is not supported for metric topics.</p>
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// <p>Encryption-related parameters. Encrypted regions and allowlisted users can pass this parameter, which cannot be passed in other scenarios.<br>0 or not passed: no encryption<br>1: kms-cls cloud service key encryption</p><p>Supported regions: ap-beijing, ap-guangzhou, ap-shanghai, ap-singapore, ap-bangkok, ap-jakarta, eu-frankfurt, ap-seoul, ap-tokyo</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public ulong? Encryption{ get; set; }

        /// <summary>
        /// <p>Topic type</p><ul><li>0: Log topic, default value</li><li>1: Metric topic</li></ul>
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// <p>Custom topic ID, format: custom part-User APPID. If this parameter is left empty, ID will be automatically generated.</p><ul><li>The custom part only supports lowercase letters, digits, and -, cannot start or end with -, and must be 3 to 40 characters in length.</li><li>The trailing part requires the use of - to concatenate User APPID. APPID can be queried on the page https://console.cloud.tencent.com/developer.</li><li>If this field is specified, ensure uniqueness across all regions.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Free authentication switch. False: turned off; true: turned on. Default false.<br>When enabled, anonymous access to the log topic will be supported for designated operations. For details, see <a href="https://www.tencentcloud.com/document/product/614/41035?from_cn_redirect=1">log topic</a>. This configuration is not supported for metric topics.</p>
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }

        /// <summary>
        /// <p>Topic extended information</p>
        /// </summary>
        [JsonProperty("Extends")]
        public TopicExtendInfo Extends{ get; set; }

        /// <summary>
        /// <p>Enable logging of public network source IP and server receipt time</p>
        /// </summary>
        [JsonProperty("IsSourceFrom")]
        public bool? IsSourceFrom{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration value:</p><ul><li>0: Function billing by usage</li><li>1: Raw log size billing (currently only supported for some customers)</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public ulong? BillingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
            this.SetParamObj(map, prefix + "Extends.", this.Extends);
            this.SetParamSimple(map, prefix + "IsSourceFrom", this.IsSourceFrom);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
        }
    }
}

