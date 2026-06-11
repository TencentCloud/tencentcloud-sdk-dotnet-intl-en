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

    public class ModifyTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Topic ID - Obtain the topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Topic List</a>.</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Topic name<br>Input restrictions:</p><ul><li>Cannot be an empty string</li><li>Cannot contain character '|'</li><li>Cannot use the following names ["cls_service_log","loglistener_status","loglistener_alarm","loglistener_business","cls_service_metric"]</li></ul>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>List of tag descriptions. By specifying this parameter, you can bind tags to the appropriate topic simultaneously. Supports up to 10 tag key-value pairs, and no duplicate key-value pairs are allowed.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Whether the topic has log collection enabled. true: start collection; false: disable collection.<br>The console currently does not support modification of this parameter.</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>Whether to enable auto-split</p>
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// <p>If maximum split is enabled, the maximum number of partitions allowed for this topic;<br>default is 50; must be a positive number</p>
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// <p>Lifecycle in days. Standard storage value range is 1-3600. Infrequent storage value range is 7-3600. A value of 3640 indicates permanent retention.</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>Storage type: cold infrequent storage, hot standard storage</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Topic description</p>
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// <p>0: The log topic disables log settlement.<br>Non-0: Number of days for standard storage after log settlement is enabled for the log topic. HotPeriod needs to be greater than or equal to 7 and less than Period.<br>Effective only when StorageType is hot. This configuration is not supported for metric topics.</p>
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// <p>Free authentication switch. false: disabled; true: enabled.<br>Once enabled, anonymous access to the log topic will be supported for specified operations. For details, please see <a href="https://www.tencentcloud.com/document/product/614/41035?from_cn_redirect=1">log topic</a>.</p>
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }

        /// <summary>
        /// <p>Topic extended information</p>
        /// </summary>
        [JsonProperty("Extends")]
        public TopicExtendInfo Extends{ get; set; }

        /// <summary>
        /// <p>Number of topic partitions.<br>Defaults to 1.<br>Value ranges and constraints:</p><ul><li>When the input value &lt;=0, the system automatically adjusts it to 1.</li><li>If MaxSplitPartitions is not passed, PartitionCount must be &lt;=50.</li><li>If MaxSplitPartitions is passed, PartitionCount must be &lt;=MaxSplitPartitions.</li></ul>
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// <p>id of the cancel switch storage task</p><ul><li>Obtain the id of the cancel switch storage task [TopicAsyncTaskID field in Topics] by <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">get log topic list</a>.</li></ul>
        /// </summary>
        [JsonProperty("CancelTopicAsyncTaskID")]
        public string CancelTopicAsyncTaskID{ get; set; }

        /// <summary>
        /// <p>Encryption-related parameters. Encrypted regions are supported and can be passed for allowlisted users. Cannot be passed in other scenarios.<br>Only support passing in 1: kms-cls secret key for cloud product encryption.</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public ulong? Encryption{ get; set; }

        /// <summary>
        /// <p>Enable logging of public network source IP and server receipt time</p>
        /// </summary>
        [JsonProperty("IsSourceFrom")]
        public bool? IsSourceFrom{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration value:</p><ul><li>0: Function billing by usage</li><li>1: Raw log size billing (currently only supports some customers)</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public ulong? BillingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
            this.SetParamObj(map, prefix + "Extends.", this.Extends);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "CancelTopicAsyncTaskID", this.CancelTopicAsyncTaskID);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "IsSourceFrom", this.IsSourceFrom);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
        }
    }
}

