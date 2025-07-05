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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEventCasesRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Event Instance Catalog, Example Value:
        /// - Expired: expired
        /// - Not Expired: consuming
        /// - All: all
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("EventType")]
        [System.Obsolete]
        public string EventType{ get; set; }

        /// <summary>
        /// Event Segmentation Type
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }

        /// <summary>
        /// Event Broadcast Type
        /// </summary>
        [JsonProperty("EventBroadcastType")]
        [System.Obsolete]
        public string EventBroadcastType{ get; set; }

        /// <summary>
        /// Event Instance Status, Example Value:
        /// - Consumed: COMSUMED
        /// - Expired: EXPIRED
        /// - Pending Consumption: ACTIVE
        /// - Consuming: CONSUMING
        /// </summary>
        [JsonProperty("Status")]
        [System.Obsolete]
        public string Status{ get; set; }

        /// <summary>
        /// Minimum Creation Time of Event Instance
        /// </summary>
        [JsonProperty("CreationTimeStart")]
        public string CreationTimeStart{ get; set; }

        /// <summary>
        /// Maximum Creation Time of Event Instance
        /// </summary>
        [JsonProperty("CreationTimeEnd")]
        public string CreationTimeEnd{ get; set; }

        /// <summary>
        /// Minimum Trigger Time of Event Instance
        /// </summary>
        [JsonProperty("EventTriggeredTimeStart")]
        public string EventTriggeredTimeStart{ get; set; }

        /// <summary>
        /// Maximum Trigger Time of Event Instance
        /// </summary>
        [JsonProperty("EventTriggeredTimeEnd")]
        public string EventTriggeredTimeEnd{ get; set; }

        /// <summary>
        /// Minimum Consumption Time of Event Instance
        /// </summary>
        [JsonProperty("LogTimeStart")]
        public string LogTimeStart{ get; set; }

        /// <summary>
        /// Maximum Consumption Time of Event Instance
        /// </summary>
        [JsonProperty("LogTimeEnd")]
        public string LogTimeEnd{ get; set; }

        /// <summary>
        /// Event Instance Data Timestamp
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// Event Instance Validity Period
        /// </summary>
        [JsonProperty("TimeToLive")]
        public string TimeToLive{ get; set; }

        /// <summary>
        /// Sort Fields
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// Sorting Order
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
            this.SetParamSimple(map, prefix + "EventBroadcastType", this.EventBroadcastType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreationTimeStart", this.CreationTimeStart);
            this.SetParamSimple(map, prefix + "CreationTimeEnd", this.CreationTimeEnd);
            this.SetParamSimple(map, prefix + "EventTriggeredTimeStart", this.EventTriggeredTimeStart);
            this.SetParamSimple(map, prefix + "EventTriggeredTimeEnd", this.EventTriggeredTimeEnd);
            this.SetParamSimple(map, prefix + "LogTimeStart", this.LogTimeStart);
            this.SetParamSimple(map, prefix + "LogTimeEnd", this.LogTimeEnd);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "TimeToLive", this.TimeToLive);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

