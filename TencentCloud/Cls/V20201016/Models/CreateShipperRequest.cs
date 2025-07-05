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

    public class CreateShipperRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the log topic to which the shipping rule to be created belongs
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Destination bucket in the shipping rule to be created
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// Prefix of the shipping directory in the shipping rule to be created
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// Shipping rule name
        /// </summary>
        [JsonProperty("ShipperName")]
        public string ShipperName{ get; set; }

        /// <summary>
        /// Interval between shipping tasks (in sec). Default value: 300. Value range: 300-900
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Maximum size of a file to be shipped, in MB. Default value: 256. Value range: 5-256
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// Filter rules for shipped logs. Only logs matching the rules can be shipped. All rules are in the AND relationship, and up to five rules can be added. If the array is empty, no filtering will be performed, and all logs will be shipped.
        /// </summary>
        [JsonProperty("FilterRules")]
        public FilterRuleInfo[] FilterRules{ get; set; }

        /// <summary>
        /// Rules for partitioning logs to be shipped. `strftime` can be used to define the presentation of time format.
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// Compression configuration of shipped log
        /// </summary>
        [JsonProperty("Compress")]
        public CompressInfo Compress{ get; set; }

        /// <summary>
        /// Format configuration of shipped log content
        /// </summary>
        [JsonProperty("Content")]
        public ContentInfo Content{ get; set; }

        /// <summary>
        /// Naming a shipping file. Valid values: `0` (by random number); `1` (by shipping time). Default value: `0`.
        /// </summary>
        [JsonProperty("FilenameMode")]
        public ulong? FilenameMode{ get; set; }

        /// <summary>
        /// Start time for data shipping, which cannot be earlier than the lifecycle start time of the log topic. If you do not specify this parameter, it will be set to the time when you create the data shipping task.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time for data shipping, which cannot be set to a future time. If you do not specify this parameter, it indicates continuous data shipping.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// COS bucket storage type
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "ShipperName", this.ShipperName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamObj(map, prefix + "Compress.", this.Compress);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "FilenameMode", this.FilenameMode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

