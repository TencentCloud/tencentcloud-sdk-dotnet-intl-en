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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicInfo : AbstractModel
    {
        
        /// <summary>
        /// Logset ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        ///  Topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Topic Name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Number of topic partitions
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// Whether the topic has indexing enabled (the topic type must be log topic)
        /// </summary>
        [JsonProperty("Index")]
        public bool? Index{ get; set; }

        /// <summary>
        /// Cloud product identifier. When the topic is created by other cloud products, this field displays the name of the cloud product, such as CDN, TKE.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether the topic has log collection enabled. true: collection enabled; false: collection disabled.Log collection is enabled by default when creating a log topic, and this field can be modified by calling ModifyTopic through the SDK.The console currently does not support modifying this parameter.
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Tag information bound to the topicNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether automatic split is enabled for this topic
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// Maximum number of partitions to split into for this topic if automatic split is enabled
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// Storage type of the topicNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Lifecycle in days. Value range: 1-3600 (3640 indicates permanent retention)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Cloud product sub-identifier. If the log topic is created by another cloud product, this field returns the name of the cloud product and its log type, such as `TKE-Audit` or `TKE-Event`. Some products only return the cloud product identifier (`AssumerName`), without this field.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubAssumerName")]
        public string SubAssumerName{ get; set; }

        /// <summary>
        /// Topic description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// Enable log sinking, with the lifecycle of standard storage, where hotPeriod < Period.For standard storage, hotPeriod is used, and for infrequent access storage, it is Period-hotPeriod. (The topic type must be a log topic)HotPeriod=0 indicates that log sinking is not enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// Topic type.
        /// - 0:  log  Topic  
        /// - 1: Metric Topic
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// Free authentication switch. false: disabled; true: enabled.After enabling, anonymous access to the log topic will be supported for specified operations. For details, please refer to Log Topic (https://intl.cloud.tencent.com/document/product/614/41035?from_cn_redirect=1).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }


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
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "SubAssumerName", this.SubAssumerName);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
        }
    }
}

