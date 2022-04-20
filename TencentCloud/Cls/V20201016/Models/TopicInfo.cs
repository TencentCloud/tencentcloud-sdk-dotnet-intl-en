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
        /// Log topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Log topic name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Number of topic partitions
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// Whether index is enabled
        /// </summary>
        [JsonProperty("Index")]
        public bool? Index{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether collection is enabled in the log topic
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Information of tags bound to log topic
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
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
        /// Log topic storage class
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

