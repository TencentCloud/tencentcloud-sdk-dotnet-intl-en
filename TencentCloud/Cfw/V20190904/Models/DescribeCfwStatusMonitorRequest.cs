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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwStatusMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// Operation type. describe_scene means discovery of scenarios and secondary dropdown options; fetch_scene means acquisition of scenario-based snapshots. Required.
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// Firewall scenario type. Supports internet_edge (Internet edge firewall), nat_cluster (NAT border firewall - cluster), nat_ha (NAT border firewall - primary/secondary), vpc_cluster (VPC boundary firewall - cluster), vpc_ha (VPC boundary firewall - primary/secondary). Required.
        /// </summary>
        [JsonProperty("FirewallType")]
        public string FirewallType{ get; set; }

        /// <summary>
        /// Secondary dropdown option ID. fetch_scene is imported as needed, and the value comes from selection.available_options[].ID returned by describe_scene. internet_edge is the region, NAT is the instance ID, and VPC bandwidth scenario is the firewall group ID. The connections aggregation scenario for VPC_cluster ignores this parameter.
        /// </summary>
        [JsonProperty("SelectionId")]
        public string SelectionId{ get; set; }

        /// <summary>
        /// Secondary dropdown display name. Can be used as an alternative to SelectionId for matching by name. The value comes from selection.available_options[].name returned by describe_scene.
        /// </summary>
        [JsonProperty("SelectionName")]
        public string SelectionName{ get; set; }

        /// <summary>
        /// Engine instance ID. Mainly used in vpc ha scenarios where a firewall group corresponds to multiple instances. Preferentially use the selection.available_options[].instance_ID returned by describe_scene. If only instance_ids are available, select a string value from the array.
        /// </summary>
        [JsonProperty("SelectionInstanceId")]
        public string SelectionInstanceId{ get; set; }

        /// <summary>
        /// Metrics tab. fetch_scene can be passed; used when not passed, this scenario default value. Support bandwidth, connections.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Perspective under the metric. fetch_scene is optional; the default value for this scenario is used when not provided. Supports ip, subnet, session, switch, and vpc. The actual usable composite is subject to the return from describe_scene.
        /// </summary>
        [JsonProperty("Perspective")]
        public string Perspective{ get; set; }

        /// <summary>
        /// NAT primary/secondary number of connections IP perspective range. External means external IP, asset means Asset IP. Only nat_ha + connections + ip is used. Other group input will return InvalidParameter.
        /// </summary>
        [JsonProperty("IpScope")]
        public string IpScope{ get; set; }

        /// <summary>
        /// Preset time range. Default 24h; used by fetch_scene. Supports 5m, 15m, 30m, 1h, 6h, 24h, 3d, 7d, 30d, today, yesterday, day before yesterday, this week, last week, this month.
        /// </summary>
        [JsonProperty("TimePreset")]
        public string TimePreset{ get; set; }

        /// <summary>
        /// Custom start time. Format YYYY-MM-DD HH:MM:SS; must be specified together with EndTime, maximum span 30 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Custom end time. Format YYYY-MM-DD HH:MM:SS; must be consistent with StartTime at the same time, maximum span 30 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Page number, starting from 1. Default is 1; used for the fetch_scene list viewing angle.
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// Entries per page. Default 10, value 1 to 100; used for the viewing angle of the fetch_scene list.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Whether to only get overview data. When true, fetch_scene only requests overview, skips table/detail, and is suitable for viewing scenario snapshot summary.
        /// </summary>
        [JsonProperty("OverviewOnly")]
        public bool? OverviewOnly{ get; set; }

        /// <summary>
        /// Original offset coverage. Option, overwrites the calculation result of Page after input; value 0 to 10000.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting field. Option. InputMax and OutputMax are supported for the Internet boundary IP and NAT IP/subnet perspective. SwitchName is supported for the VPC switch perspective. FlowMax is supported for the VPC IP/VPC perspective. Do not pass other groups.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// Sorting order. Default desc; supports asc, desc.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// Filter condition list. Reserved.
        /// </summary>
        [JsonProperty("Filters")]
        public CfwStatusMonitorFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "FirewallType", this.FirewallType);
            this.SetParamSimple(map, prefix + "SelectionId", this.SelectionId);
            this.SetParamSimple(map, prefix + "SelectionName", this.SelectionName);
            this.SetParamSimple(map, prefix + "SelectionInstanceId", this.SelectionInstanceId);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Perspective", this.Perspective);
            this.SetParamSimple(map, prefix + "IpScope", this.IpScope);
            this.SetParamSimple(map, prefix + "TimePreset", this.TimePreset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OverviewOnly", this.OverviewOnly);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

