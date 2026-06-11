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

    public class TopicInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Logset ID</p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>Topic ID</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Topic name</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>Topic partition count</p>
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// <p>Whether the topic has indexing enabled (the topic type must be log topic)</p>
        /// </summary>
        [JsonProperty("Index")]
        public bool? Index{ get; set; }

        /// <summary>
        /// <p>If AssumerUin is not empty, it indicates the Uin of the service provider creating the log topic</p>
        /// </summary>
        [JsonProperty("AssumerUin")]
        public ulong? AssumerUin{ get; set; }

        /// <summary>
        /// <p>Cloud product identifier. When the topic is created by other cloud products, this field displays the cloud product name, such as CDN, TKE.</p>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>Creation time. Format: yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Whether the topic has log collection enabled. true: enable collection; false: disable collection.<br>Enabled by default during log topic creation. You can modify this field via SDK invocation of ModifyTopic.<br>The console currently does not support modification of this parameter.</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>Tag information bound to the topic</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>If RoleName is not empty, it indicates the role used by the service provider creating the log topic</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// <p>Whether the topic has auto-split enabled</p>
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// <p>Maximum number of partitions allowed for the topic if auto-split is enabled</p>
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// <p>Storage type of the topic</p><ul><li>hot: standard storage</li><li>cold: infrequent storage</li></ul>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Lifecycle in days, valid values 1~3600. A value of 3640 indicates permanent retention.</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>Cloud product sub-identifier. When the log topic is created by other cloud products, this field displays the cloud product name and its log type sub-category, such as TKE-Audit, TKE-Event. Some cloud products only have the cloud product identifier (AssumerName) without this field.</p>
        /// </summary>
        [JsonProperty("SubAssumerName")]
        public string SubAssumerName{ get; set; }

        /// <summary>
        /// <p>Topic description</p>
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// <p>Enable log settlement, lifecycle of standard storage, hotPeriod &lt; Period.<br>Standard storage is hotPeriod, infrequent storage is Period-hotPeriod. (Topic type must be log topic)<br>HotPeriod=0 means log settlement is not enabled.</p>
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// <p>kms-cls service key id</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>Topic type.</p><ul><li>0: Log topic</li><li>1: Metric topic</li></ul>
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// <p>Free authentication switch. false: disabled; true: enabled.<br>Once enabled, designated operations will be supported for anonymous access to the log topic. See <a href="https://www.tencentcloud.com/document/product/614/41035?from_cn_redirect=1">log topic</a> for details.</p>
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }

        /// <summary>
        /// <p>Log topic extended information</p>
        /// </summary>
        [JsonProperty("Extends")]
        public TopicExtendInfo Extends{ get; set; }

        /// <summary>
        /// <p>Async migration task ID</p>
        /// </summary>
        [JsonProperty("TopicAsyncTaskID")]
        public string TopicAsyncTaskID{ get; set; }

        /// <summary>
        /// <p>Asynchronous migration status</p><ul><li>1: In progress</li><li>2: Completed</li><li>3: Failure</li><li>4: Canceled</li></ul>
        /// </summary>
        [JsonProperty("MigrationStatus")]
        public ulong? MigrationStatus{ get; set; }

        /// <summary>
        /// <p>After async migration, expected effective date<br>Time format: yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("EffectiveDate")]
        public string EffectiveDate{ get; set; }

        /// <summary>
        /// <p>IsSourceFrom Enable recording public network source IP and server receipt time</p>
        /// </summary>
        [JsonProperty("IsSourceFrom")]
        public bool? IsSourceFrom{ get; set; }

        /// <summary>
        /// <p>Current billing mode</p><p>Enumeration value:</p><ul><li>0: Function billing by usage</li><li>1: Billing by raw log size (currently supported for some customers only)</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public ulong? BillingMode{ get; set; }

        /// <summary>
        /// <p>If there is an async task, the new billing model after the task succeeds</p><p>Enumeration value:</p><ul><li>0: Function billing by usage</li><li>1: Billing by raw log size (currently only supported for some customers)</li></ul>
        /// </summary>
        [JsonProperty("NewBillingMode")]
        public ulong? NewBillingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "AssumerUin", this.AssumerUin);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "SubAssumerName", this.SubAssumerName);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
            this.SetParamObj(map, prefix + "Extends.", this.Extends);
            this.SetParamSimple(map, prefix + "TopicAsyncTaskID", this.TopicAsyncTaskID);
            this.SetParamSimple(map, prefix + "MigrationStatus", this.MigrationStatus);
            this.SetParamSimple(map, prefix + "EffectiveDate", this.EffectiveDate);
            this.SetParamSimple(map, prefix + "IsSourceFrom", this.IsSourceFrom);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "NewBillingMode", this.NewBillingMode);
        }
    }
}

