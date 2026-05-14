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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopologyNewRequest : AbstractModel
    {
        
        /// <summary>
        /// Business system ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Querying start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Query end time
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Upstream level.
        /// </summary>
        [JsonProperty("UpLevel")]
        public long? UpLevel{ get; set; }

        /// <summary>
        /// Application instance information.
        /// </summary>
        [JsonProperty("ServiceInstance")]
        public string ServiceInstance{ get; set; }

        /// <summary>
        /// downstream hierarchy
        /// </summary>
        [JsonProperty("DownLevel")]
        public long? DownLevel{ get; set; }

        /// <summary>
        /// perspective
        /// </summary>
        [JsonProperty("View")]
        public string View{ get; set; }

        /// <summary>
        /// Filter.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Represents topic (for MQ topology)
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// View filtering list.
        /// </summary>
        [JsonProperty("Selectors")]
        public Selectors Selectors{ get; set; }

        /// <summary>
        /// View ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// TraceID
        /// </summary>
        [JsonProperty("TraceID")]
        public string TraceID{ get; set; }

        /// <summary>
        /// Specifies the top 5 slow response nodes query.
        /// </summary>
        [JsonProperty("IsSlowTopFive")]
        public bool? IsSlowTopFive{ get; set; }

        /// <summary>
        /// Whether the resource layer information is obtained.
        /// </summary>
        [JsonProperty("GetResource")]
        public bool? GetResource{ get; set; }

        /// <summary>
        /// Filters by application tag.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// Node type not displayed.
        /// </summary>
        [JsonProperty("Hidden")]
        public Selectors Hidden{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "UpLevel", this.UpLevel);
            this.SetParamSimple(map, prefix + "ServiceInstance", this.ServiceInstance);
            this.SetParamSimple(map, prefix + "DownLevel", this.DownLevel);
            this.SetParamSimple(map, prefix + "View", this.View);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamObj(map, prefix + "Selectors.", this.Selectors);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TraceID", this.TraceID);
            this.SetParamSimple(map, prefix + "IsSlowTopFive", this.IsSlowTopFive);
            this.SetParamSimple(map, prefix + "GetResource", this.GetResource);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Hidden.", this.Hidden);
        }
    }
}

